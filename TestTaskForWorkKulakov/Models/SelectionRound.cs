using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestTaskForWorkKulakov.Models
{
    public class SelectionRound : MethodsForGame
    {
        //True - автомобиль, False - овца
        [DisplayName("Дверь №1")]
        public bool Door1 { get; set; }
        [DisplayName("Дверь №2")]
        public bool Door2 { get; set; }
        [DisplayName("Дверь №3")]
        public bool Door3 { get; set; }

        public string MessageAboutSuccess { get; set; }

        public SelectionRound(bool[] doors)
        {
            Door1 = doors[0];
            Door2 = doors[1];
            Door3 = doors[2];
        }

    }
}