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
    public partial class login : Form
    {
        private ChangeColor colors = new ChangeColor();


        public login()
        {
            InitializeComponent();
            textBoxUserName.ForeColor = Color.LightGray;
            textBoxUserName.Text = "Πληκτρολογήστε το όνομα σας";
            textBoxCode.ForeColor = Color.LightGray;
            textBoxCode.Text = "Πληκτρολογήστε τον κωδικό σας";
        }

        // Ο χρήστης για να συνδεθεί πληκτρολογεί ένα τυχαίο username 
        // και ένα τυχαίο κωδικό μήκους 8 χαρακτήρων
        private void buttonConnection_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "Πληκτρολογήστε τον κωδικό σας" || textBoxCode.Text == "Πληκτρολογήστε τον κωδικό σας")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε και τα δύο πεδία!"); 
            }
            else if (textBoxUserName.Text.Length == 0)
            { 
                MessageBox.Show("Λάθος όνομα!"); 
            }
            else if (textBoxCode.Text.Length < 8)
            {
                MessageBox.Show("Λάθος κωδικός!");
            }
            else
            {
                try
                {
                    choice myform = new choice(this);
                    this.Hide();
                    myform.Location = this.Location;
                    myform.ShowDialog();
                    this.Show();
                }
                catch (ObjectDisposedException exception)
                {

                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelWelcome.ForeColor = colors.returnColor();
            colors.changeColor();
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Length == 0)
            {
                textBoxUserName.Text = "Πληκτρολογήστε το όνομα σας";
                textBoxUserName.ForeColor = Color.LightGray;
            }
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "Πληκτρολογήστε το όνομα σας")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
            }
        }
        private void textBoxCode_Leave(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Length == 0)
            {
                textBoxCode.Text = "Πληκτρολογήστε τον κωδικό σας";
                textBoxCode.ForeColor = Color.LightGray;
            }
        }

        private void textBoxCode_Enter(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "Πληκτρολογήστε τον κωδικό σας")
            {
                textBoxCode.Text = "";
                textBoxCode.ForeColor = Color.Black;
            }
        }



    }
}
