using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Week = new List<Day>();           
            var Monday = new Day();

            Monday.Index = 0;
            Monday.NameDay = "Понедельник";
            Monday.Lessons = new List<Lesson>();
            Monday.Lessons.Add(new Lesson("Менеджмент", "09:40"));
            Monday.Lessons.Add(new Lesson("Дискретка", "11:40"));
            Monday.Lessons.Add(new Lesson("Комп сети", "13:20"));

            var Tuesday = new Day();
            Tuesday.Index = 1;
            Tuesday.NameDay = "Вторник";
            Tuesday.Lessons = new List<Lesson>();
            Tuesday.Lessons.Add(new Lesson("МатАнализ", "08:00"));
            Tuesday.Lessons.Add(new Lesson("Физра", "09:40"));

            var Wednasday = new Day();
            Wednasday.Index = 2;
            Wednasday.NameDay = "Среда";
            Wednasday.Lessons = new List<Lesson>();
            Wednasday.Lessons.Add(new Lesson("ИСТ", "08:00"));
            Wednasday.Lessons.Add(new Lesson("Дискретка", "09:40"));

            var Thursday = new Day();
            Thursday.Index = 3;
            Thursday.NameDay = "Четверг";
            Thursday.Lessons = new List<Lesson>();
            Thursday.Lessons.Add(new Lesson("ПпП", "08:00"));
            Thursday.Lessons.Add(new Lesson("Физра", "09:40"));
            Thursday.Lessons.Add(new Lesson("Менеджмент", "11:40"));

            var Friday = new Day();
            Friday.Index = 4;
            Friday.NameDay = "Пятница";
            Friday.Lessons = new List<Lesson>();
            Friday.Lessons.Add(new Lesson("ИСТ", "09:40"));
            Friday.Lessons.Add(new Lesson("Комп сети", "11:40"));
            Friday.Lessons.Add(new Lesson("АВС", "13:20"));
            Friday.Lessons.Add(new Lesson("ПпП", "15:10"));

            var Saturday = new Day();
            Saturday.Index = 5;
            Saturday.NameDay = "Суббота";
            Saturday.Lessons = new List<Lesson>();
            Saturday.Lessons.Add(new Lesson("МатАнализ", "08:00"));
            Saturday.Lessons.Add(new Lesson("МатАнализ", "09:40"));
            Saturday.Lessons.Add(new Lesson("АВС", "11:40"));

            Week.Add(Monday);
            Week.Add(Tuesday);
            Week.Add(Wednasday);
            Week.Add(Thursday);
            Week.Add(Friday);
            Week.Add(Saturday);

            Dekanat data = new Dekanat();
            data[0] = new Teacher("Трусов Леха");
            data[1] = new Teacher("Воронецкая Марина");
            data[2] = new Teacher("Дюгуров Денис");
            data[3] = new Teacher("Васильева Яна");
            data[4] = new Teacher("Клочков Миша");
            ViewBag.Week = Week;
            ViewBag.Dek = data;
            return View();
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