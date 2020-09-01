﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndFiles
{
    class Student
    {
        public string name { get; set; }
        public int id { get; set; }
        public DateTime enrollDate { get; set; }
        public static int totalStudents { get; set; }

        public Student(string name, int id) : this()
        {
            this.name = name;
            this.id = id;
            //enrollDate = DateTime.Now;
            totalStudents++;
        }

        public Student()
        {
            name = String.Empty;
            id = -1;
            enrollDate = DateTime.Now;
            totalStudents++;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name} has an id of {id}";
        }


    }
}
