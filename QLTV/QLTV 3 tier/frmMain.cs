using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLTV
{
    public partial class frmMain : MetroForm
    {

        private DTO.DangNhap_DTO user;
        public delegate void delPassUserData(DangNhap_DTO user);
        private Boolean isRunning;

        public frmMain()
        {
            InitializeComponent();
            menuStripMain.Enabled = false;
            user = new DangNhap_DTO();
            txtUser.Focus();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FocusMe();
        }

        public void showInfo()
        {
            if (this.user.TenDangNhap != "") {
                if (this.user.LoaiTaiKhoan == 1)
                {
                    
                    groupboxLogin.Hide();
                    lbXinChao.Text = "Xin chào " + user.TenDangNhap  + " !";
                }
                else
                {
                    groupboxLogin.Hide();                    
                    
                    lbXinChao.Text = "Xin chào " + BUS_OBJ.layTenDocGia(user.TenDangNhap) +" !";
                    
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,"Bạn có muốn thoát khỏi chương trình không ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                isRunning = false;
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
       

        private void hieuChinhDGV()
        {
            datagvSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datagvSach.Columns[0].HeaderText = "Mã sách";
            datagvSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            datagvSach.Columns[1].HeaderText = "Tên sách";
            datagvSach.Columns[1].Width = 180;
            datagvSach.Columns[2].HeaderText = "Mã tác giả";

            datagvSach.Columns[3].HeaderText = "Mã thể loại";

            datagvSach.Columns[4].HeaderText = "Nhà XB";

            datagvSach.Columns[5].HeaderText = "Năm XB";

            datagvSach.Columns[6].HeaderText = "Số trang";

            datagvSach.Columns[7].HeaderText = "Giá";

            datagvSach.Columns[8].HeaderText = "Số bản";

            datagvSach.Columns[9].HeaderText = "Tồn";

        }      
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripMain.Enabled = false;
            lbXinChao.Text = "Xin chào ";
            groupboxLogin.Show();
            txtUser.Text = "";
            txtPwd.Text = "";
            user.TenDangNhap = "";
            user.MatKhau = "";
            user.LoaiTaiKhoan = 10;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK doiMK = new frmDoiMK(this);
            delPassUserData del = new delPassUserData(doiMK.receivingData);
            del(this.user);
            this.Opacity = .75;
            doiMK.ShowDialog();
        }

        private void tạoMớiTKNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoMoiTKNV taoMoiTKNV = new frmTaoMoiTKNV(this);
            this.Opacity = .75;
            taoMoiTKNV.ShowDialog();
        }

        private void cậpNhậtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatSach capNhatSach = new frmCapNhatSach(this);
            this.Opacity = .75;
            capNhatSach.ShowDialog();
        }

        private void cậpNhậtTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatTacGia capNhatTG = new frmCapNhatTacGia(this);
            this.Opacity = .75;
            capNhatTG.ShowDialog();
        }

        private void cậpNhậtNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatNXB capNhatNXB = new frmCapNhatNXB(this);
            this.Opacity = .75;
            capNhatNXB.ShowDialog();
        }

        private void cậpNhậtThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatTheLoai capNhatTheLoai = new frmCapNhatTheLoai(this);
            this.Opacity = .75;
            capNhatTheLoai.ShowDialog();
        }

        private void cậpNhậtĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatDocGia capNhatDocGia = new frmCapNhatDocGia(this);
            this.Opacity = .75;
            capNhatDocGia.ShowDialog();
        }

        private void cậpNhậtThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatThe capNhatThe = new frmCapNhatThe(this);
            this.Opacity = .75;
            capNhatThe.ShowDialog();
        }
                                                       
        private void tmShowInfo_Tick(object sender, EventArgs e)
        {
            if (!this.isRunning)
            {
                tmShowInfo.Enabled = false;
            }
            else
            {
                showInfo();
            }
        }
        public int i = 10;
        private void timertieude_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                object objLoaiTK = BUS_OBJ.layLoaiTaiKhoan(txtUser.Text, txtPwd.Text);
                if (objLoaiTK != null)
                {
                    if (objLoaiTK.ToString() == "1")// quyền admin
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        menuStripMain.Enabled = true;
                        tàiKhoảnToolStripMenuItem.Enabled = true;
                        quảnLýHệThốngToolStripMenuItem.Enabled = true;
                        tạoMớiTKNVToolStripMenuItem.Enabled = true;
                        user.TenDangNhap = txtUser.Text;
                        user.MatKhau = txtPwd.Text;
                        user.LoaiTaiKhoan = Convert.ToInt16(objLoaiTK);

                        this.showInfo();
                    }
                    else if (objLoaiTK.ToString() == "0")// quyền user
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        menuStripMain.Enabled = true;
                        tàiKhoảnToolStripMenuItem.Enabled = true;
                        quảnLýHệThốngToolStripMenuItem.Enabled = false;
                        tạoMớiTKNVToolStripMenuItem.Enabled = false;
                        user.TenDangNhap = txtUser.Text;
                        user.MatKhau = txtPwd.Text;
                        user.LoaiTaiKhoan = Convert.ToInt16(objLoaiTK);
                        this.showInfo();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Text = "";
                    txtPwd.Text = "";
                    txtUser.Focus();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Text = "";
                txtPwd.Text = "";
                txtUser.Focus();
            }
        }
        

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }

}
