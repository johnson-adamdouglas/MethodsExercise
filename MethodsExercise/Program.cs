using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    internal class Program
    {
        //-------------------------------------------Declared Methods----------------------------------------
        public static int Add(int num1, int num2) 
        {
            return num1 + num2;
            }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2) 
        { 
            return num1 * num2;
        }
            
        public static double Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Sum(params int[] nums)
        {
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        public static int Minus(params int[] nums) 
        {
            var diff = 100;
            for (int i = 0; i < nums.Length; i++)
            {
                diff -= nums[i];
            }
            return diff;
        }

        public static int Mult(params int[] nums)
        {
            var prod = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                prod *= nums[i];
            }
            return prod;
        }



        static void Main(string[] args)
        {
            //-------------------------------------------Params Keyword------------------------------------------

            Console.WriteLine("Type a number greater than 100");
            var myNumber = Console.ReadLine();
            Console.WriteLine(Sum(1, 8, 7, 10));
            Console.WriteLine(Minus(50, 25, 20));
            Console.WriteLine(Mult(5,5,5));

            //---------------------------------------------------------------------------------------------------
            //----------------------------------------Exercise 1---------------------------------------------
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"{band}?... Seriously?");

            Console.ReadLine();

            Console.WriteLine($"{band} it is. Whatever. They're your ears, not mine.");

            Thread.Sleep(2000);

            Console.WriteLine();

            Console.WriteLine($"Now I will tell you a story about {name}. One morning, {name} walked outside " +
                $"to catch some fresh morning air and was overcome with an odor {name} had never experienced." +
                $"The smell was oddly familiar, but at the same time it was like {name} was using their nose " +
                $"for the first time. {name} suddenly had an epiphany. The smell... was... {color}! 'Wait, what?'" +
                $"{name} exclaimed. A sudden wave washed over them. The morning dew raised off the grass and" +
                $" morphed into a visible mist that steadily rose into the sky to form white, fluffy clouds." +
                $"A single {animal} swooped down from the sky and landed on a nearby fire hydrant. The world " +
                $"was turning upside down, inside out. It was... euphoric. The euphoria didn't last long, " +
                $"however. Quickly, the sky turned dark, the grass began to turn brown, entire trees wilted." +
                $"A faint, familiar sound could be heard in the distance. The earth began to decay and {name} " +
                $"began slowly sinking into the ever-softening ground below. The sound grew louder. The ground " +
                $"grew softer. {name} sank lower. Lower. Lower. It started getting uncomfortably hot. The " +
                $"surrounding earth began to crumble away revealing a complex system of red streams of molten" +
                $" lava. Hysteria washed over {name}. It was becoming clear. {name} wasn't where they thought they " +
                $"were. {name} was... at a {band} concert.");

            //---------------------------------------Exercise 2------------------------------------------
            Console.WriteLine();
            Console.WriteLine("Choose a number between 50 and 100.");
            int myNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Great! Now choose a number between 1 and 49.");
            int myNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{myNum1} + {myNum2} = {Add(myNum1, myNum2)}");
            Console.WriteLine($"{myNum1} - {myNum2} = {Subtract(myNum1, myNum2)}");
            Console.WriteLine($"{myNum1} x {myNum2} = {Multiply(myNum1, myNum2)}");
            Console.WriteLine($"{myNum1} / {myNum2} = {Divide(myNum1, myNum2)}");

            //---------------------------------------Challenge Mode--------------------------------------


        }
    }
}