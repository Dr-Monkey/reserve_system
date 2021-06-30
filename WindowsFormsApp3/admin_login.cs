using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 3.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 4.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 5.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 6.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 7.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 8.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 9.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt輸入.Text += "*".ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt輸入.Text += 0.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt輸入.Text = txt輸入.Text.Substring(0, txt輸入.Text.Length - 1);
        }

        private void btn後台_Click(object sender, EventArgs e)
        {
            if (txt輸入.Text == "123")
            {
                admin_manage adminOpen = new admin_manage();
                adminOpen.ShowDialog();
                this.Close();
                
            }   
            else
            {
                MessageBox.Show("密碼錯誤");
            }
        }
    }
}
