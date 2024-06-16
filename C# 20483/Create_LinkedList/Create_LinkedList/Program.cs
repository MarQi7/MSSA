using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_LinkedList
{
    internal class Program
    {
        static int currentNum = 0;
        static int house = 0;
        static string address = "";
        static int[] nums = { 0, 1, 0, 3, 12 };
        static int[] nums2 = { 2, 0, 1, 4, 0, 0, 3, 12, 0 };
        static void Main(string[] args)
        {
            LinkedHouses myHouses = new LinkedHouses();
            
            Console.WriteLine("Assignment 6.1: Linked List Practice\n\n");
            Console.Write("Please enter the number of houses you wish to create! (up to 5) ");
            currentNum = NumHouses();
            while(currentNum > 0)
            {
                Console.Write("\nPlease enter the house #: ");
                house = ParsedNum();
                Console.WriteLine("Please enter an address for the house: ");
                address = Console.ReadLine();
                myHouses.AddHouse(house,address);
                currentNum--;
            }
            string answer = "y";
            while (answer == "y")
            {
                Console.Write("\nWould you like to search for a house? [Y]/[N] ");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Console.Write("\nEnter a house number to searach: ");
                    house = ParsedNum();
                    myHouses.Search(house);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            myHouses.Display(); 
            Console.WriteLine();
            
            Console.WriteLine("Part 3: Shifting zeros (& increment arrangement)");
            Console.WriteLine("\nInput: [0, 1, 0, 3, 12]");
            Console.WriteLine(ZeroShift.ShiftRight(nums));
            Console.WriteLine(ZeroShift.ShiftLinear(nums));
            Console.WriteLine(ZeroShift.ShiftByCountZero(nums));
            Console.WriteLine();
            Console.WriteLine("\nInput: [2, 0, 1, 4, 0, 0, 3, 12, 0]");
            Console.WriteLine(ZeroShift.ShiftRight(nums2));
            Console.WriteLine(ZeroShift.ShiftLinear(nums2));
            Console.WriteLine(ZeroShift.ShiftByCountZero(nums2)); 
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();






        }
        public static int NumHouses()
        {
            int output = 0;
            retry:
            if (!int.TryParse(Console.ReadLine(), out output)||output>5)
            {
                Console.WriteLine("Please enter a number up to 5.");
                goto retry;
            }
            return output;
        }
        public static int ParsedNum()
        {
            int output = 0;
        retry:
            if (!int.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("Please enter a number.");
                goto retry;
            }
            return output;
        }

        public static void Houses(LinkedHouses next, int val, string address)
        {
            next.AddHouse(val, address);

        }
    }
}
