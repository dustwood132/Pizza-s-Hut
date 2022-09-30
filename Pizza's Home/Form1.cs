using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_s_Home
{
     

      
    public partial class Form1 : Form
    {

        int numOfpizza = 0;
        int numOfdrinks = 0;
        int numOfwings = 0;
        double pizzaPrice = 20.00;
        double wingPrice =  4.00;
        double drinksPrice = 1.00;
        double taxRate = 0.13;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calulateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
