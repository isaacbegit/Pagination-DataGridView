using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid_Pagination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Col1");
            dt.Columns.Add("Col2");
            dt.Columns.Add("Col3");
            dt.Columns.Add("Col4");
            dt.Columns.Add("Col5");
            dt.Columns.Add("Col6");
            dt.Columns.Add("Col7");
            string[] Lines = File.ReadAllLines("ApplicationDocs.txt");
            foreach (string line in Lines )
            {
                string[] split = line.Split('\t');
                dt.Rows.Add(
                    split[0].ToString(),
                     split[1].ToString(),
                      split[2].ToString(),
                       split[3].ToString(),
                        split[4].ToString(),
                         split[5].ToString(),
                          split[6].ToString()
                    );
            }

            superGrid1 .SetPagedDataSource(dt, bindingNavigator1);
            // set paging size 
            superGrid1 .PageSize = 100;
        }
    }
}
