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

            this.textBox1.Text = this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text = "";
            this.textBox3.Text = this.textBox3.Text = "";
            this.comboBox1.Text = this.comboBox1.Text = "";
            this.comboBox2.Text = this.comboBox2.Text = "";
            this.comboBox3.Text = this.comboBox3.Text = "";
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ClassInfor item in listinfor)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5}",
                            item.Name,
                            item.Lastname,
                            item.Id,
                            item.Floor,
                            item.Room,
                            item.Bed));
                    }
                }
            }
            dataGridView1.DataSource = null;

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                BindingSource source = new BindingSource();
                source.DataSource = this.listinfor;
                this.dataGridView1.DataSource = source;
                this.DialogResult = DialogResult.OK;
            }


        }
    }
    }
        
       
 
