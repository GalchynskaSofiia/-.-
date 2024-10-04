using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Patient: ITreatable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalHistory { get; set; }

        public Patient(string name, int age, string gender, string medicalHistory)
        {
            Name = name;
            Age = age;
            Gender = gender;
            MedicalHistory = medicalHistory;
        }

        public override string ToString()
        {
            return $"Ім'я: {Name}\nВік: {Age}\nСтать: {Gender}";
        }
        public void OrderMedication(Medication medication)
        {
            MessageBox.Show($"{Name}, ви замовили: {medication.Name}");
        }
    }
}
