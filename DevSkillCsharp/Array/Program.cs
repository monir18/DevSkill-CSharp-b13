namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int[] arr = { 22, 69, 82 };
            // string[] arr = new string[2];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            arr2[0] = 1;
            arr2[1] = 2;
            arr2[2] = 3;
            arr2[3] = 6;
            arr2[4] = 11;
            //arr2[5] = 11;

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("End of arr2");

            int j =0;

            for(int i = 0; i < arr2.Length; i++)
            {
                arr3[j] = arr2[i];
                j++;
            }


            for (int k = 0; k < arr2.Length; k++)
            {
                Console.WriteLine(arr3[k]);
            }
          
        }
    }
}