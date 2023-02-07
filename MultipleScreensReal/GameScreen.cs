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

            // Centre the screen on the Form  
            ms.Location = new Point((this.ClientSize.Width - ms.Width) / 2,
                (this.ClientSize.Height - ms.Height) / 2);

            /// add focus/enter event after
        }
    }
}
