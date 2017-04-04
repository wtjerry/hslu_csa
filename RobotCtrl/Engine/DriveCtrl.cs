//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: MotorCtrl.cs 973 2015-11-10 13:12:03Z zajost $
//------------------------------------------------------------------------------
using System;
using System.Threading;

namespace RobotCtrl
{
    public class DriveCtrl : IDisposable
    {
        private readonly int ioAddress;

        public DriveCtrl(int IOAddress)
        {
            this.ioAddress = IOAddress;
            Reset();
        }

        public void Dispose()
        {
            Reset();
        }

        /// <summary>
        /// Schaltet die Stromversorgung der beiden Motoren ein oder aus.
        /// </summary>
        public bool Power
        {
            set { DriveState = (value) ? DriveState | 0x03 : DriveState & ~0x03; }
        }
        
        /// <summary>
        /// Liefert den Status ob der rechte Motor ein-/ausgeschaltet ist bzw. schaltet den rechten Motor ein-/aus.
        /// Die Information dazu steht im Bit0 von DriveState.
        /// </summary>
        public bool PowerRight
        {
            get { return this.getBitOnIndex(this.DriveState, 0); }
            set { DriveState = this.setBitOnIndex(this.DriveState, 0, value); }
        }

        /// <summary>
        /// Liefert den Status ob der linke Motor ein-/ausgeschaltet ist bzw. schaltet den linken Motor ein-/aus.
        /// </summary>
        public bool PowerLeft
        {
            get { return this.getBitOnIndex(this.DriveState, 1); }
            set { DriveState = this.setBitOnIndex(this.DriveState, 1, value); }
        }

        /// <summary>
        /// Bietet Zugriff auf das Status-/Controlregister
        /// </summary>
        public int DriveState
        {
            get { return IOPort.Read(this.ioAddress); }
            set { IOPort.Write(this.ioAddress, value); }
        }

        /// <summary>
        /// Setzt die beiden Motorencontroller (LM629) zurück, 
        /// indem kurz die Reset-Leitung aktiviert wird.
        /// </summary>
        public void Reset()
        {
            this.DriveState = 0x00;
            Thread.Sleep(5);
            this.DriveState = 0x80;
            Thread.Sleep(5);
            this.DriveState = 0x00;
            Thread.Sleep(5);
        }

        private bool getBitOnIndex(int data, int index)
        {
            int bitmask = 1 << index;
            int maskedData = data & bitmask;
            return (maskedData != 0);
        }

        private int setBitOnIndex(int data, int index, bool desiredBitState)
        {
            bool isBitCurrentlySet = getBitOnIndex(data, index);
            if (isBitCurrentlySet && desiredBitState == false)
            {
                // bit löschen
                data = data & ~(1 << index);
            }
            else if(!isBitCurrentlySet && desiredBitState == true)
            {
                // bit setzen
                data = data | (1 << index);
            }

            return data;
        }
    }
}
