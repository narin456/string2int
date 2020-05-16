using System;

namespace string2int
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string result = null;
            Console.WriteLine("Enter Text To Int");
            text = Console.ReadLine();
            foreach (var x in text)
            {
                int myIntVal;
                if(int.TryParse(x.ToString() , out myIntVal))
                {
                    result = result + myIntVal.ToString();
                }
            }
            if (string.IsNullOrEmpty(result))
                result = "null";
            Console.Write("Result : " + result);
            Console.ReadLine();
        }
    }
}
