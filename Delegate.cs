using System;

namespace Delegate
{
    class Delegate
    {
        //Delegate declartion
        public delegate int calc(int num1, int num2);


        static void Main(string[] args)
        {

            calc[] operations = {
                //delegate (int num1,int num2){return num1 + num2; },
                (num1,num2)=> num1+num2,
                (num1,num2)=> num1-num2,
               //delegate (int num1,int num2){return num1 - num2; },

    };
            foreach(calc operation in operations)
            {
                Console.WriteLine(operation(1, 2));
            }
            }

    }
}

