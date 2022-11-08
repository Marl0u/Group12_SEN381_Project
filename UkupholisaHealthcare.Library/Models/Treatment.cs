﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public string? TreatmentName { get; set; }
        public int Days { get; set; }
        public string? Description { get; set; }
    }
}
