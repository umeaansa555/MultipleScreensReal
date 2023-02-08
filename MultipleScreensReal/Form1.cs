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
    public partial class Form1 : Form
    {
        public static int numberPlays = 0;

        public Form1()
        {
            InitializeComponent();

            MenuScreen ms = new MenuScreen();

            this.Controls.Add(ms);

            // Centre the screen on the Form  
            ms.Location = new Point((this.ClientSize.Width - ms.Width) / 2,
            (this.ClientSize.Height - ms.Height) / 2);


        }
    }
}
