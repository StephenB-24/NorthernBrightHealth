using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthernBrightHealth.Shared.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public float WeightInPounds { get; set; }
        public float HeightInInches { get; set; }
        public bool Immortal { get; set; }

    }
}
