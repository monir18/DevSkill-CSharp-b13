namespace DataTypes
{
    internal class Program
    {

        static unsafe void Main(string[] args)
        {
            //int age=0;
            //Console.WriteLine(age);

            //int a = 10;
            //Console.WriteLine(a);
            //int b = a;

            //Console.WriteLine(b);
            //b = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //string txt = "Hello";
            //Console.WriteLine(txt);
            //string ss = txt;
            //Console.WriteLine(ss);

            string[] arr = new string[2];
            arr[0] = "1";
            arr[1] = "22";
            Console.WriteLine(arr[1]);

            int a = 10;
            int * ad = &a;
            *ad = 20;

            //Console.WriteLine((int)&val);

    

            Console.WriteLine(*ad);
            Console.WriteLine(a);

        }
    }
}