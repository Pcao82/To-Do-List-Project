using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_1

{ 

    public partial class Form1 : Form

    {
        public Form1()

        { 
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(txtName.Text, txtAddress.Text, txtSal.Text + "$", txtWork.Text, txtSkills.Text + "%");

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentRow!=null) 
            {
                dgv.CurrentRow.Cells["name"].Value = txtName.Text;
                dgv.CurrentRow.Cells["address"].Value = txtAddress.Text;
                dgv.CurrentRow.Cells["salary"].Value = txtSal.Text + "$";
                dgv.CurrentRow.Cells["name"].Value = txtWork.Text;
                dgv.CurrentRow.Cells["skills"].Value = txtSkills.Text + "%";

            }
        
        
        
            
        

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentRow!= null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }

        private void btnAddCol_Click(object sender, EventArgs e)
        {
            dgv.Columns.Add(txtNameCol.Text, txtTextCol.Text);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null) 
            {
                txtName.Text = dgv.CurrentRow.Cells["name"].Value.ToString();
                txtAddress.Text = dgv.CurrentRow.Cells["address"].Value.ToString();
                txtSal.Text = dgv.CurrentRow.Cells["salary"].Value.ToString();
                txtWork.Text = dgv.CurrentRow.Cells["work"].Value.ToString();
                txtSkills.Text = dgv.CurrentRow.Cells["skills"].Value.ToString();
               
                {
                
                
                }





            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
