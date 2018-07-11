namespace Life
{
    class Food
    {
        public string food;

        public Food() { this.food = "Unknown food"; }

        public Food(string f)
        {
            this.food = f;
        }

        ~Food(){ System.Diagnostics.Trace.WriteLine("Food's destructor is called.\n"); }

        public void SetFood(string f) => food = f;

        public string GetFood()
        {
            return this.food;
        }
    }
}
