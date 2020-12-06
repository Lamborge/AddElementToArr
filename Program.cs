using System;

namespace AddElementToArr
{
    class Program
    {

        public int[] arr = { 0,1,2,3,4,5,6,7,8,9};

        public static void AddElToArr(int enter_array[], int element)
        {

            int i = 0;
            string temp = String.Join(".", enter_array[]);
            char[] temp_char = temp.ToCharArray();
            foreach (var item in temp_char)
            {
                if (item == '.')
                {
                    i++;
                }
            }

            int[] res_arr = new int[i + 1];
            res_arr[i + 1] = element;

            return res_arr[];
        }

        static void Main(string[] args)
        {
            //Todo
        }
    }
}
