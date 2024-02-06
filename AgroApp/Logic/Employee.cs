﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroApp.Logic
{
    public class Employee
    {
        private int id;
        private string name;
        

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }        

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;            
        }
    }
}
