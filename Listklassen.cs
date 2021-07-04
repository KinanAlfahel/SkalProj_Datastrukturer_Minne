using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public class Listklassen<T>
    {

        int[] array;

        List<T> myList;

        public Listklassen()
        {
            myList = new List<T>();
            array = new int[]
            {
                1,2,3,5,21,552,224
            };
        }

        //public void CapacityMetoden()
        //{

        //    int x = array1.Length;

        //    Console.WriteLine(x);

        //}

        public string ExamineList()
        {
            return myList.Capacity.ToString();
        }
    }
}
