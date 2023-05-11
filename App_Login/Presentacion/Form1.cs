using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private int counter;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.  
            counter = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (counter >= 10)
            {
                // Exit loop code.
               
                timer1.Enabled = false;
                counter = 0;
                timer1.Stop();
                MessageBox.Show("Terminado");
            }
            else
            {
                // Run your procedure here.  
                // Increment counter.  
                counter = counter + 1;
                label1.Text = "Procedures Run: " + counter.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTimer();
        }
    }
}
