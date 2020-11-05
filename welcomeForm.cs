using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleGame
{
    public partial class welcomeForm : Form
    {
        simpleGame simpleGame_obj = new simpleGame();
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            simpleGame_obj.Show();
        }
    }
}
