using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system.IO;

namespace Assignment
{
    public partial class Form1 : Form
    {
        studentclass student = new studentclass();
        private object dateTimepicker1;
        private object opf;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            opf.Filter = "select photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFile.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);

        }


        private void button_add_Click(object sender, EventArgs e)
        {
            string fname = textBox_Fname.Text;
            string lname = textBox_Fname.Text;
            string ID = textBox_Fname.Text;
            string Degree = textBox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = textBox_gender.Text;

            MemoryStream ms = new MemoryStream();

            pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
            byte[] data = ms.ToArray();

            int born_year = dateTimepicker1.Value.year;
            int this_year = DateTime.Now.Year;

        }

        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
               (textBox_id.Text == "") || (textBox_degree.Text == "") || (textBox_phone.Text == "") ||
                (textBox_address.Text == "") || (pictureBox_student.Image == null)
                {
                return false;
            }
            else
            {
                return true;
            }
        }
       

        private void button_clear_Click_2(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_id.Clear();
            textBox_degree.Clear();
            dateTimePicker2.Value = DateTime.Now;
            textBox_phone.Clear();
            textBox_address.Clear();
            pictureBox_student.Image = null;

        }

       
    }


    private void Form1_Load_1(object sender, EventArgs e)

        {
            showTable();
        }
        Public void showTable()
        {
            DataGridView_student.Datasource = studentclass.getstudentlist();
            DataGridViewImageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.zoom;
        }

      
    }
