using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Lesson
    {
        public string NameLes;
        public string Start;

        public Lesson(string NameLes, string Start)
        {
            this.NameLes = NameLes;
            this.Start = Start;
        }
    }
}