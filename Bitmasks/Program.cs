using Bitmasks;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iMin = 0;
            int iMax = 32;
            do
            {
                Console.WriteLine($"Enter a number between {iMin} and {iMax}");
                Console.WriteLine("Enter <exit> to exit or <loop> to see how addition works");

                string? input = Console.ReadLine();
                int iInput;

                if (int.TryParse(input, out iInput))
                {
                    if (iInput < iMin || iInput > iMax)
                    {
                        continue;
                    }

                    Console.WriteLine($"{iInput} & {(int)BitMaskEnum.Bit1} = {(iInput & (int)BitMaskEnum.Bit1) == (int)BitMaskEnum.Bit1}");
                    Console.WriteLine($"{iInput} & {(int)BitMaskEnum.Bit2} = {(iInput & (int)BitMaskEnum.Bit2) == (int)BitMaskEnum.Bit2}");
                    Console.WriteLine($"{iInput} & {(int)BitMaskEnum.Bit3} = {(iInput & (int)BitMaskEnum.Bit3) == (int)BitMaskEnum.Bit3}");
                    Console.WriteLine($"{iInput} & {(int)BitMaskEnum.Bit4} = {(iInput & (int)BitMaskEnum.Bit4) == (int)BitMaskEnum.Bit4}");
                }
                else if (input?.ToLower() == "loop")
                {
                    Console.WriteLine($"Starting at {iInput}");
                    Console.WriteLine($"{iInput} |= {(int)BitMaskEnum.Bit1} = {iInput |= (int)BitMaskEnum.Bit1}");
                    Console.WriteLine($"{iInput} |= {(int)BitMaskEnum.Bit2} = {iInput |= (int)BitMaskEnum.Bit2}");
                    Console.WriteLine($"{iInput} |= {(int)BitMaskEnum.Bit3} = {iInput |= (int)BitMaskEnum.Bit3}");
                    Console.WriteLine($"{iInput} |= {(int)BitMaskEnum.Bit4} = {iInput |= (int)BitMaskEnum.Bit4}");

                    iInput = 0;
                    Console.WriteLine($"Starting at {iInput}");
                    Console.WriteLine($"{iInput} |= {(int)BitMaskEnum.Bit4} = {iInput |= (int)BitMaskEnum.Bit4}");
                    Console.WriteLine($"{iInput} |= {(int)BitMaskEnum.Bit3} = {iInput |= (int)BitMaskEnum.Bit3}");
                    Console.WriteLine($"{iInput} |= {(int)BitMaskEnum.Bit2} = {iInput |= (int)BitMaskEnum.Bit2}");
                    Console.WriteLine($"{iInput} |= {(int)BitMaskEnum.Bit1} = {iInput |= (int)BitMaskEnum.Bit1}");
                }
                else if (input?.ToLower() == "exit")
                {
                    return;
                }
            } while (true);

            return;
        }
    }
}