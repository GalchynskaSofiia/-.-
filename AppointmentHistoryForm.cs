using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AppointmentHistoryForm : Form
    {
        public AppointmentHistoryForm()
        {
            InitializeComponent();
        }

        private void AppointmentHistoryForm_Load(object sender, EventArgs e)
        {
            var medications1 = new List<Medication>
            {
                new Medication("Цетрин", "500 мг", "Кожні 6 годин")
            };
            var medications2 = new List<Medication>
            {
                new Medication("Грипекс Хот Актив Макс", "1 саше", "Кожні 8 годин")
            };
            Appointment appointment1 = new Appointment(DateTime.Now.AddDays(-7), "10:00", "Лікар-алерголог", "Алергія", medications1);
            Appointment appointment2 = new Appointment(DateTime.Now.AddDays(-14), "14:30", "Терапевт", "Грип", medications2);
            listBox1.Items.Add(appointment1);
            listBox1.Items.Add(appointment2);
        }
    }
}
