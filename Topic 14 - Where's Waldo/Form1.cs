using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_14___Where_s_Waldo
{
    public partial class FormWaldo : Form
    {
        Random generater = new Random();
        
        public FormWaldo()
        {
            InitializeComponent();
        }

        private void imgWaldo_Click(object sender, EventArgs e)
        {
            int locationY = generater.Next(10, this.ClientSize.Height - imgWaldo.Height);
            int locationX = generater.Next(10, this.ClientSize.Width - imgWaldo.Width);
            imgWaldo.Location = new Point(locationX, locationY);
        }
    }
}
