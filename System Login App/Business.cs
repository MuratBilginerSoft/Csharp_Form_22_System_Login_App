using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Login_App
{
    public class Business
    {


        public void StatusControl(Panel Pnl, Label Lbl)
        {
            Pnl.BackColor = Color.Transparent;
            Lbl.ForeColor = Color.Black;
            Lbl.Text = "Status";
        }

    }
}
