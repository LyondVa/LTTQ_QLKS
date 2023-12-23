using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.SmallForm
{
    public partial class background : Form
    {
        public background()
        {
            InitializeComponent();
            this.Size = new Size(1100, 690);
            this.BackColor = Color.Black;
            this.Opacity = 0.8;
        }
    }
}
