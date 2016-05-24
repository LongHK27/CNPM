namespace BookShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcl_Home = new System.Windows.Forms.TabControl();
            this.tpe_Home = new System.Windows.Forms.TabPage();
            this.tpe_Function = new System.Windows.Forms.TabPage();
            this.tcl_Function = new System.Windows.Forms.TabControl();
            this.tpe_Sale = new System.Windows.Forms.TabPage();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.tpe_buy = new System.Windows.Forms.TabPage();
            this.tpe_Account = new System.Windows.Forms.TabPage();
            this.tpe_report = new System.Windows.Forms.TabPage();
            this.tpe_Statistical = new System.Windows.Forms.TabPage();
            this.tpe_Book = new System.Windows.Forms.TabPage();
            this.tpe_Author = new System.Windows.Forms.TabPage();
            this.tpe_Publisher = new System.Windows.Forms.TabPage();
            this.tpe_Promotion = new System.Windows.Forms.TabPage();
            this.tpe_Login = new System.Windows.Forms.TabPage();
            this.btn_Login = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Alert = new System.Windows.Forms.Label();
            this.tcl_Home.SuspendLayout();
            this.tpe_Function.SuspendLayout();
            this.tcl_Function.SuspendLayout();
            this.tpe_Sale.SuspendLayout();
            this.tpe_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcl_Home
            // 
            this.tcl_Home.Controls.Add(this.tpe_Home);
            this.tcl_Home.Controls.Add(this.tpe_Function);
            this.tcl_Home.Controls.Add(this.tpe_Book);
            this.tcl_Home.Controls.Add(this.tpe_Author);
            this.tcl_Home.Controls.Add(this.tpe_Publisher);
            this.tcl_Home.Controls.Add(this.tpe_Promotion);
            this.tcl_Home.Controls.Add(this.tpe_Login);
            this.tcl_Home.ImageList = this.imageList1;
            this.tcl_Home.ItemSize = new System.Drawing.Size(100, 28);
            this.tcl_Home.Location = new System.Drawing.Point(12, 13);
            this.tcl_Home.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tcl_Home.Name = "tcl_Home";
            this.tcl_Home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcl_Home.SelectedIndex = 0;
            this.tcl_Home.Size = new System.Drawing.Size(1082, 567);
            this.tcl_Home.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcl_Home.TabIndex = 2;
            // 
            // tpe_Home
            // 
            this.tpe_Home.AutoScroll = true;
            this.tpe_Home.ImageKey = "home.ico";
            this.tpe_Home.Location = new System.Drawing.Point(4, 32);
            this.tpe_Home.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Home.Name = "tpe_Home";
            this.tpe_Home.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Home.Size = new System.Drawing.Size(1074, 531);
            this.tpe_Home.TabIndex = 0;
            this.tpe_Home.Text = "Home";
            this.tpe_Home.UseVisualStyleBackColor = true;
            // 
            // tpe_Function
            // 
            this.tpe_Function.Controls.Add(this.tcl_Function);
            this.tpe_Function.Location = new System.Drawing.Point(4, 32);
            this.tpe_Function.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Function.Name = "tpe_Function";
            this.tpe_Function.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Function.Size = new System.Drawing.Size(1074, 531);
            this.tpe_Function.TabIndex = 1;
            this.tpe_Function.Text = "Chức năng";
            this.tpe_Function.UseVisualStyleBackColor = true;
            // 
            // tcl_Function
            // 
            this.tcl_Function.Controls.Add(this.tpe_Sale);
            this.tcl_Function.Controls.Add(this.tpe_buy);
            this.tcl_Function.Controls.Add(this.tpe_Account);
            this.tcl_Function.Controls.Add(this.tpe_report);
            this.tcl_Function.Controls.Add(this.tpe_Statistical);
            this.tcl_Function.ItemSize = new System.Drawing.Size(100, 25);
            this.tcl_Function.Location = new System.Drawing.Point(5, 25);
            this.tcl_Function.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tcl_Function.Name = "tcl_Function";
            this.tcl_Function.SelectedIndex = 0;
            this.tcl_Function.Size = new System.Drawing.Size(1069, 493);
            this.tcl_Function.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcl_Function.TabIndex = 0;
            // 
            // tpe_Sale
            // 
            this.tpe_Sale.Controls.Add(this.btn_Xem);
            this.tpe_Sale.Location = new System.Drawing.Point(4, 29);
            this.tpe_Sale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Sale.Name = "tpe_Sale";
            this.tpe_Sale.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Sale.Size = new System.Drawing.Size(1061, 460);
            this.tpe_Sale.TabIndex = 0;
            this.tpe_Sale.Text = "Bán hàng";
            this.tpe_Sale.UseVisualStyleBackColor = true;
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(33, 28);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(113, 34);
            this.btn_Xem.TabIndex = 0;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            // 
            // tpe_buy
            // 
            this.tpe_buy.Location = new System.Drawing.Point(4, 29);
            this.tpe_buy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_buy.Name = "tpe_buy";
            this.tpe_buy.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_buy.Size = new System.Drawing.Size(982, 460);
            this.tpe_buy.TabIndex = 1;
            this.tpe_buy.Text = "Nhập hàng";
            this.tpe_buy.UseVisualStyleBackColor = true;
            // 
            // tpe_Account
            // 
            this.tpe_Account.Location = new System.Drawing.Point(4, 29);
            this.tpe_Account.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Account.Name = "tpe_Account";
            this.tpe_Account.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Account.Size = new System.Drawing.Size(982, 460);
            this.tpe_Account.TabIndex = 2;
            this.tpe_Account.Text = "Tài khoản";
            this.tpe_Account.UseVisualStyleBackColor = true;
            // 
            // tpe_report
            // 
            this.tpe_report.Location = new System.Drawing.Point(4, 29);
            this.tpe_report.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_report.Name = "tpe_report";
            this.tpe_report.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_report.Size = new System.Drawing.Size(982, 460);
            this.tpe_report.TabIndex = 3;
            this.tpe_report.Text = "Báo cáo";
            this.tpe_report.UseVisualStyleBackColor = true;
            // 
            // tpe_Statistical
            // 
            this.tpe_Statistical.Location = new System.Drawing.Point(4, 29);
            this.tpe_Statistical.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Statistical.Name = "tpe_Statistical";
            this.tpe_Statistical.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Statistical.Size = new System.Drawing.Size(982, 460);
            this.tpe_Statistical.TabIndex = 4;
            this.tpe_Statistical.Text = "Thống kê";
            this.tpe_Statistical.UseVisualStyleBackColor = true;
            // 
            // tpe_Book
            // 
            this.tpe_Book.Location = new System.Drawing.Point(4, 32);
            this.tpe_Book.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Book.Name = "tpe_Book";
            this.tpe_Book.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Book.Size = new System.Drawing.Size(1074, 531);
            this.tpe_Book.TabIndex = 2;
            this.tpe_Book.Text = "Sách";
            this.tpe_Book.UseVisualStyleBackColor = true;
            // 
            // tpe_Author
            // 
            this.tpe_Author.Location = new System.Drawing.Point(4, 32);
            this.tpe_Author.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Author.Name = "tpe_Author";
            this.tpe_Author.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Author.Size = new System.Drawing.Size(1074, 531);
            this.tpe_Author.TabIndex = 3;
            this.tpe_Author.Text = "Tác giả";
            this.tpe_Author.UseVisualStyleBackColor = true;
            // 
            // tpe_Publisher
            // 
            this.tpe_Publisher.Location = new System.Drawing.Point(4, 32);
            this.tpe_Publisher.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Publisher.Name = "tpe_Publisher";
            this.tpe_Publisher.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Publisher.Size = new System.Drawing.Size(1074, 531);
            this.tpe_Publisher.TabIndex = 4;
            this.tpe_Publisher.Text = "Nhà xuất bản";
            this.tpe_Publisher.UseVisualStyleBackColor = true;
            // 
            // tpe_Promotion
            // 
            this.tpe_Promotion.Location = new System.Drawing.Point(4, 32);
            this.tpe_Promotion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Promotion.Name = "tpe_Promotion";
            this.tpe_Promotion.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Promotion.Size = new System.Drawing.Size(1074, 531);
            this.tpe_Promotion.TabIndex = 5;
            this.tpe_Promotion.Text = "Khuyến mại";
            this.tpe_Promotion.UseVisualStyleBackColor = true;
            // 
            // tpe_Login
            // 
            this.tpe_Login.Controls.Add(this.lbl_Alert);
            this.tpe_Login.Controls.Add(this.txt_Password);
            this.tpe_Login.Controls.Add(this.txt_UserName);
            this.tpe_Login.Controls.Add(this.label3);
            this.tpe_Login.Controls.Add(this.label2);
            this.tpe_Login.Controls.Add(this.label1);
            this.tpe_Login.Controls.Add(this.btn_Login);
            this.tpe_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpe_Login.Location = new System.Drawing.Point(4, 32);
            this.tpe_Login.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Login.Name = "tpe_Login";
            this.tpe_Login.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpe_Login.Size = new System.Drawing.Size(1074, 531);
            this.tpe_Login.TabIndex = 6;
            this.tpe_Login.Text = "Đăng nhập";
            this.tpe_Login.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(461, 309);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(155, 49);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.ico");
            this.imageList1.Images.SetKeyName(1, "images.png");
            this.imageList1.Images.SetKeyName(2, "tải xuống.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(404, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(426, 200);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(5);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(283, 29);
            this.txt_UserName.TabIndex = 4;
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_UserName_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(426, 246);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '•';
            this.txt_Password.Size = new System.Drawing.Size(283, 29);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // lbl_Alert
            // 
            this.lbl_Alert.AutoSize = true;
            this.lbl_Alert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alert.ForeColor = System.Drawing.Color.Red;
            this.lbl_Alert.Location = new System.Drawing.Point(397, 160);
            this.lbl_Alert.Name = "lbl_Alert";
            this.lbl_Alert.Size = new System.Drawing.Size(323, 21);
            this.lbl_Alert.TabIndex = 6;
            this.lbl_Alert.Text = "Tên tài khoản hoặc mật khẩu không đúng!";
            this.lbl_Alert.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1108, 621);
            this.Controls.Add(this.tcl_Home);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcl_Home.ResumeLayout(false);
            this.tpe_Function.ResumeLayout(false);
            this.tcl_Function.ResumeLayout(false);
            this.tpe_Sale.ResumeLayout(false);
            this.tpe_Login.ResumeLayout(false);
            this.tpe_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcl_Home;
        private System.Windows.Forms.TabPage tpe_Home;
        private System.Windows.Forms.TabPage tpe_Function;
        private System.Windows.Forms.TabControl tcl_Function;
        private System.Windows.Forms.TabPage tpe_Sale;
        private System.Windows.Forms.TabPage tpe_buy;
        private System.Windows.Forms.TabPage tpe_Account;
        private System.Windows.Forms.TabPage tpe_report;
        private System.Windows.Forms.TabPage tpe_Statistical;
        private System.Windows.Forms.TabPage tpe_Book;
        private System.Windows.Forms.TabPage tpe_Author;
        private System.Windows.Forms.TabPage tpe_Publisher;
        private System.Windows.Forms.TabPage tpe_Promotion;
        private System.Windows.Forms.TabPage tpe_Login;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Alert;
    }
}

