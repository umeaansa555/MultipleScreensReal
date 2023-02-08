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
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();

            playsLabel.Text = $"Times played: {Form1.numberPlays}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);

            ms.Focus();

            // Centre the screen on the form
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

            /// add focus/enter event after
        }

        private void returnButton_Enter(object sender, EventArgs e)
        {
            returnButton.BackColor = SystemColors.ActiveBorder;
            exitButton.BackColor = SystemColors.InactiveBorder;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackColor = SystemColors.ActiveBorder;
            returnButton.BackColor = SystemColors.InactiveBorder;
        }
    }
}
