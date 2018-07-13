using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestTaskForWorkKulakov.Models
{
    public class Experiment : MethodsForGame
    {
        public short RightChoice { get; set; }

        public short FalseChoice { get; set; }

        const short minRounds = 2;

        const short maxRounds = 1000;

        [Range(minRounds, maxRounds, ErrorMessage = "Введённое значение должно быть в диапазоне от 2 до 1000")]
        [Required(ErrorMessage = "Введите количество прогонов цикла")]
        public short NumberOfRounds { get; set; }

        public bool ChangeYourOpinion { get; set; }

        public double ChanceOfWinning { get; set; }

        public string Error { get; set; }

        public Experiment(short numberOfRounds, bool changeYourOpinion)
        {
            NumberOfRounds = numberOfRounds;
            ChangeYourOpinion = changeYourOpinion;
        }

        public Experiment()
        {

        }

        // Данный метод определяет что угадал игрок
        public void GetExperiment()
        {
            Random rnd = new Random();

            RightChoice = 0;

            FalseChoice = 0;

            for (short i = 0; i < NumberOfRounds; i++)
            {
                bool[] array = GetDoors();

                byte playerSelectedDoor = (byte)rnd.Next(0, 3);

                if (array[playerSelectedDoor] == true && ChangeYourOpinion == false)
                {

                    RightChoice += 1;

                }
                else if (array[playerSelectedDoor] == true && ChangeYourOpinion == true)
                {

                    FalseChoice += 1;

                }
                else if (array[playerSelectedDoor] == false && ChangeYourOpinion == false)
                {

                    FalseChoice += 1;

                }
                else if (array[playerSelectedDoor] == false && ChangeYourOpinion == true)
                {

                    RightChoice += 1;

                }
            }
        }

        public double GetTheWinningPercentage(short winCase, short amountOfCase)
        {
            try
            {
                return winCase / (double)amountOfCase * 100;

            } catch (DivideByZeroException ex){

                Error = "Произошла ошибка, связанная с делением на 0. Прошу увеличить количество прогонов цикла!";
                return 0;
            }

        }
    }
}