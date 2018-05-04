using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Car : GenericVehicle
    {

        protected bool air_conditioning;
        protected bool power_windows;
        protected string stereo;
        private double miles_per_gallon;
        private string _oil_weight;
        public string car_name;

        public bool GetAC() { return air_conditioning; }
        public bool GetPowerWindows() { return power_windows; }
        public string GetStereoSetup() { return stereo; }
        public double GetMPG() { return miles_per_gallon; }
        public string GetOil() { return _oil_weight; }
        public string GetCarName() { return car_name; }

        protected void SetAC(bool ac) => air_conditioning = ac;
        protected void SetPowerWindows(bool pw) => power_windows = pw;
        protected void SetStereo(string st) => stereo = st;
        protected void SetCarName(string cn) => car_name = cn;

        public Car() : base()
        {
            this.air_conditioning = false;
            this.power_windows = false;
            this.stereo = "N/A";
            this.miles_per_gallon = 0.0;
            this._oil_weight = "0w0";
            this.car_name = "N/A";
        }

        public Car(bool air, bool pw, string stereo, double mpg, string oil, int y, string ma, string mo, string v, int c, string ms, int w, bool hws, int s, bool d, string o, bool cl, string cn = "N/A") : base(y, ma, mo, v, c, ms, w, hws, s, d, o, cl)
        {
            this.air_conditioning = air;
            this.power_windows = pw;
            this.stereo = stereo;
            this.miles_per_gallon = mpg;
            this._oil_weight = oil;
            this.car_name = cn;
        }

        public override string PrintVehicleInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {12}\nOwner: {9}\nCar Name: {13}\nVin: {11} \nVehicle: {0} {1} {2}\nMotor: {3} cylinder {4} engine\nWheels: {5}\nWindshield: {6}\nSeats Available: {7}\nDrivability: {8}\nClean: {10}\n",
                _year, _make, _model, _cylinders, _motor_size, _wheels, has_windshield, _seats, is_driveable, owner, clean, _vin, _id, car_name);

            sb.AppendFormat("Oil Weight: {4}\nMiles Per Gallon: {3}\nAir conditiong: {0}\nPower Windows: {1}\nStereo System: {2}\n ", this.air_conditioning, this.power_windows, this.stereo, this.miles_per_gallon, this._oil_weight);

            return sb.ToString();
        }
    }
}

