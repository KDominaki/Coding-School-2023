﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Guid ID { get; set; }

        public Person()
        {

        }
        public Person(string name, int age, Guid id)
        {
            Name = name;
            Age = age;
            ID = id;    
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int age)
        {
            Name= name;
            Age = age;
        }

        public void GetName() { }
        public void SetName(string name) { }
    }
}
