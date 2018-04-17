using System;

delegate void NumberChanger(int n);

namespace DelegateNameSpace
{
    class DelegateClass
    {
        // create a variable to use 
        static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Add Num Named Method: {0}", num);
        }


        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("MultNum Named Method: {0}", num);
        }


        public static int getNum()
        {
            return num;
        }


        static void Main(string[] args)
        {
            //create delegate instances using  the anonymous method
            NumberChanger nc = delegate (int x) {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            //calling the delegate  directly above using the anonymous method
            nc(10);

            //instantiating the delegate using the named method
            // now, whenever nc is passed a value, it will be sent
            // to the addNum method
            nc = new NumberChanger(AddNum);

            //calling the delegate using the named methods
            nc(5);

            //instantiating the delegate using another named method
            nc = new NumberChanger(MultNum);

            //calling the delegate using the named methods
            nc(2);
            Console.ReadKey();
        }
    }
}
