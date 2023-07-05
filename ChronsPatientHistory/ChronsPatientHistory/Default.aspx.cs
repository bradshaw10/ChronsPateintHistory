using ChronsPatientHistory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChronsPatientHistory
{
    public partial class _Default : Page
    {
        private bool cmSet = true;
        private bool kgSet = true;
        protected void Page_Load(object sender, EventArgs e)
        {
        }



        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Person patient = new Person();
            patient.Id = GetUniqueID();

            if (CheckBox1.Checked)
            {
                patient.Gender = CheckBox1.Text;
            }
            else
            {
                patient.Gender = CheckBox2.Text;
            }

            if (!cmSet)
            {
                patient.Height = convertToCM(HeightBox.Text).ToString();
            }
            else
            {
                patient.Height = HeightBox.Text;
            }

        }

        private int GetUniqueID()
        {
            Random random = new Random();
            return random.Next();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex != 0)
                cmSet = false;

            cmSet = true;
        }

        private double convertToCM(string value)
        {
            double inches = 0;
            double.TryParse(value, out inches);
            return inches * 2.54;

        }
    }
}