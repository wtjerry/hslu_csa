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
        private const int MeasurementInterval = 80;

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


            this.robot.Position = new PositionInfo(0, 0, 0);
            ResetLabels();


            this.robot.Drive.DriveCtrl.PowerLeft = true;
            this.robot.Drive.DriveCtrl.PowerRight = true;


            Thread.Sleep(10);


            this.robot.Drive.RunLine(DesiredXLength, Speed, Acceleration);
            while (!this.robot.Drive.Done)
            {
                this.updateCurrentPositionLabel(this.robot.Position.X.ToString(CultureInfo.InvariantCulture));

                if (!startXPositionFound && this.ThereIsAnObject())
                {
                    startXPositionOfObject = this.robot.Position.X;
                    var progressText = $" | startXPos: {startXPositionOfObject}";
                    this.updateProgressLabel(progressText);
                    startXPositionFound = true;
                }
                if (startXPositionFound && !endXPositionFound && this.ThereIsNoObject())
                {
                    endXPositionOfObject = this.robot.Position.X;
                    var progressText = $" | endXPos: {endXPositionOfObject}";
                    this.updateProgressLabel(progressText);
                    endXPositionFound = true;
                }
                Sleep();
            }


            Turn90DegreesLeft();
            this.robot.Position = new PositionInfo(0, 0, 0);


            this.robot.Drive.RunLine(DesiredYLength, Speed, Acceleration);
            while (!this.robot.Drive.Done)
            {
                this.updateCurrentPositionLabel(this.robot.Position.X.ToString(CultureInfo.InvariantCulture));

                if (!startYPositionFound && this.ThereIsAnObject())
                {
                    startYPositionOfObject = this.robot.Position.X;
                    var progressText = $" | startYPos: {startYPositionOfObject}";
                    this.updateProgressLabel(progressText);
                    startYPositionFound = true;
                }
                if (startYPositionFound && !endYPositionFound && this.ThereIsNoObject())
                {
                    endYPositionOfObject = this.robot.Position.X;
                    var progressText = $" | endYPos: {endYPositionOfObject}";
                    this.updateProgressLabel(progressText);
                    endYPositionFound = true;
                }
                Sleep();
            }


            Turn90DegreesLeft();
            this.robot.Position = new PositionInfo(0, 0, 0);


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
}
