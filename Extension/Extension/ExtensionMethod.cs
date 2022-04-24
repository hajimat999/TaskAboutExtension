using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Extension.Extension
{
    static class ExtensionMethod
    {
        public static bool IsEven(this int a)
        {
            return a % 2 == 0;

        }

        public static int[] GetValueIndexes(this int a)
        {
            int[] array = { 1, 5, 6, 8, 9, 6, 8, 9, 5, 45, 90 };
            int[] arr = new int[0];
            int b = 0;
            
            

           if(array.Contains(a))
           {
                for (int i = 0; i < array.Length; i++)
                {
                    b = Array.IndexOf(array, a, b);

                    if (b != -1)
                    {


                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = b;
                        b++;


                    }
                    else
                    {
                        break;
                    }

                }
                return arr;

           }

           return arr;

            
        }

        public static bool IsOdd(this int a)
        {
            return a % 2 != 0;
        }

        public static  bool IsContainsDigit(this string a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                if(char.IsDigit(a[i]))
                {
                    return true;
                    
                }
                

            }
            return false;
        }

        public static int [] GetValuesIndexes(this string a, char b)
        {
            int[] array = new int[0];
            int c = 0;

            if(a.Contains(b))
            {
                for (int i = 0; i < a.Length; i++)
                {
                    c = a.IndexOf(b, c);
                    if(c != -1)
                    {
                        Array.Resize(ref array, array.Length + 1);
                        array[array.Length - 1] = c;
                        c++;
                    }
                    else
                    {
                        break;
                    }


                }
                return array;



            }
            return array;
            

        }
    }
}
