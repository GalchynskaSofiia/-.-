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
    public partial class Form1 : Form
    {
        private Patient patient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Створення екземпляра класу Пацієнт
            patient = new Patient("Олег", 30, "Чоловік", "Аллергія на пилок");

            // Відображення інформації у Label
            labelInfo.Text = patient.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppointmentHistoryForm historyForm = new AppointmentHistoryForm();
            historyForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicationHistoryForm history2Form = new MedicationHistoryForm(patient);
            history2Form.ShowDialog();
        }
    }
}
