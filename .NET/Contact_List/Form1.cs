using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class frmContactList : Form
    {
        public frmContactList()
        {
            InitializeComponent();
            SetComboBoxDefault();            
        }

        protected void SetComboBoxDefault()
        {
            comboCategory.SelectedIndex = 0;
        }

        protected void ClearFields()
        {
            txtFirst.Text = string.Empty;
            txtLast.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            SetComboBoxDefault();
            txtAppointment.Text = string.Empty;
        }

        private void frmContactList_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void BindDataGridView()
        {
            CONTACTS_LISTEntities con = new CONTACTS_LISTEntities();
            var list = con.CONTACTS_LIST.Select(grid => new
            {
                grid.FIRSTNAME,
                grid.LASTNAME,
                grid.EMAIL,
                grid.PHONE,
                grid.CATEGORY,
                grid.APPOINTMENT
            }).ToList();

            dataGridView1.DataSource = list;            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                CONTACTS_LISTEntities context = new CONTACTS_LISTEntities();

                CONTACTS_LIST directory = new CONTACTS_LIST();

                directory.FIRSTNAME = txtFirst.Text;
                directory.LASTNAME = txtLast.Text;
                directory.EMAIL = txtEmail.Text;
                directory.PHONE = txtPhone.Text;
                directory.CATEGORY = comboCategory.SelectedItem.ToString();
                directory.APPOINTMENT = txtAppointment.Text;

                context.CONTACTS_LIST.Add(directory);

                context.SaveChanges();

                BindDataGridView();

                ClearFields();
            }
            catch (InvalidOperationException)
            {

                MessageBox.Show("Error entering data into the database.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CONTACTS_LISTEntities context = new CONTACTS_LISTEntities();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string temp = row.Cells["First"].Value.ToString();
            var val = context.CONTACTS_LIST.Where(t => t.FIRSTNAME.Equals(temp)).FirstOrDefault();
            val.FIRSTNAME = txtFirst.Text;
            val.LASTNAME = txtLast.Text;
            val.EMAIL = txtEmail.Text;
            val.PHONE = txtPhone.Text;
            val.CATEGORY = comboCategory.SelectedItem.ToString();
            val.APPOINTMENT = txtAppointment.Text;
            context.SaveChanges();
            BindDataGridView();
            ClearFields();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CONTACTS_LISTEntities context = new CONTACTS_LISTEntities();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string temp = row.Cells["First"].Value.ToString();
            var val = context.CONTACTS_LIST.Where(t => t.FIRSTNAME.Equals(temp)).FirstOrDefault();
            context.CONTACTS_LIST.Remove(val);
            context.SaveChanges();
            BindDataGridView();
            ClearFields();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string val = row.Cells["First"].Value.ToString();
            CONTACTS_LISTEntities context = new CONTACTS_LISTEntities();
            var i = context.CONTACTS_LIST.Where(t => t.FIRSTNAME.Equals(val)).FirstOrDefault();
            txtFirst.Text = i.FIRSTNAME;
            txtLast.Text = i.LASTNAME;
            txtEmail.Text = i.EMAIL;
            txtPhone.Text = i.PHONE;
            comboCategory.SelectedItem = i.CATEGORY;
            txtAppointment.Text = i.APPOINTMENT;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
