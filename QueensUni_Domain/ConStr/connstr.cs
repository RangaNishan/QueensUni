using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

//Connection String
namespace QueensUni_Domain.ConStr
{
    public class connstr
    {
        public static string Queen_Constr_Path = ConfigurationManager.ConnectionStrings["Queen_Constr"].ConnectionString;
    }
}
