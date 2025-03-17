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

namespace QLQuanAn.Model
{
    public partial class FormCategoryAdd : SampleAdd
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public void btnSave_Click_1(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into category values(@Name)";
            }
            else
            {
                qry = "Update category set catName = @Name where catID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@Name", txtName.Text);
            ht.Add("@id", id);

            if (ConnectDB.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Thành công");
                id = 0;
                txtNameHeader.Focus();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
