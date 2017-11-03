using BMIcalculater.Models;
using System.Web.Mvc;

namespace BMIcalculater.Controllers
{
    public class HomeController : Controller
    {
        BMIContext _context;

        public HomeController()
        {
            _context = new BMIContext();
        }

    
        //public ActionResult Index()
        //{

        //    BMIForm bmi = new BMIForm { BMI = "0" };
        //    return View(bmi);
        //}

        //[HttpPost]
        public ActionResult Index(BMIForm FromView)
        {
            if (FromView.BMI == null)
            {
                //BMIForm bmi = new BMIForm { BMI = "0" };
                FromView.BMI = "0";
                return View(FromView);
            }

            //BMIForm bmi = new BMIForm
            //{
            //    Name = FromView.Name,
            //    FeetHeight = FromView.FeetHeight,
            //    InchHeight = FromView.InchHeight,
            //    Gender = FromView.Gender,
            //    Weight = FromView.Weight,
            //    BMI = ((FromView.Weight) / (((FromView.FeetHeight * 12) + FromView.InchHeight) * 0.254)).ToString()

            //};

            FromView.BMI = ((FromView.Weight) / 
                           (((FromView.FeetHeight * 12) + FromView.InchHeight) * 
                           0.254))
                           .ToString();

            return View(FromView);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}