using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueensUni_Domain.Dommain
{
    public class DomStReg
    {
        private string stid;

        public string Stid
        {
            get { return stid; }
            set { stid = value; }
        }

        private string stname;

        public string Stname
        {
            get { return stname; }
            set { stname = value; }
        }

        private DateTime dob;

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        private decimal gpa;

        public decimal Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

        private int active;

        public int Active
        {
            get { return active; }
            set { active = value; }
        }
    }
}
