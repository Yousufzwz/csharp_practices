﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples_I;

public class Course
{
    public string Name { get; set; }
    public double Price { get; set; }
    public List<Topic> Topics{ get; set; }

    public Course(string name, double price, List<Topic> topic)
    {
        Name = name;
        Price = price;
        Topics =topic;
    }
}
