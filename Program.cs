namespace march28hometask1return
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 45, 24, 43, 52, 63, 74, 84 };
            Console.WriteLine(Min(array));
            Console.WriteLine(Area(2));
            Console.WriteLine(Area(2, 3)); 
            Console.WriteLine(Area(2, 3, 4)); 
            Console.WriteLine(Area(2, 3, 4, 5)); 
        }
        public static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.Write("Array min element: ");
            return min;
        }
        public static double Area(double r)
        {
            int p = 3;
            Console.Write("Cevre sahesi: ");
            return p*r*r;
        }
        public static double Area(double a, double b)
        {
            Console.Write("Duzbucaqli sahesi: ");
            return a * b;
        }
        public static double Area(double a, double b, double c)
        {
            Console.Write("Duzbucaqli papalelopiped sahesi: ");
            return 2 * (a * b + a * c + b * c);
        }
        public static double Area(double a, double b, double c, double r)
        {
            double p = (a + b + c) / 2;
            Console.Write("Ucbucaq daxiline cekilmis cevre sahesi: ");
            return p * r;
        }
        //arqument kimi kesr ededleride verile bildiyinden butun parametlerin tipine double vermisem




    }
}