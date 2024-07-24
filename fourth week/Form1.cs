using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fourth_week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Get selected values from the ComboBoxes
         
           
            int dayOfMonthIndex = cmbDayOfMount.SelectedIndex + 1;
            string selectedDayOfWeek = Management.GetDayOfWeek(cmbDayOfWeek.SelectedIndex +1);
            string selectedDayOfMonth = Management.GetDayOfMonth(dayOfMonthIndex);
            string selectedMonth = Management.GetMonthName(cmbMounth.SelectedIndex + 1);
            string selectedYear = Management.GetYearInWords(cmbYear.SelectedIndex + 1);

            // Construct the result string
            string resulte;
            if (dayOfMonthIndex == 30)
            {
                string nextMonth = Management.GetNextMonth(cmbMounth.SelectedIndex + 1);
                resulte = $"{selectedDayOfWeek} {selectedDayOfMonth} לחודש {selectedMonth} שהוא ראש חודש {nextMonth} שנת {selectedYear} לבריאת העולם";
            }
            else
            {
                resulte = $"{selectedDayOfWeek} {selectedDayOfMonth} לחודש {selectedMonth} שנת {selectedYear} לבריאת העולם";
            }
            // Show the result in a message box
            MessageBox.Show(resulte);

            // Save the query to XML
            Management.SaveQueryToXml( selectedDayOfWeek, selectedDayOfMonth, selectedMonth, selectedYear, resulte);
        }
    }
}