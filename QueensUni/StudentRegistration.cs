using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QueensUni_Domain.Dommain;
using QueensUni_Domain;

namespace QueensUni
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        //Cancel the records in Student Registration Form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Globalvariables.status = false;
            this.Dispose();
        }

        //Enter records to the data grid in Student Details Form
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Validate fields in Student Registration Form by calling validateFields() method
            if (validateFields() == true)
            {
                Globalvariables.StudentId = txtStId.Text;
                Globalvariables.StudentName = txtStName.Text;
                Globalvariables.DOB = dtDob.Value.Date;
                Globalvariables.gpa = txtGpa.Text;
                if (chkActive.Checked)
                {
                    Globalvariables.Check = 1;//Student is enrolled
                }
                else if (!chkActive.Checked)
                {
                    Globalvariables.Check = 0;//Student is not enrolled
                }

                Globalvariables.status = true;

                this.Dispose();
            }
        }

        //Validate GPA field
        private void txtGpa_Leave(object sender, EventArgs e)
        {
            decimal a=0 ;
            bool isNumeric = decimal.TryParse(txtGpa.Text, out a);


            if (!isNumeric)
            {
                    MessageBox.Show("Please enter valid number", "Error");
                    txtGpa.Text = "";
                    txtGpa.Focus();
            }
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            //Generate auto generated number
            string Prifx = "ST";
            string formated = string.Format("{0,-7:00000000}", Globalvariables.num);
            this.txtStId.Text = (Prifx + formated).ToString();
            Globalvariables.num++;
            this.txtStId.Enabled = false;
        }

        //Method for validate fields in Student Registration Form
        public bool validateFields()
        {
            if (txtStId.Text.Trim() == "")
            {
                MessageBox.Show("Student ID cannot be empty!", "Error");
                return false;
            }

            if (txtStName.Text.Trim() == "")
            {
                MessageBox.Show("Student Name cannot be empty!", "Error");
                return false;
            }

            if (txtGpa.Text.Trim() == "")
            {
                MessageBox.Show("Student GPA value cannot be empty!", "Error");
                return false;
            }

            return true;
        }

        //Validate GPA field
        private void txtGpa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue > 58 || e.KeyValue < 49)
            {
                MessageBox.Show("Please Enter Number Only", "Error");
                txtGpa.Text = "";
                txtGpa.Focus();
            }
        }
    }
}
