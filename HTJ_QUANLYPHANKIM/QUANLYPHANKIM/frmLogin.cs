using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QUANLYPHANKIM.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHANKIM
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Bus_User _nguoidung;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _nguoidung = new Bus_User();
        }      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var us = _nguoidung.Login(txtUsername.Text, Encryptor.Encrypt(txtPass.Text, "123789@$", true));            
            if (us == null)
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Library.user = _nguoidung.GetById(us.UserId);
                MainForm main = (MainForm)Application.OpenForms["MainForm"];
                main.lblFullname.Caption = Library.user.Fullname;
                if (Library.handle != null)
                    SplashScreenManager.CloseOverlayForm(Library.handle);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                Application.Exit();
            
        }
    }
}