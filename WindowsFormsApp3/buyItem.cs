using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class buyItem : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public buyItem()
        {
            InitializeComponent();
        }

        private void buyItem_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "workDB";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();

            快速填入餐廳名稱();
            cbox餐廳選擇.SelectedIndex = 0;
        }

        void 計算價錢()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select SUM(price) as 總價 from orders where eatName = @NewEatName ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewEatName", cbox餐廳選擇.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbl總價.Text = string.Format("{0} 元", reader["總價"]);
            }

            reader.Close();
            con.Close();
        }

        void 產生統計列表()
        {
            lbox訂購列表.Items.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from orders where eatName = @NewEatName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewEatName", cbox餐廳選擇.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbox訂購列表.Items.Add(reader["people"] + "  " + reader["eatName"] + "  " +reader["item"] +"  "+ reader["price"] + "元");
            }
            reader.Close();
            con.Close();
        }
        void 快速填入餐廳名稱()
        {
            cbox餐廳選擇.Items.Clear();
            string strSQL = "select distinct eatName from orders";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbox餐廳選擇.Items.Add(reader["eatName"]);
            }
            reader.Close();
            con.Close();
        }

        private void btn查詢_Click(object sender, EventArgs e)
        {
            產生統計列表();
            計算價錢();
        }

        private void btn儲存檔案_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"C:\Users\hong\Desktop\";
            Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyyyMMddHHmm") + myNum.ToString() + @"統計檔.html";
            string str完整路徑檔 = str檔案路徑 + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Html File|*.html";

            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
            { //確定
                str完整路徑檔 = sfd.FileName;
            }
            else
            { //取消
                return;
            }

            List<string> lines訂購資訊 = new List<string>();

            lines訂購資訊.Add("<!DOCTYPE html>");
            lines訂購資訊.Add("<html>");
            lines訂購資訊.Add("<head>");
            lines訂購資訊.Add("<meta charset='UTF - 8' />");
            lines訂購資訊.Add("<title>"+ cbox餐廳選擇.SelectedItem.ToString() +"訂購單</title>");
            lines訂購資訊.Add("<link href='https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6' crossorigin='anonymous'>");
            lines訂購資訊.Add("</head>");
            lines訂購資訊.Add("<body>");
            lines訂購資訊.Add("<div class='container justify-content-center text-center'>");
            lines訂購資訊.Add("<div class='col-md-6 offset-md-3'>");
            lines訂購資訊.Add("<div class='card border-primary'>");
            lines訂購資訊.Add("<div class='card-header fs-3 p-3'>"+ cbox餐廳選擇.SelectedItem.ToString() + "訂購單</div>");
            lines訂購資訊.Add("<div class='card-body bg-light'>");
            lines訂購資訊.Add("<h6 class='card-title'>");
            lines訂購資訊.Add(DateTime.Now.ToString() + "  訂購單位: 資策會");
            lines訂購資訊.Add("</h6>");

            lines訂購資訊.Add("<p class='card-text'>");


            lines訂購資訊.Add("［訂購品項］</br>");
            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from orders where eatName=@NewEatName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewEatName", cbox餐廳選擇.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lines訂購資訊.Add(reader["people"] + "  " + reader["item"] + "  " + reader["price"] + "元" + "</br>");
            }
            reader.Close();
            con.Close();

            lines訂購資訊.Add("<hr>");
            lines訂購資訊.Add("訂單總價:" + lbl總價.Text.ToString());
            lines訂購資訊.Add("</p>");
            lines訂購資訊.Add("<button onclick = 'window.print()' class='btn btn-primary btn-lg'>列印</button>");
            lines訂購資訊.Add("</div>");
            lines訂購資訊.Add("</div>");
            lines訂購資訊.Add("</div>");
            lines訂購資訊.Add("</div>");
            lines訂購資訊.Add("</div>");
            lines訂購資訊.Add("</body>");
            lines訂購資訊.Add("</html>");
            System.IO.File.WriteAllLines(str完整路徑檔, lines訂購資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }
    }
}
