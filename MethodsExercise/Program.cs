namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                $"lava. Hysteria washed over {name}. It was becoming clear. {name} wasn't where they thought they " +
                $"were. {name} was... at a {band} concert.");


        }
    }
}