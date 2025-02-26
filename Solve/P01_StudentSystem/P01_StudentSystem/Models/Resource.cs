﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Docment_or_other
    }
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public ResourceType ResourceType { get; set; }
        public string Url { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }



    }
}
