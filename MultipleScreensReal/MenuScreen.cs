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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Focus();

            //Centre the screen on the Form
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

            Form1.numberPlays++;
        }

        private void MenuScreen_Enter(object sender, EventArgs e)
        {

        }
    }
}
