namespace OperatorExercise
{
    internal class Program
    {
       


        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            }

            Console.WriteLine("What is the area of your circle");
            Console.WriteLine("Please type the radius of your circle below.");
            Console.WriteLine("----------------");

            var radius = double.Parse(Console.ReadLine());
            var userArea = AreaOfCircle(radius);

          
                 
            Console.WriteLine($"The area of your circle is {userArea}.");



           
           




        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;

        }




    }
}








