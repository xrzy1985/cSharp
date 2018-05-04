using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class GenericVehicle : IVehicle
    {
        public bool car_parked = true;
        public bool engine_running = false;
        public int count = 12309;

        protected int _id;
        protected int _year;
        protected string _make;
        protected string _model;
        protected string _vin;
        protected int _cylinders;
        protected string _motor_size;
        protected int _wheels;
        protected bool has_windshield;
        protected int _seats;
        protected bool is_driveable;
        public string owner;
        public bool clean;

        public int GetID() { return _id; }
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

        private void SetID(int id) => _id = id;
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
            this._id = count;
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
            count += 1;
        }

        public GenericVehicle(int y, string ma, string mo, string v, int c, string ms, int w, bool hws, int s, bool d, string o, bool cl)
        {
            this._id = count;
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
            count += 1;
        }

        public virtual string PrintVehicleInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {12}\nOwner: {9} \nVin: {11} \nVehicle: {0} {1} {2}\nMotor: {3} cylinder {4} engine\nWheels: {5}\nWindshield: {6}\nSeats Available: {7}\nDrivability: {8}\nClean: {10}",
                _year, _make, _model, _cylinders, _motor_size, _wheels, has_windshield, _seats, is_driveable, owner, clean, _vin, _id);

            return sb.ToString();
        }

        public void TurnOnEngine()
        {
            engine_running = true;
            Console.WriteLine("You turned the vehicle on, mate.\n");
        }

        public void TurnOffEngine()
        {
            if (Is_Parked() == false)
            {
                Console.WriteLine("You're crazy, that'll ruin your car, mate");
            }
            else
            {
                engine_running = false;
                Console.WriteLine("You shut the engine off.\n");
            }
        }

        public void Honk()
        {
            Console.WriteLine("Honk Honk\n");
        }

        public bool Is_Parked()
        {
            if (car_parked == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
