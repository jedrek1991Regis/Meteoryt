using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Meteoryt
{
    class Class1 : System.Windows.Forms.Panel
    {

        private void InitializeComponent()
        {
            
            this.SuspendLayout();
            // 
            // Class1
            // 
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Class1_Paint);
            this.ResumeLayout(false);
            this.BackColor = Color.White;

        }

        private void Class1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
           
        }
    }
}
