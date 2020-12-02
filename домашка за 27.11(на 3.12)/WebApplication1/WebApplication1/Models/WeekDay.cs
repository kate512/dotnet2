using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Day
    {
        public string NameDay { get; set; }
        public List<Lesson> Lessons { get; set; }
        
        public int Index { get; set; }

    }
}