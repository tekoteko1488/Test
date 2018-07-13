using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTaskForWorkKulakov.Models
{
    public class MethodsForGame
    {
        // Генерация случайных значений для дверей
        public static bool[] GetDoors()
        {
            Random rnd = new Random();

            short auto = (short)rnd.Next(0, 3);

            bool[] array = new bool[3];

            for (short i = 0; i < array.Length; i++)
            {
                if (i == auto)
                {
                    array[i] = true;

                }
                else
                {
                    array[i] = false;
                }
            }

            return array;
        }
    }
}