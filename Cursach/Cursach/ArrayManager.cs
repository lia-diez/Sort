using System;
using System.Collections.Generic;

namespace Cursach
{

    public static class ArrayManager
    {
        public static float[] ConvertArrayToFloat(string[] array)
        {
            List<float> result = new List<float>();
            for (int i = 0; i < array.Length; i++)
            {
                float elem;
                if (float.TryParse(array[i], out elem))
                {
                    result.Add(elem);
                }
                else
                {
                    Console.WriteLine($"У елемента {array[i]} неправильний тип. Вiн не міститиметься в масивi");
                }
            }

            return result.ToArray();
        }
        
        public static int[] ConvertArrayToInt(string[] array)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int elem;
                if (int.TryParse(array[i], out elem))
                {
                    result.Add(elem);
                }
                else
                {
                    Console.WriteLine($"У елемента {array[i]} неправильний тип. Вiн не міститиметься в масивi");
                }
            }

            return result.ToArray();
        }
    }
}