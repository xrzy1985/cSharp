using System.Text;

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
            count += 1;
        }

        ~Car() { System.Diagnostics.Trace.WriteLine("Car's destructor is called.\n"); }

        public Car(bool air, bool pw, string stereo, double mpg, string oil, int y, string ma, string mo, string v, int c, string ms, int w, bool hws, int s, bool d, string o, bool cl, string cn = "N/A") : base(y, ma, mo, v, c, ms, w, hws, s, d, o, cl)
        {
            this.air_conditioning = air;
            this.power_windows = pw;
            this.stereo = stereo;
            this.miles_per_gallon = mpg;
            this._oil_weight = oil;
            this.car_name = cn;
            count += 1;
        }

        public override string PrintVehicleInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {12}\n" +
                "Owner: {9}\n" +
                "Car Name: {13}\n" +
                "Vin: {11} \n" +
                "Vehicle: {0} {1} {2}\n" +
                "Motor: {3} cylinder {4} engine\n" +
                "Wheels: {5}\n" +
                "Windshield: {6}\n" +
                "Seats Available: {7}\n" +
                "Oil Weight: {18}\n" +
                "Miles Per Gallon: {17}\n" +
                "Air conditiong: {14}\n" +
                "Power Windows: {15}\n" +
                "Stereo System: {16}\n",
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
                car_name, //13 -
                air_conditioning, //14 -
                power_windows, // 15 -
                stereo, // 16 -
                miles_per_gallon, // 17 -
                _oil_weight); // 18 -
            return sb.ToString();
        }
    }
}

