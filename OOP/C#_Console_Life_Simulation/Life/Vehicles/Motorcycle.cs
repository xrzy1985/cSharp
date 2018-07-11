using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Motorcycle : GenericVehicle
    {
        protected string stereo;
        private double miles_per_gallon;
        private string _oil_weight;
        private bool saddle_bags;
        public string motorcycle_name;

        public string GetStereoSetup() { return stereo; }
        public double GetMPG() { return miles_per_gallon; }
        public string GetOil() { return _oil_weight; }
        public bool GetSaddleBags() { return saddle_bags; }
        public string GetTruckName() { return motorcycle_name; }

        protected void SetStereo(string st) => stereo = st;
        public void SetTruckName(string mn) => motorcycle_name = mn;

        public Motorcycle() : base()
        {
            this.stereo = "N/A";
            this.miles_per_gallon = 0.0;
            this._oil_weight = "0w0";
            this.saddle_bags = false;
            this.motorcycle_name = "N/A";
            count += 1;
        }

        public Motorcycle(string stereo, double mpg, string oil, bool sb, int y, string ma, string mo, string v, int c, string ms, int w, bool hws, int s, bool d, string o, bool cl, string mn = "N/A") : base(y, ma, mo, v, c, ms, w, hws, s, d, o, cl)
        {
            this.stereo = stereo;
            this.miles_per_gallon = mpg;
            this._oil_weight = oil;
            this.saddle_bags = sb;
            this.motorcycle_name = mn;
            count += 1;
        }

        public override string PrintVehicleInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {12}\n" +
                "Owner: {9}\n" +
                "Motorcycle Name: {14}\n" +
                "Vin: {11} \n" +
                "Vehicle: {0} {1} {2}\n" +
                "Motor: {3} cylinder {4} engine\n" +
                "Wheel Count: {5}\n" +
                "Windshield: {6}\n" +
                "Saddle Bags: {13}\n" +
                "Seats Available: {7}\n" +
                "Oil Weight: {17}\n" +
                "Miles Per Gallon: {16}\n" +
                "Stereo System: {15}\n" +
                "Drivability: {8}\n" +
                "Clean: {10}\n",
                _year, // 0 -
                _make, // 1 -
                _model, // 2 -
                _cylinders, // 3 -
                _motor_size, // 4 -
                _wheels, // 5 -
                has_windshield, // 6 -
                _seats, // 7
                is_driveable, //8  
                owner, // 9
                clean, // 10
                _vin, // 11
                _id, // 12 -
                saddle_bags, //13 -
                motorcycle_name, // 14 -
                stereo, // 15 -
                miles_per_gallon, // 16 -
                _oil_weight); // 17 -

            return sb.ToString();
        }
    }
}
