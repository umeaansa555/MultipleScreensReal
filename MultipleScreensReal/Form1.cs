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
        public static string username = "Bob";
        public static int password = 4321;

        public Form1()
        {
            InitializeComponent();

            //MenuScreen ms = new MenuScreen();


                //LoginScreen ls = new LoginScreen();

                //this.Controls.Add(ls);

            // Centre the screen on the Form  
            //ms.Location = new Point((this.ClientSize.Width - ms.Width) / 2,
            //(this.ClientSize.Height - ms.Height) / 2);


                //ls.Location = new Point((this.ClientSize.Width - ls.Width) / 2,
                //(this.ClientSize.Height - ls.Height) / 2);

               ChangeScreen(this, new LoginScreen());



        }
        public static void ChangeScreen(object sender, UserControl next)

        {

            Form f; // will either be the sender or parent of sender 
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;

                f = current.FindForm();

                f.Controls.Remove(current);
            }
            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);

            f.Controls.Add(next);

            next.Focus();

        }
    }
}
