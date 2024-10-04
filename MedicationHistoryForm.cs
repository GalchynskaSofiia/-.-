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
    public partial class MedicationHistoryForm : Form
    {
        private Patient patient;
        public MedicationHistoryForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void MedicationHistoryForm_Load(object sender, EventArgs e)
        {
            Medication medication1 = new Medication("Цетрин", "500 мг", "Кожні 6 годин");
            Medication medication2 = new Medication("Грипекс Хот Актив Макс", "1 саше", "Кожні 8 годин");
            checkedListBox1.Items.Add(medication1);
            checkedListBox1.Items.Add(medication2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                foreach (Medication selectedMedication in checkedListBox1.CheckedItems)
                {
                    // Викликаємо метод для замовлення ліків
                    patient.OrderMedication(selectedMedication);
                }

                // Показуємо повідомлення
                MessageBox.Show("Ваші ліки успішно замовлені, очікуйте смс-повідомлення.");
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть хоча б одні ліки для замовлення.");
            }
        }
    }
}
