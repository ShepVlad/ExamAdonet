using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer.Data;


namespace CreateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable jobTitle = new DataTable();
            jobTitle.Columns.Add("JobTitleId", typeof(int));
            jobTitle.Columns.Add("JobTitleName", typeof(string));
            DataRow dr = jobTitle.NewRow();
            dr[0] = 0;
            dr[2] = "Xnjnj";
            jobTitle.Rows.Add(dr);

            JobTitle jt = new JobTitle();

            
            





        }
    }
}
