using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsVar_6
{
    public partial class Form1 : Form
    {
        public AllGruppa _students;
        public Form1()
        {
            InitializeComponent();
            _students = new AllGruppa();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<AllGruppa> _poisk = _students.Student.Where(x => x.surname.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            dataGridView1.DataSource = _poisk;
        }
    }
}
