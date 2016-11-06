using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateListing
{
    public partial class Form2 : Form
    {
        private string selection = "";
        private string[] information = new string[5];
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string x, string[] infor)  //constuctor
        {//vb you must manually type in init
            InitializeComponent();
            selection = x; //must put in after init
            information[0] = infor[0];
            information[1] = infor[1];
            information[2] = infor[2];
            information[3] = infor[3];
            information[4] = infor[4];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(selection == "House 1")
            {
                pictureBox1.Image =
                Image.FromFile(@"C: \Users\RobinY\Documents\NET One\Projects\RealEstateListing\houseListings\h1.jpg");
                
            }
            if (selection == "House 2")
            {
                pictureBox1.Image =
                Image.FromFile(@"C: \Users\RobinY\Documents\NET One\Projects\RealEstateListing\houseListings\h2.jpg");

            }
            if (selection == "House 3")
            {
                pictureBox1.Image =
                Image.FromFile(@"C: \Users\RobinY\Documents\NET One\Projects\RealEstateListing\houseListings\h3.jpg");

            }
        }
    }
}
