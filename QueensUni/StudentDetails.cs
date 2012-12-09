using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QueensUni_DAL;
using QueensUni_Domain;

namespace QueensUni
{
    public partial class StudentDetails : Form
    {
        DataTable dt = new DataTable();

        public StudentDetails()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        DataTable table = new DataTable();

        private void btnSave_Click(object sender, EventArgs e)
        {
            DalStDetails dsd = new DalStDetails();

            //Validate the Grid data
            if (grdStDetails.Rows.Count != 0)
            {
                for (int i = 0; i < grdStDetails.Rows.Count; i++)
                {
                    table.Rows.Add(grdStDetails[0, i].Value.ToString(), grdStDetails[1, i].Value.ToString(), grdStDetails[2, i].Value.ToString(), grdStDetails[3, i].Value, grdStDetails[4, i].Value);
                }

                dsd.saveStDetails(table);//Call the saveStDetails() method in Data Access Layer
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No Student Records to update???", "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentRegistration str = new StudentRegistration();
            str.ShowDialog();//Load the Student Registration Form

            //Check weather the Student Registration Form records have been properly entered 
            if (Globalvariables.status == true)
            {
                grdStDetails.Rows.Add(Globalvariables.StudentId, Globalvariables.StudentName, Globalvariables.DOB, Globalvariables.gpa, Globalvariables.Check);
            }
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            DalStDetails dsd1 = new DalStDetails();
            dsd1.numGet();//Calls the numGet() method in Data Access Layer to get the next auto generated number

            table.Columns.Add("StId", typeof(string));
            table.Columns.Add("StName", typeof(string));
            table.Columns.Add("Dob", typeof(DateTime));
            table.Columns.Add("Gpa", typeof(decimal));
            table.Columns.Add("Active", typeof(int));  
        }
    }
}
