using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class FormFloor : Form
    {
        public FormFloor()
        {
            InitializeComponent();
        }

        private void buttonFloor1_Click(object sender, EventArgs e)
        {
            FormRoom formRoom = new FormRoom();
            formRoom.ShowDialog();
            string floor1 = textBox1.Text;
        }

        private void buttonFloor2_Click(object sender, EventArgs e)
        {
            FormRoom formRoom = new FormRoom();
            formRoom.ShowDialog();
            string floor2 = textBox2.Text;
        }

        private void buttonFloor3_Click(object sender, EventArgs e)
        {
            FormRoom formRoom = new FormRoom();
            formRoom.ShowDialog();
            string floor3 = textBox3.Text;  
        }

        private void buttonFloor4_Click(object sender, EventArgs e)
        {
            FormRoom formRoom = new FormRoom();
            formRoom.ShowDialog();
            string floor4 = textBox4.Text;
        }
    }
}
