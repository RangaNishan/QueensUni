using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueensUni_Domain;
using QueensUni_Domain.ConStr;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

//Data Access Layer
namespace QueensUni_DAL
{
    public class DalStDetails
    {
        //This method is called to get the next number for auto number generation
        public void numGet()
        {
           try
            {
                SqlConnection con = new SqlConnection(connstr.Queen_Constr_Path);
                con.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "dbo.GetNumGen";//Strode Procedure Name 
                comm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Globalvariables.num = Int32.Parse(dt.Rows[0][0].ToString());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        //This method is called to update student details to fStudent table
        //And to update number generation field in fNumGen table
        public void saveStDetails(DataTable abc)
        {
            try
            {
                SqlConnection con = new SqlConnection(connstr.Queen_Constr_Path);
                con.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "dbo.InsertfStudent";//Strode Procedure Name 
                comm.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@dt";
                parameter.SqlDbType = System.Data.SqlDbType.Structured;
                parameter.Value = abc;
                comm.Parameters.Add(parameter); 
                comm.ExecuteNonQuery();
                con.Close();

                try 
                {
                    con.Open();
                    SqlCommand comm1 = new SqlCommand();
                    comm1.Connection = con;
                    comm1.CommandText = "dbo.UpdNumGen";//Strode Procedure Name 
                    comm1.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = comm1.Parameters.Add("@newNum", SqlDbType.Int);
                    param.Value = Globalvariables.num;
                    comm1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Student Records were updated Sussessfully", "Message");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
