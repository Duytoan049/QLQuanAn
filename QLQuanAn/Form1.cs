

using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace QLQuanAn
{
    public partial class QLQA : Form
    {
        ConnectDB db = new ConnectDB();
        public QLQA()
        {
            InitializeComponent();
        }


        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (db.CheckLogin(username, password))
            {
                FormMain mainForm = new FormMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Sai tài khoản hoặc mật khẩu!",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QLQA_Load(object sender, EventArgs e)
        {

        }
    }
}
