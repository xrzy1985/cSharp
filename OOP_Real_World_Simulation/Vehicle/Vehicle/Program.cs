using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class GenericVehicle
    {
        private int _year;
        private string _make;
        private string _model;
        private string _vin;
        private int _cylinders;
        private string _motor_size;
        private int _wheels;
        protected bool has_windshield;
        private int _seats;
        protected bool is_driveable;
        public string owner;
        public bool clean;

        public int GetYear() { return _year; }
        public string GetMake() { return _make; }
        public string GetModel() { return _model; }
        public string GetVin() { return _vin; }
        public int GetCylinders() { return _cylinders; }
        public string GetMotorSize() { return _motor_size; }
        public int GetWheels() { return _wheels; }
        public bool GetWindshield() { return has_windshield; }
        public int GetSeats() { return _seats; }
        public bool GetDrivability() { return is_driveable; }
        public string GetOwner() { return owner; }
        public bool IsItClean() { return clean; }

        public void SetYear(int y) => _year = y;
        public void SetMake(string ma) => _make = ma;
        public void SetModel(string mo) => _model = mo;
        public void SetVin(string v) => _vin = v;
        public void SetCylinders(int c) => _cylinders = c;
        public void SetMotorSize(string ms) => _motor_size = ms;
        public void SetWheels(int w) => _wheels = w;
        public void SetWindshield(bool hws) => has_windshield = hws;
        public void SetSeats(int s) => _seats = s;
        public void SetDrivability(bool d) => is_driveable = d;
        public void SetOwner(string o) => owner = o;
        public void CleanIt(bool cl) => clean = cl;

        public GenericVehicle()
        {
            this._year = 0000;
            this._make = "N/A";
            this._model = "N/A";
            this._vin = "00000000000000";
            this._cylinders = 0;
            this._motor_size = "N/A";
            this._wheels = 0;
            this.has_windshield = false;
            this._seats = 0;
            this.is_driveable = false;
            this.owner = "N/A";
            this.clean = false;
        }

        public GenericVehicle(int y, string ma, string mo, string v, int c, string ms, int w, bool hws, int s, bool d, string o, bool cl)
        {
            this._year = y;
            this._make = ma;
            this._model = mo;
            this._vin = v;
            this._cylinders = c;
            this._motor_size = ms;
            this._wheels = w;
            this.has_windshield = hws;
            this._seats = s;
            this.is_driveable = d;
            this.owner = o;
            this.clean = cl;

        }

        public string PrintVehicleInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Owner {9} \nVin: {11} \nVehicle: {0} {1} {2}\nMotor: {3} cylinder {4} engine\nWheels: {5}\nWindshield: {6}\nSeats Available: {7}\nDrivability: {8}\nClean: {10}",
                _year, _make, _model, _cylinders, _motor_size, _wheels, has_windshield, _seats, is_driveable, owner, clean, _vin);

            return sb.ToString();
        }

        public string ReturnString(int i)
        {
            String str = i.ToString();

            return str;
        }
    }

    class Driver
    {
        public void Drive(GenericVehicle v)
        {
            if(v.GetDrivability() == true)
            {
                Console.WriteLine("You can drive this, mate");
            }
            else
            {
                Console.WriteLine("You cannot drive this, mate");
            }

        }

        static void Main(string[] args)
        {
            String br = "\n";

            // int y, string ma, string mo, string v, int c, string ms, int w, 
            //      bool hws, int s, bool d, string o, bool cl

            GenericVehicle mustang = new GenericVehicle(2000, "Ford", "Mustang", "00000000", 6, "3.8 Liter", 4, true, 4, true, "James Patterson", false);

            Console.WriteLine(mustang.PrintVehicleInformation());

            mustang.owner = "Jim Patterson";

            // mustang._vin = "0009";

            Console.WriteLine(br);

            Console.WriteLine(mustang.PrintVehicleInformation());

            Console.WriteLine(br);

            Driver james = new Driver();

            james.Drive(mustang);

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

        }
    }

}

