using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.BLL;
using BookShop.Entities;

namespace BookShop
{
    public partial class Form1 : Form
    {
        //id row đang chọn bảng BOOK
        public int indexRowSach;
        int indexrowTacgia;
        int indexrowhdnhap;
        string biasach;
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        { 
            InitializeComponent();
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    tcl_Home.SelectedTab = tpe_Home;
        //    tcl_Home.TabPages.Remove(tpe_Login);
        //    //tcl_Home.TabPages.Add(tpe_Function);
        //    tcl_Home.TabPages.Insert(1, tpe_Function);
        //}



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var item = Account.Login(txt_UserName.Text, txt_Password.Text);
            if (item == null)
            {
                lbl_Alert.Visible = true;
            }
            else
            {
                tcl_Home.TabPages.Insert(1, tpe_Function);
                tcl_Home.TabPages.Remove(tpe_Login);
                tcl_Home.SelectedTab = tpe_Function;
            }
        }
        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            lbl_Alert.Visible = false;
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            lbl_Alert.Visible = false;
        }

        /// <summary>
        /// load dữ liệu
        /// </summary>
        public void loadBook()
        {
            txt_BookID.Text = BookBLL.loadID().ToString();
            dgv_Book.DataSource = BookBLL.getAllBook().DataSource;
            cbx_themes.DataSource = BookBLL.getChudeCBX();
            cbx_themes.ValueMember = "ID";
            cbx_themes.DisplayMember = "TEN";
            cbx_nxb.DataSource = BookBLL.getNxbCBX();
            cbx_nxb.ValueMember = "ID";
            cbx_nxb.DisplayMember = "TEN";
        }
        /// <summary>
        /// Doubleclickcell hiển thị thông tin tương ứng 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Book_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSach=e.RowIndex;
            txt_BookID.Text = dgv_Book.Rows[indexRowSach].Cells[0].Value.ToString();
            cbx_nxb.SelectedValue = dgv_Book.Rows[indexRowSach].Cells[6].Value;
            cbx_themes.SelectedValue = dgv_Book.Rows[indexRowSach].Cells[5].Value;
            txt_BookName.Text = dgv_Book.Rows[indexRowSach].Cells[1].Value.ToString();
            txt_BookPriceout.Text = dgv_Book.Rows[indexRowSach].Cells[2].Value.ToString();
            txt_BookPricein.Text = dgv_Book.Rows[indexRowSach].Cells[3].Value.ToString();
            txt_BookMT.Text = dgv_Book.Rows[indexRowSach].Cells[4].Value.ToString();
            txt_BookSl.Text = dgv_Book.Rows[indexRowSach].Cells[8].Value.ToString();
            txt_BookK.Text = dgv_Book.Rows[indexRowSach].Cells[9].Value.ToString();
            txt_soTrang.Text = dgv_Book.Rows[indexRowSach].Cells[10].Value.ToString();
            picBox_Bookimage.Image = Image.FromFile(dgv_Book.Rows[indexRowSach].Cells[7].Value.ToString());
        }
        /// <summary>
        /// lấy dữ liệu từ datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpe_Book_Click(object sender, EventArgs e)
        {
            dgv_Book.DataSource = BookBLL.getAllBook().DataSource;
        }
        /// <summary>
        /// Load dữ liệu lên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_loaddataBook_Click(object sender, EventArgs e)
        {
            loadBook();
        }
        /// <summary>
        /// Chọn ảnh cho sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_openPicture_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"F:\image";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                picBox_Bookimage.Image = Image.FromFile(ofd.FileName);
            }
            biasach = ofd.FileName;
        }
        /// <summary>
        /// Tạo 1 cuốn sách mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CreateBook_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_BookID.Text);
            int prin = int.Parse(txt_BookPricein.Text);
            int prout = int.Parse(txt_BookPriceout.Text);
            int cd = int.Parse(cbx_themes.SelectedValue.ToString());
            int nxb = int.Parse(cbx_nxb.SelectedValue.ToString());
            int sl = int.Parse(txt_BookSl.Text);
            int st = int.Parse(txt_soTrang.Text);
            BookBLL.insertBook(id, txt_BookName.Text, prout, prin, txt_BookMT.Text, cd, nxb, biasach, sl, txt_BookK.Text, st);
            dgv_Book.DataSource = BookBLL.getAllBook().DataSource;
        }
        /// <summary>
        /// Sửa thông tin 1 cuốn sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_updateBook_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_BookID.Text);
            int prin = int.Parse(txt_BookPricein.Text);
            int prout = int.Parse(txt_BookPriceout.Text);
            int cd = int.Parse(cbx_themes.SelectedValue.ToString());
            int nxb = int.Parse(cbx_nxb.SelectedValue.ToString());
            int sl = int.Parse(txt_BookSl.Text);
            int st = int.Parse(txt_soTrang.Text);
            BookBLL.updateBook(id,txt_BookName.Text, prout, prin, txt_BookMT.Text, cd, nxb, biasach, sl, txt_BookK.Text, st);
            dgv_Book.DataSource = BookBLL.getAllBook().DataSource;
        }


        /// <summary>
        /// Load thông tin tác giả
        /// </summary>
        public void loadAuthor()
        {
            txt_AuthorID.Text = AuthorBLL.loadID().ToString();
            dgv_Author.DataSource = AuthorBLL.getAllAuthor().DataSource;
            
        }
        /// <summary>
        /// load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_loadAuthor_Click(object sender, EventArgs e)
        {
            loadAuthor();
        }
        /// <summary>
        /// Đưa thông tin tác giả lên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Author_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrowTacgia = e.RowIndex;
            txt_AuthorID.Text = dgv_Author.Rows[indexrowTacgia].Cells[0].Value.ToString();
            txt_AuthorName.Text = dgv_Author.Rows[indexrowTacgia].Cells[1].Value.ToString();
            txt_AuthorDC.Text = dgv_Author.Rows[indexrowTacgia].Cells[2].Value.ToString();
            txt_AuthorPhone.Text = dgv_Author.Rows[indexrowTacgia].Cells[3].Value.ToString();
        }
        /// <summary>
        /// Cập nhật thông tin tác giả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            AuthorBLL.updateAuthor(int.Parse(txt_AuthorID.Text), txt_AuthorName.Text, txt_AuthorPhone.Text, txt_AuthorDC.Text);
            dgv_Author.DataSource = AuthorBLL.getAllAuthor().DataSource;
        }
        /// <summary>
        /// Xóa 1 tác giả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xóa?","Question",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AuthorBLL.deleteAuthor(int.Parse(txt_AuthorID.Text));
                dgv_Author.DataSource = AuthorBLL.getAllAuthor().DataSource;
            }
            else
            {
                this.Activate();
            }
        }
        /// <summary>
        /// Thêm mới 1 tác giả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AuthorInsert_Click(object sender, EventArgs e)
        {
            int _ID = int.Parse(txt_AuthorID.Text);
            AuthorBLL.createAuthor(_ID, txt_AuthorName.Text, txt_AuthorPhone.Text, txt_AuthorDC.Text);
            dgv_Author.DataSource = AuthorBLL.getAllAuthor().DataSource;
        }
        /// <summary>
        /// ngưng bán 1 cuốn sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stopBook_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_BookID.Text);
            int prin = int.Parse(txt_BookPricein.Text);
            int prout = int.Parse(txt_BookPriceout.Text);
            int cd = int.Parse(cbx_themes.SelectedValue.ToString());
            int nxb = int.Parse(cbx_nxb.SelectedValue.ToString());
            int sl = int.Parse(txt_BookSl.Text);
            int st = int.Parse(txt_soTrang.Text);
            BookBLL.stopBook(id, txt_BookName.Text, prout, prin, txt_BookMT.Text, cd, nxb, biasach, sl, txt_BookK.Text, st);
            dgv_Book.DataSource = BookBLL.getAllBook().DataSource;
        }
        /// <summary>
        /// tìm kiếm 1 cuốn sách nào đó theo thông tin sẵn có
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bookSearch_Click(object sender, EventArgs e)
        {
            dgv_Book.DataSource = BookBLL.searchBook(txt_bookSearch.Text).DataSource;
        }
        /// <summary>
        /// Tìm kiếm tác giả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AuthorSearch_Click(object sender, EventArgs e)
        {
            dgv_Book.DataSource = AuthorBLL.searchAuthor(txt_AuthorSearch.Text).DataSource;
        }

        /// <summary>
        /// Load thông tin tác giả
        /// </summary>
        public void loadbill()
        {
            txt_billID.Text = BillBLL.loadID().ToString();
            dgv_Bill.DataSource = BillBLL.getAllBill().DataSource;
            cbx_billNXB.DataSource = BillBLL.getNxbCBX();
            cbx_billNXB.ValueMember = "ID";
            cbx_billNXB.DisplayMember = "TEN";
        }
        /// <summary>
        /// load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_loadBill_Click(object sender, EventArgs e)
        {
            loadbill();
        }
        /// <summary>
        /// Đưa thông tin phiếu nhập lên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Bill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrowhdnhap = e.RowIndex;
            txt_billID.Text = dgv_Bill.Rows[indexrowhdnhap].Cells[0].Value.ToString();
            cbx_billNXB.SelectedValue = dgv_Bill.Rows[indexrowhdnhap].Cells[1].Value;
            date_Bill.Text = dgv_Bill.Rows[indexrowhdnhap].Cells[2].Value.ToString();
            txt_billSl.Text = dgv_Bill.Rows[indexrowhdnhap].Cells[3].Value.ToString();
        }
        /// <summary>
        /// Cập nhật thông tin phiếu nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_billUpdate_Click(object sender, EventArgs e)
        {
            int id_nxb = int.Parse(cbx_billNXB.SelectedValue.ToString());
            DateTime ngay = DateTime.Parse(date_Bill.Text);
            BillBLL.updateBill(int.Parse(txt_billID.Text), id_nxb,ngay, int.Parse(txt_billSl.Text));
            dgv_Bill.DataSource = BillBLL.getAllBill().DataSource;
        }
        /// <summary>
        /// Xóa 1 phiếu nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_billDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BillBLL.deleteBill(int.Parse(txt_billID.Text));
                dgv_Bill.DataSource = BillBLL.getAllBill().DataSource;
            }
            else
            {
                this.Activate();
            }
        }
        /// <summary>
        /// Thêm mới 1 phiếu nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_billCreate_Click(object sender, EventArgs e)
        {
            int _ID = int.Parse(txt_billID.Text);
            BillBLL.createBill(_ID, int.Parse(cbx_billNXB.SelectedValue.ToString()), DateTime.Parse(date_Bill.Text), int.Parse(txt_billSl.Text));
            dgv_Bill.DataSource = BillBLL.getAllBill().DataSource;
        }

        /// <summary>
        /// tìm kiếm 1 phiếu nhập nào đó theo thông tin sẵn có
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_billSearch_Click(object sender, EventArgs e)
        {
            dgv_Bill.DataSource = BillBLL.searchBill(int.Parse(txt_billID.Text)).DataSource;
        }
    }
}
