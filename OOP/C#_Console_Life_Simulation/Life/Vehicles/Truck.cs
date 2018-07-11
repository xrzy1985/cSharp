using System.Text;

namespace Life
{
    class Truck : GenericVehicle
    {

        protected bool air_conditioning;
        protected bool power_windows;
        protected string stereo;
        private double miles_per_gallon;
        private string _oil_weight;
        private int two_or_four_wheel_drive;
        private string truck_bed_size;
        public string truck_name;

        public bool GetAC() { return air_conditioning; }
        public bool GetPowerWindows() { return power_windows; }
        public string GetStereoSetup() { return stereo; }
        public double GetMPG() { return miles_per_gallon; }
        public string GetOil() { return _oil_weight; }
        public int GetTwo_Or_Four_Wheel_Drive() { return two_or_four_wheel_drive; }
        public string GetTruckBedSize() { return truck_bed_size; }
        public string GetTruckName() { return truck_name; }

        protected void SetAC(bool ac) => air_conditioning = ac;
        protected void SetPowerWindows(bool pw) => power_windows = pw;
        protected void SetStereo(string st) => stereo = st;
        public void SetTruckName(string tn) => truck_name = tn;

        public Truck() : base()
        {
            this.air_conditioning = false;
            this.power_windows = false;
            this.stereo = "N/A";
            this.miles_per_gallon = 0.0;
            this._oil_weight = "0w0";
            this.two_or_four_wheel_drive = 2;
            this.truck_bed_size = "Regular Cab";
            this.truck_name = "N/A";
            count += 1;
        }

        public Truck(bool air, bool pw, string stereo, double mpg, string oil, int t_or_f, string tbs, int y, string ma, string mo, string v, int c, string ms, int w, bool hws, int s, bool d, string o, bool cl, string cn = "N/A") : base(y, ma, mo, v, c, ms, w, hws, s, d, o, cl)
        {
            this.air_conditioning = air;
            this.power_windows = pw;
            this.stereo = stereo;
            this.miles_per_gallon = mpg;
            this._oil_weight = oil;
            this.two_or_four_wheel_drive = t_or_f;
            this.truck_bed_size = tbs;
            this.truck_name = cn;
            count += 1;
        }

        public override string PrintVehicleInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {12}\n" +
                "Owner: {9}\n" +
                "Truck Name: {13}\n" +
                "Vin: {11} \n" +
                "Vehicle: {0} {1} {2}\n" +
                "Motor: {3} cylinder {4} engine\n" +
                "Wheels: {5}\n" +
                "Windshield: {6}\n" +
                "Truck Bed Size: {14}\n" +
                "Drive Train: {15} wheel drive\n" +
                "Seats Available: {7}\n" +
                "Oil Weight: {20}\n" +
                "Miles Per Gallon: {19}\n" +
                "Air conditiong: {16}\n" +
                "Power Windows: {17}\n" +
                "Stereo System: {18}\n" +
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
                truck_name, //13 -
                truck_bed_size, // 14 -
                two_or_four_wheel_drive, // 15 -
                air_conditioning, //16 -
                power_windows, // 17 -
                stereo, // 18 -
                miles_per_gallon, // 19 -
                _oil_weight); // 20 -

            return sb.ToString();
        }
    }
}
