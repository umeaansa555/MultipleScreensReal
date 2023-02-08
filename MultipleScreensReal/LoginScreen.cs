using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreensReal
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text == Form1.username /*&& passwordBox.Text == Form1.password*/)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                MenuScreen ms = new MenuScreen();
                f.Controls.Add(ms);

                ms.Focus();

                // Centre the screen on the form
                ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            }
            else { errorLabel.Text = $"Incorrect username or password. Try again"; }
        }
    }
}
