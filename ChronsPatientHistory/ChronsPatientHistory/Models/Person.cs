using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChronsPatientHistory.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public bool PastDiagnosis { get; set; }

    }
}