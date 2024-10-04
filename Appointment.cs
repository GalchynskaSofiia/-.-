using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Appointment
    {
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Doctor { get; set; }
        public string Diagnosis { get; set; }
        public List<Medication> Prescription { get; set; }

        public Appointment(DateTime date, string time, string doctor, string diagnosis, List<Medication> prescription)
        {
            Date = date;
            Time = time;
            Doctor = doctor;
            Diagnosis = diagnosis;
            Prescription = prescription;
        }

        public override string ToString()
        {
            string medications = string.Join(", ", Prescription.Select(m => m.ToString()));
            return $"{Date.ToShortDateString()} о {Time}: {Doctor} - {Diagnosis} (Призначення: {medications})";
        }
    }
}
