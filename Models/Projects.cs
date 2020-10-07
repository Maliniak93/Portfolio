﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string GithubURL { get; set; }
    }
}
