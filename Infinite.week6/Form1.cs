using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Infinite.week6
{
    public partial class Form1 : Form
    {
        private SqlConnection Conobj=null;
        private SqlDataAdapter adaobj =null;
        private DataSet ds=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Conobj = new SqlConnection(ConfigurationManager.ConnectionStrings["mastercon"].ConnectionString)) 
            {
                using (adaobj = new SqlDataAdapter("Select * from Employee", Conobj))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adaobj);
                    ds = new DataSet();
                    adaobj.Fill(ds, "Employee");

                    DataRow dr = ds.Tables["Employee"].NewRow();
                    dr["EmployeeNo"] = TxtEmployeeNo.Text;
                    dr["EmployeeName"] = TxtEmployeeName.Text;
                    dr["EmployeeSalary"] = TxtEmployeeSalary.Text;
                    dr["EmployeeType"]= grpEmployeeType.Text;
                    if(radiopayroll.Checked)
                    {
                        dr["EmployeeType"] = 'p';
                    }
                    else
                    {
                        dr["EmployeeType"] = 'c';
                    }
                    ds.Tables["Products"].Rows.Add(dr);
                    if(EmployeeSalary>=25000)
                    {

                    }

                    int res = adaobj.Update(ds, "Products");
                    if (res > 0)
                    {
                        LblMessage.Text = " Employee Added ";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtEmployeeNo.Text = " ";
            TxtEmployeeName.Text = "";
            TxtEmployeeSalary.Text = " ";
            radiopayroll.Checked = false;
            radioconsultant.Checked = false;


        }
    }
}
