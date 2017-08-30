using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEOFLIFE2
{
    public partial class OPTIONS : Form
    {
        public OPTIONS()
        {
            InitializeComponent();
        }

        public NumericUpDown timerChanger
        {
            get { return timerInterval; }
            set { timerInterval = value; }

        }
        public NumericUpDown Widther
        {
            get { return widthChanger; }
            set { widthChanger = value; }

        }
        public NumericUpDown Heighter
        {
            get { return heightChanger; }
            set { heightChanger = value; }
        }

   //  public ColorDialog backColor
   //    {
   //   //     get { return backgroundColorDialog; }
   //    }

        private void gridColorDialog_Click(object sender, EventArgs e)
        {

        }
    }
}
