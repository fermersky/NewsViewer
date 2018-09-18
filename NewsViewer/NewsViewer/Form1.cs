using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace NewsViewer
{
    public partial class Form1 : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        private DataSet set;
        private SqlDataAdapter ad;
        private SqlConnection conn;

        public int currentPage { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection(cs);
            ad = new SqlDataAdapter("select * from News", conn);
            set = new DataSet();
            ad.Fill(set);

            var table = set.Tables[0].AsEnumerable().Skip(0).Take(2);
            var fulltable = set.Tables[0].AsEnumerable().ToList();


            title1.Text = table.ToList()[0][2].ToString();
            content1.Text = table.ToList()[0][3].ToString();

            if (table.Count() > 1)
            {
                title2.Text = table.ToList()[1][2].ToString();
                content2.Text = table.ToList()[1][3].ToString();
            }
            else
            {
                title2.Text = " ";
                content2.Text = " ";
            }


            int countOfArticles = fulltable.Count;
            int left = 320;

            for (int i = 1; i < (countOfArticles / 2) + 2; i++)
            {
                Button but = new Button();
                but.Text = i.ToString();
                but.MouseClick += But_Click;
                but.Left = left;
                but.Top = 523;
                but.Width = 30;
                this.Controls.Add(but);

                left += 40;
            }
        }

        private void But_Click(object sender, EventArgs e)
        {

            Button but = sender as Button;
            int ind = Convert.ToInt32(but.Text) * 2 - 2;
            currentPage = ind;

            Showarticles(ind, set);
        }

        private void Showarticles(DataSet set)
        {
            var table = set.Tables[0].AsEnumerable().Skip(currentPage).Take(2);


            title1.Text = table.ToList()[0][2].ToString();
            content1.Text = table.ToList()[0][3].ToString();

            if (table.Count() > 1)
            {
                title2.Text = table.ToList()[1][2].ToString();
                content2.Text = table.ToList()[1][3].ToString();
            }
            else
            {
                title2.Text = " ";
                content2.Text = " ";
            }
        }

        private void Showarticles(int index, DataSet set)
        {
            var table = set.Tables[0].AsEnumerable().Skip(index).Take(2);


            title1.Text = table.ToList()[0][2].ToString();
            content1.Text = table.ToList()[0][3].ToString();

            if (table.Count() > 1)
            {
                title2.Text = table.ToList()[1][2].ToString();
                content2.Text = table.ToList()[1][3].ToString();
            }
            else
            {
                 title2.Text = " ";
                 content2.Text = " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void prevBut_Click(object sender, EventArgs e)
        {
            if (currentPage >= 2)
                currentPage-=2;
            Showarticles(set);
        }

        private void newxBut_Click(object sender, EventArgs e)
        {
           
            currentPage+=2;
            Showarticles(set);
        }
    }
}
