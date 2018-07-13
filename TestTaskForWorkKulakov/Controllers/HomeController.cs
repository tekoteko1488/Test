using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTaskForWorkKulakov.Models;

namespace TestTaskForWorkKulakov.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SelectionRound round = new SelectionRound(MethodsForGame.GetDoors());

            return View(round);
        }

        public ActionResult GetSheep()
        {
            return PartialView("ViewSheep");
        }

        public ActionResult GetAuto()
        {
            return PartialView("ViewAuto");
        }

        public ActionResult Testing()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Testing(Experiment experiment)
        {
            experiment = new Experiment(experiment.NumberOfRounds, experiment.ChangeYourOpinion);

            experiment.GetExperiment();

            experiment.ChanceOfWinning = experiment.GetTheWinningPercentage(experiment.RightChoice, experiment.NumberOfRounds);

            return View(experiment);
        }

    }
}