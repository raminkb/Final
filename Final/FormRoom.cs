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
    public partial class FormRoom : Form
    {
        public FormRoom()
        {
            InitializeComponent();
        }

        private void buttonRoom1_Click(object sender, EventArgs e)
        {
            FormBed formBed = new FormBed();
            formBed.ShowDialog();
        }

        private void buttonRoom2_Click(object sender, EventArgs e)
        {
            FormBed formBed = new FormBed();
            formBed.ShowDialog();
        }

        private void buttonRoom3_Click(object sender, EventArgs e)
        {
            FormBed formBed = new FormBed();
            formBed.ShowDialog();
        }

        private void buttonRoom4_Click(object sender, EventArgs e)
        {
            FormBed formBed = new FormBed();
            formBed.ShowDialog();
        }

        private void buttonRoom5_Click(object sender, EventArgs e)
        {
            FormBed formBed = new FormBed();
            formBed.ShowDialog();
        }

        private void buttonRoom6_Click(object sender, EventArgs e)
        {
            FormBed formBed = new FormBed();
            formBed.ShowDialog();
        }
    }
}
