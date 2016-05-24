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

namespace BookShop
{
    public partial class Form1 : Form
    {
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

        private void Form1_Load(object sender, EventArgs e)
        {
            tcl_Home.TabPages.Remove(tpe_Function);
            tcl_Home.SelectedTab = tpe_Home;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var item = Account.Login(txt_UserName.Text, txt_Password.Text);
            if (item == null)
            {
                lbl_Alert.Visible = true;
            }
            else
            {
                tcl_Home.TabPages.Insert(1,tpe_Function);
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
    }
}
