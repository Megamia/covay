using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GO_Game
{
    public partial class Ranking : Form
    {
        private Form1 form1;
        public Ranking()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form1.ShowForm1();
            this.Close();
        }
        public void SetForm1Reference(Form1 f1)
        {
            form1 = f1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name FROM [User] WHERE Star = (SELECT MAX(Star) FROM [User])";
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                string name = ds.Tables[0].Rows[0]["Name"].ToString();
                lbName1.Text = name;
            }
        }

        private void lbStar1_Click(object sender, EventArgs e)
        {
            string query = "SELECT star FROM [User] WHERE Star = (SELECT MAX(Star) FROM [User])";

            Ketnoi kn = new Ketnoi();
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                string star = ds.Tables[0].Rows[0]["star"].ToString();
                lbStar1.Text = star;
            }
        }

        private void lbName2_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name FROM [User] WHERE Star = (SELECT MAX(Star) FROM [User] WHERE Star < (SELECT MAX(Star) FROM [User]))";
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                string name = ds.Tables[0].Rows[0]["Name"].ToString();
                lbName2.Text = name;
            }
        }

        private void lbStar2_Click(object sender, EventArgs e)
        {
            string query = "SELECT star FROM [User] WHERE Star = (SELECT MAX(Star) FROM [User] WHERE Star < (SELECT MAX(Star) FROM [User]))";
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                string star = ds.Tables[0].Rows[0]["star"].ToString();
                lbStar2.Text = star;
            }
        }

        private void lbName3_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name FROM [User] WHERE Star = (SELECT MAX(Star) FROM [User] WHERE Star < (SELECT MAX(Star) FROM [User] WHERE Star < (SELECT MAX(Star) FROM [User])))";
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                string name = ds.Tables[0].Rows[0]["Name"].ToString();
                lbName3.Text = name;
            }
        }

        private void lbStar3_Click(object sender, EventArgs e)
        {
            string query = "SELECT star FROM [User] WHERE Star = (SELECT MAX(Star) FROM [User] WHERE Star < (SELECT MAX(Star) FROM [User] WHERE Star < (SELECT MAX(Star) FROM [User])))";
            Ketnoi kn = new Ketnoi();
            DataSet ds = kn.LayDuLieu(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                string star = ds.Tables[0].Rows[0]["star"].ToString();
                lbStar3.Text = star;
            }
        }
    }
}
