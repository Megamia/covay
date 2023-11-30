using System;
using System.Media;
using System.Windows.Forms;

namespace GO_Game
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        private Form2 form2;
        private Ranking formrank;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_ClosingHandler;
            formrank = new Ranking();

            try
            {
                soundPlayer = new SoundPlayer(Properties.Resources.nhac);
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (soundPlayer != null)
            {
                soundPlayer.Stop(); 
                soundPlayer.Dispose(); 
            }
        }

        private void Form1_ClosingHandler(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                soundPlayer.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2 = new Form2();
            form2.Show();
            form2.SetForm1Reference(this);
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            option optionForm = new option();
            optionForm.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // DangNhap DN = new DangNhap();
            // DN.Show();
            //this.Close(); 
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formrank = new Ranking();
            formrank.Show();
            formrank.SetForm1Reference(this);
        }
        public void ShowForm1()
        {
            this.Show();
        }
    }
}
