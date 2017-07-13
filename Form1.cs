using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSelecter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Decimal decRegFee, decLodging, decTotal, decDays;
        private void button1_Click(object sender, EventArgs e)
        {
            String strWorkshop, strLocation;
            
            strLocation = lstLocation.SelectedItem.ToString();
            strWorkshop = lstWorkshop.SelectedItem.ToString();
            switch (strLocation)
            {
                case "Austin":
                    decLodging = 150;
                    break;
                case "Chicago":
                    decLodging = 225;
                    break;
                case "Dallas":
                    decLodging = 175;
                    break;
                case "Orlando":
                    decLodging = 300;
                    break;
                case "Phoenix":
                    decLodging = 175;
                    break;
                case "Raleigh":
                    decLodging = 150;
                    break;
            }
            switch (strWorkshop)
            {
                case "Handling Stress":
                    decRegFee = 1000;
                    decDays = 3;
                    break;
                case "Time Management":
                    decRegFee = 800;
                    decDays = 3;
                    break;
                case "Supervision Skills":
                    decRegFee = 1500;
                    decDays = 3;
                    break;
                case "Negotiation":
                    decRegFee = 1300;
                    decDays = 5;
                    break;
                case "How to Interview":
                    decRegFee = 500;
                    decDays = 1;
                    break;
            }
            decLodging *= decDays;
            decTotal = decRegFee + decLodging;
            lblOut.Text = "Registration: " + decRegFee.ToString("C") + Environment.NewLine + 
                "Lodging: "+decLodging.ToString("C") + Environment.NewLine + 
                "Total: "+decTotal.ToString("C");
            
        }
    }
}
