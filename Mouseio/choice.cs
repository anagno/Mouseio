using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouseio
{
    public partial class choice : Form
    {
        // Music Player variable. Για να μην έχουμε απόλυτα μονοπάτια θα πρέπει να προστίθενται
        // οι τυχόν επιλογές στο Resources.resx
        private System.Media.SoundPlayer music_player = new System.Media.SoundPlayer(Mouseio.Properties.Resources.song);

        private login parent_form_; //For controlling the parent form

        public choice(login parent_form)
        {
            InitializeComponent();
            parent_form_ = parent_form;
            music_player.Play();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                parent_form_.Location = this.Location;
            }
            catch (InvalidCastException exception)
            {

            }
            this.Close();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            music_player.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            music_player.Stop();
        }

        private void choice_FormClosed(object sender, FormClosedEventArgs e)
        {
            music_player.Stop();
        }

        private void buttonGreekBeaches_Click(object sender, EventArgs e)
        {
            greek_beaches myform = new greek_beaches(this);
            this.Hide();
            myform.Location = this.Location;
            myform.ShowDialog();
            this.Show();
        }

        private void buttonForeignBeaches_Click(object sender, EventArgs e)
        {
            foreign_beaches myform = new foreign_beaches(this);
            this.Hide();
            myform.Location = this.Location;
            myform.ShowDialog();
            this.Show();
        }

    }
}
