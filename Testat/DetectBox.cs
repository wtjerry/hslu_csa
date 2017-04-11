using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RobotCtrl;

namespace Testat
{
    public class DetectBox
    {
        private const float Acceleration = 0.8f;
        private const float Speed = 0.1f;
        private const int NumberOfMeasurementsInRangeForBoxToBeDetected = 10;
        private const int MeasurementInterval = 20;

        const float DesiredXLength = 2.0f;
        const float DesiredYLength = 1.5f;

        private readonly Robot robot;
        private readonly Label progressLabel;
        private readonly Label currentPositionLabel;
        private readonly BlinkLEDs ledBlinking;


        private int CountMeasurementsInRange = 0;


        public DetectBox(
            Robot robot,
            Label progressLabel,
            Label currentPositionLabel, 
            BlinkLEDs ledBlinking)
        {
            this.robot = robot;
            this.progressLabel = progressLabel;
            this.currentPositionLabel = currentPositionLabel;
            this.ledBlinking = ledBlinking;
        }

        public void Run()
        {
            float startXPositionOfObject = 0;
            float endXPositionOfObject = 0;
            float startYPositionOfObject = 0;
            float endYPositionOfObject = 0;
            var startXPositionFound = false;
            var endXPositionFound = false;
            var startYPositionFound = false;
            var endYPositionFound = false;


            var firstSideMeasurements = new List<RadarDistanceAndMotorDistanceTuple>();
            var secondSideMeasurements = new List<RadarDistanceAndMotorDistanceTuple>();


            this.robot.Position = new PositionInfo(0, 0, 0);
            ResetLabels();


            this.robot.Drive.DriveCtrl.PowerLeft = true;
            this.robot.Drive.DriveCtrl.PowerRight = true;


            Thread.Sleep(10);


            this.robot.Drive.RunLine(DesiredXLength, Speed, Acceleration);
            this.robot.Drive.MotorCtrlLeft.ResetTicks();
            while (!this.robot.Drive.Done)
            {
                var distance = this.getDistance();
                this.updateCurrentPositionLabel(distance.ToString(CultureInfo.InvariantCulture));
                var radarDistance = this.robot.Radar.Distance;
                firstSideMeasurements.Add(new RadarDistanceAndMotorDistanceTuple(radarDistance, distance));
                Sleep();
            }

            var normalizedMeasurementsForFirstSide = NormalizedMeasurements(firstSideMeasurements);
            var lengthOfFirstSide = CalculateSideLength(normalizedMeasurementsForFirstSide);
            var lengthFirstSideText = $" | NEW FANCY CALCULATED FIRST LENGHT: {lengthOfFirstSide}";
            this.updateProgressLabel(lengthFirstSideText);


            Turn90DegreesLeft();
            this.robot.Position = new PositionInfo(0, 0, 0);
            this.robot.Drive.MotorCtrlLeft.ResetTicks();


            this.robot.Drive.RunLine(DesiredYLength, Speed, Acceleration);
            while (!this.robot.Drive.Done)
            {
                var distance = this.getDistance();
                this.updateCurrentPositionLabel(distance.ToString(CultureInfo.InvariantCulture));
                var radarDistance = this.robot.Radar.Distance;
                firstSideMeasurements.Add(new RadarDistanceAndMotorDistanceTuple(radarDistance, distance));
                Sleep();
            }


            var normalizedMeasurementsForSecondSide = NormalizedMeasurements(secondSideMeasurements);
            var lengthOfSecondSide = CalculateSideLength(normalizedMeasurementsForSecondSide);
            var lengthSecondSideText = $" | NEW FANCY CALCULATED SECOND LENGHT: {lengthOfSecondSide}";
            this.updateProgressLabel(lengthSecondSideText);

            Turn90DegreesLeft();
            this.robot.Position = new PositionInfo(0, 0, 0);
            this.robot.Drive.MotorCtrlLeft.ResetTicks();


            this.robot.Drive.RunLine(DesiredXLength, Speed, Acceleration);
            while (!this.robot.Drive.Done)
            {
                Sleep();
            }


            Turn90DegreesLeft();
            this.robot.Position = new PositionInfo(0, 0, 0);


            this.robot.Drive.RunLine(DesiredYLength, Speed, Acceleration);
            while (!this.robot.Drive.Done)
            {
                Sleep();
            }


            Turn90DegreesLeft();
            this.robot.Position = new PositionInfo(0, 0, 0);

            
            var objectXLength = endXPositionOfObject - startXPositionOfObject;
            var progressText1 = $" | xLength: {objectXLength}";
            this.updateProgressLabel(progressText1);

            var objectYLength = endYPositionOfObject - startYPositionOfObject;
            var progressText2 = $" | yLength: {objectYLength}";
            this.updateProgressLabel(progressText2);

            var area = objectXLength * objectYLength;
            var progressText3 = $" | area: {area}";
            this.updateProgressLabel(progressText3);


            this.robot.Drive.DriveCtrl.PowerLeft = false;
            this.robot.Drive.DriveCtrl.PowerRight = false;


            this.robot.Position = new PositionInfo(0, 0, 0);
            this.ledBlinking.Stop();
        }

        private static double CalculateSideLength(List<RadarDistanceAndMotorDistanceTuple> normalizedMeasurementsForFirstSide)
        {
            var startOfBox = double.NaN;
            var endOfBox = double.NaN;
            var startOfBoxFound = false;
            for (var i = 1; i < normalizedMeasurementsForFirstSide.Count; i++)
            {
                var previousMeasurement = normalizedMeasurementsForFirstSide[i - 1];
                var currentMeasurement = normalizedMeasurementsForFirstSide[i];
                var relativeRadarDeviationOfPreviousToCurrent = previousMeasurement.RadarDistance / currentMeasurement.RadarDistance;
                if (
                    startOfBoxFound == false 
                    && relativeRadarDeviationOfPreviousToCurrent < 1.1 
                    && relativeRadarDeviationOfPreviousToCurrent > 0.9
                    && currentMeasurement.RadarDistance < 1.5
                    && currentMeasurement.RadarDistance > 0.1)
                {
                    startOfBox = currentMeasurement.MotorDistance;
                    startOfBoxFound = true;
                }

                var relativeRadarDeviationOfCurrentToPrevious = currentMeasurement.RadarDistance / previousMeasurement.RadarDistance;
                if (startOfBoxFound 
                    && relativeRadarDeviationOfCurrentToPrevious > 1.1)
                {
                    endOfBox = previousMeasurement.MotorDistance;
                    break;
                }
            }

            var length = endOfBox - startOfBox;

            return length;
        }

        private static List<RadarDistanceAndMotorDistanceTuple> NormalizedMeasurements(List<RadarDistanceAndMotorDistanceTuple> firstSideMeasurements)
        {
            const int NormalisationConstant = 4;

            var normalizedMeasurements = new List<RadarDistanceAndMotorDistanceTuple>();
            for (var i = 0; i < firstSideMeasurements.Count; i += NormalisationConstant)
            {
                if (i + NormalisationConstant < firstSideMeasurements.Count)
                {
                    var fiveMeasurements = firstSideMeasurements.GetRange(i, NormalisationConstant);
                    var radarDistanceAverage = fiveMeasurements.Average(x => x.RadarDistance);
                    var motorDistanceAverage = fiveMeasurements.Average(x => x.MotorDistance);
                    normalizedMeasurements.Add(new RadarDistanceAndMotorDistanceTuple(radarDistanceAverage, motorDistanceAverage));
                }
            }
            return normalizedMeasurements;
        }

        private void ResetLabels()
        {
            this.Invoke(() => this.progressLabel.Text = string.Empty);
            this.Invoke(() => this.currentPositionLabel.Text = string.Empty);
        }

        private static void Sleep()
        {
            Thread.Sleep(MeasurementInterval);
        }

        private bool ThereIsAnObject()
        {
            var radarDistance = this.robot.Radar.Distance;
            if (radarDistance > 0.1 && radarDistance < 1.5)
            {
                if (this.CountMeasurementsInRange == NumberOfMeasurementsInRangeForBoxToBeDetected)
                {
                    this.CountMeasurementsInRange = 0;
                    return true;
                }
                else
                {
                    this.CountMeasurementsInRange++;
                    return false;
                }
            }
            return false;
        }

        private bool ThereIsNoObject()
        {
            var radarDistance = this.robot.Radar.Distance;
            if (radarDistance < 0.1 || radarDistance > 1.5)
            {
                if (this.CountMeasurementsInRange == NumberOfMeasurementsInRangeForBoxToBeDetected)
                {
                    this.CountMeasurementsInRange = 0;
                    return true;
                }
                else
                {
                    this.CountMeasurementsInRange++;
                    return false;
                }
            }
            return false;
        }

        private double getDistance()
        {
            return (this.robot.Drive.MotorCtrlLeft.Ticks * -1d) / 28700d * 23.87d;
        }

        private void Turn90DegreesLeft()
        {
            this.robot.Drive.RunTurn(90, Speed, Acceleration);
            while (!this.robot.Drive.Done)
            {
                Sleep();
            }
        }

        private void updateProgressLabel(string data)
        {
            this.Invoke(() => this.progressLabel.Text += data);
        }


        private void updateCurrentPositionLabel(string data)
        {
            this.Invoke(() => this.currentPositionLabel.Text = data);
        }

        private void Invoke(Action action)
        {
            if (this.currentPositionLabel.InvokeRequired)
            {
                this.currentPositionLabel.Invoke(action);
            }
        }
    }

    public class RadarDistanceAndMotorDistanceTuple
    {
        public double RadarDistance { get; private set; }
        public double MotorDistance { get; private set; }

        public RadarDistanceAndMotorDistanceTuple(double radarDistance, double motorDistance)
        {
            this.RadarDistance = radarDistance;
            this.MotorDistance = motorDistance;
        }
    }
}
