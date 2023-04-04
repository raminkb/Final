using Final.Feil;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final
{
    public partial class FormInformation : Form
    {
        
        //private ClassStudent _inforstudent;
        List<ClassStudent> listinfor = new List<ClassStudent>();

        public FormInformation()
        {
            InitializeComponent();
        }
        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            int iid = 0;
            try
           {
                string id = textBox3.Text;
                iid = Int32.Parse(id);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ใส่ไม่ถูกต้อง");
                return;
            }
            string Floor = comboBox1.Text;
            string Room = comboBox2.Text;
            string Bed = comboBox3.Text;

           
            ClassStudent classStudent = new ClassStudent(name, lastname,iid,Floor,Room,Bed);
            
              this.listinfor.Add(classStudent);

           BindingSource source = new BindingSource();
            source.DataSource = this.listinfor ;
            this.dataGridView1.DataSource = source;
            this.DialogResult = DialogResult.OK;
        }
       
        }
    }
        
       
 
