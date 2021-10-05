using System;

//This is a program to calculate the number of containers of paint and number of carpet tiles required for grand circus room
//Author: Yosha Kunnummal
//Date: 10/04/2021
namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            char enterKey = 'y';
            while (enterKey == 'y')
            {
                Console.WriteLine();

                //Input length
                Console.Write("Enter Length:");
                string inputLength = Console.ReadLine();
                float length = float.Parse(inputLength);

                //Input width
                Console.Write("Enter Width:");
                string inputWidth = Console.ReadLine();
                float width = float.Parse(inputWidth);

                //Calculate area
                float area = length * width;
                Console.WriteLine("Area:" + area);

                //Calculate Perimeter
                float perimeter = 2 * (length + width);
                Console.WriteLine("Perimeter:" + perimeter);

                //Calculate carpet tiles(1 carpet tiles per 5 sq foot)
                Console.WriteLine("Carpet Tiles:" + (area / 5));

                //Calcualte the number of containers of paint
                Console.WriteLine("Paint:" + (perimeter / 5));

                //Input height
                Console.Write("Enter the height:");
                string inputHeight = Console.ReadLine();
                float height = float.Parse(inputHeight);

                //Calculate volume
                float volume = length * width * height;
                Console.WriteLine("Volume:" + volume);

                Console.WriteLine();

                Console.Write("Continue? (y/n):");
                enterKey = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank You For Using Grand Circus Room Calculator");
            Console.WriteLine("Good Bye!");
        }
    }
}
