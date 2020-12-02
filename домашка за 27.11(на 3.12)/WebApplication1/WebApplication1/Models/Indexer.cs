using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    class Teacher
    {
        public string Name { get; set; }
        public Teacher(string Name)
        {
            this.Name = Name;
        }
    }
    class Dekanat
    {
        Teacher[] data;
        public Dekanat()
        {
            data = new Teacher[5];
            /*data[0] = new Teacher() { Name = "Трусов Леха" };
            data[1] = new Teacher() { Name = "Воронецкая Марина" };
            data[2] = new Teacher() { Name = "Дюгуров Денис" };
            data[3] = new Teacher() { Name = "Васильева Яна" };
            data[4] = new Teacher() { Name = "Клочков Миша" };*/
        }
        //индексатор
        public Teacher this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}