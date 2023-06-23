using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class managestudent : Form
    {
        public managestudent()
        {
            InitializeComponent();
        }
        studentclass student = new studentclass();

        private void managestudent_Load(object sender, EventArgs e)
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

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_student.currentRow.cells[0].Value.Tostring();
            textBox_Fname.Text = DataGridView_student.currentRow.cells[1].Value.Tostring();
            textBox_Lname.Text = DataGridView_student.currentRow.cells[2].Value.Tostring();
            textBox_degree.Text = DataGridView_student.currentRow.cells[3].Value.Tostring();

            DateTimePicker.Value = (DataTime)DataGridView_student.CurrentRow.cells[4].Value;
            textBox_gender.Text = DataGridView_student.currentRow.cells[5].Value.Tostring();
            textBox_phone.Text = DataGridView_student.currentRow.cells[6].Value.Tostring();
            textBox_address.Text = DataGridView_student.currentRow.cells[7].Value.Tostring();
            byte[] img = (byte[])DataGridView_student.CurrentRow.Cells[8].Value;
            MemoryStream ms = new MemoryStream(img);
            PictureBox_student.Image = Image.FormStream(ms);

        }

       
        private void button_clear_Click_1(object sender, EventArgs e)
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

        private void button_upload_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFile = new OpenFileDialog();
                opf.Filter = "select photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

                if (openFile.ShowDialog() == DialogResult.OK)
                    pictureBox_student.Image = Image.FromFile(opf.FileName);

            }
        }

        private void button2_search_Click(object sender, EventArgs e)
        {
           
                DataGridView_student.Datasource = studentclass.searchstudent(textBox_search);
                DataGridViewImageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.zoom;
            

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
        private void button1_Click(object sender, EventArgs e)
        {

            string fname = textBox_Fname.Text;
            string lname = textBox_Fname.Text;
            string ID = textBox_Fname.Text;
            string Degree = textBox_Lname.Text;
            DateTime bdate = dateTimePicker2.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = textBox_gender.Text;

            MemoryStream ms = new MemoryStream();

            pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
            byte[] data = ms.ToArray();

            int born_year = dateTimepicker1.Value.year;
            int this_year = DateTime.Now.Year;

        }

        

    }
}
}
