using System;
using System.Windows.Forms;
using System.Windows.Controls;

namespace GO_Game
{
    public partial class option : Form
    {
        public System.Windows.Controls.MediaElement MediaElement { get; set; }
        private Form1 form1;
        public TrackBar VolumeTrackBar { get; set; }
        public option()
        {
            InitializeComponent();

            VolumeTrackBar = new TrackBar();
            MediaElement = new System.Windows.Controls.MediaElement();
            trackBar1.Scroll += trackBar1_Scroll_1;
            trackBar2.Scroll += trackBar2_Scroll;
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (MediaElement != null && VolumeTrackBar != null)
            {
                int volumeValue = VolumeTrackBar.Value;
                double volume = (double)volumeValue / VolumeTrackBar.Maximum;

                MediaElement.Volume = volume;
            }
            else
            {
                Console.WriteLine("MediaElement or VolumeTrackBar is not assigned.");
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (MediaElement != null && VolumeTrackBar != null)
            {
                int volumeValue = VolumeTrackBar.Value;
                double volume = (double)volumeValue / VolumeTrackBar.Maximum;

                MediaElement.Volume = volume;

            }
            else
            {
                Console.WriteLine("MediaElement or VolumeTrackBar is not assigned.");
            }
        }
    }
}
