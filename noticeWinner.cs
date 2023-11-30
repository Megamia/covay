using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO_Game
{
    public partial class noticeWinner : Form
    {
        private Label result;
        private Form2 form2;
        public noticeWinner()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.pictureBox7_Click(sender, e);
            this.Close();
        }

        public void SetForm1Reference(Label win, Form2 f2)
        {
            result = new Label();
            form2 = new Form2();
            result = win;
            form2 = f2;
            PlayerWinner.Text = result.Text;
        }
    }
}
