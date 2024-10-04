using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Medication
    {
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }

        public Medication(string name, string dosage, string frequency)
        {
            Name = name;
            Dosage = dosage;
            Frequency = frequency;
        }

        public override string ToString()
        {
            return $"{Name} - {Dosage} (Частота: {Frequency})";
        }
    }
}
