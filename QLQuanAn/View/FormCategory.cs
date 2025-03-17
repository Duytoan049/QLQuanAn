using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuanAn.Model;

namespace QLQuanAn.View
{
    public partial class FormCategory : SampleView
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "select * from category where catName like '%" + textSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            ConnectDB.loadData(qry, guna2DataGridView1, lb);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            FormCategoryAdd f = new FormCategoryAdd();
            f.ShowDialog();
            GetData();
        }

        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FormCategoryAdd f = new FormCategoryAdd();
                f.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                f.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                f.ShowDialog();
                GetData();
            }
            else if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "delete from category where catID = " +id + " ";
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    if (ConnectDB.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("Thành công");
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
        }
    }

}
