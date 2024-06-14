using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Interpolationdemo
{
    internal class Program
    {


        static int Search(float[] list,float data)
        {
            int lo=0;
            float mid = -1;
            int hi=list.Length-1;
            float index = -1;

            while (lo < hi)
            {

                mid=lo + (((hi - lo) / (list[hi] - list[lo])) * (data-list[lo]));

                int mid1=(int)mid;
                if (mid1 <= list.Length - 1)
                {
                    if (list[mid1] == data)
                    {
                        index = mid;
                        break;
                    }
                    else
                    {

                        if (list[mid1] < data)
                            lo = mid1 + 1;
                        else
                            hi = mid1 - 1;
                    }

                }
                else
                {
                    return -1;
                }

            }

            return (int)index;
        }
        static void Main(string[] args)
        {
            //float[] list = new float[] { 12, 20, 35, 42, 55 };
            int[] list2 = new int[] { 131, 20, 215, 2, 50 };
            //Console.WriteLine(Search(list, 35));
            BubbleSort.Bubbled(list2);
            Console.ReadKey();
        }
    }
}
