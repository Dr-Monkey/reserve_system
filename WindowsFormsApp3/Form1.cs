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
    public partial class login : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public login()
        {
            InitializeComponent();
        }
        
        

        void 顯示所有餐廳()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from restaurant";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介
                dt.Load(reader);
                dataGridView菜單.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        /* ---------------------------------------------------------- */
        void 產生訂單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from orders";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介
                dt.Load(reader);
                dataGridView訂單列表.DataSource = dt;
            }

            reader.Close();
            con.Close();
        }
        void 計算購物車價錢()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select SUM(price) as 總價 from orders;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbl總價.Text = string.Format("總共 {0} 元", reader["總價"]);
            }

            reader.Close();
            con.Close();
        }
        /* ---------------------------------------------------------- */
        /* ---------------------------------------------------------- */
        void 篩選餐廳()
        {
            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select distinct eatName from restaurant";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbox_restaurant.Items.Add(reader["eatName"]);
            }
            reader.Close();
            con.Close();
            
        }

        void 產生菜單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from restaurant where eatName = @OnlyEatName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@OnlyEatName", cbox_restaurant.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介
                dt.Load(reader);
                dataGridView菜單.DataSource = dt;
            }

            reader.Close();
            con.Close();

        }
        /* ---------------------------------------------------------- */
        /* ---------------------------------------------------------- */
        void 值日生提醒()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select class,name from member where 值日生狀態 = 1";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbox值日生.Items.Add(reader["class"] +" "+ reader["name"]);
            }
            reader.Close();
            con.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "workDB";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();

            篩選學員班級();
            篩選學員名稱();
            產生學員電話();

            篩選餐廳();
            顯示所有餐廳();

            產生訂單();
            計算購物車價錢();

            值日生提醒();

            cbox_restaurant.SelectedIndex = 0;
            

            if (chk值日生.Checked == true)
            {
                btn開啟訂購單.Visible = true;
            }
            else
            {
                btn開啟訂購單.Visible = false;
            }

            dataGridView菜單.ClearSelection();
            dataGridView訂單列表.ClearSelection();

            /*  失去焦點
            dataGridView菜單.ClearSelection();
            dataGridView訂單列表.ClearSelection();
            */
        }

        void 篩選學員班級()
        {
            cbox_class.Items.Clear();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select distinct class from member";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader();
            //int i = 0;
            while (reader.Read())
            {
                cbox_class.Items.Add(reader["class"]);
                //i += 1;

            }

            reader.Close();
            con.Close();
            cbox_class.SelectedIndex = 0;
        }
        void 篩選學員名稱()
        {
            cbox_name.Items.Clear();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select name from member where class = @selectClass";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@selectClass", cbox_class.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            //int i = 0;
            while (reader.Read())
            {
                cbox_name.Items.Add(reader["name"]);
                //i += 1;

                cbox_name.SelectedIndex = 0;
            }

            reader.Close();
            con.Close();

        }
        void 產生學員電話()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select tel,值日生狀態 from member where name = @selectName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@selectName", cbox_name.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            //int i = 0;
            while (reader.Read())
            {
                txt_tel.Text = string.Format("{0}", reader["tel"]);
                chk值日生.Checked = (bool)reader["值日生狀態"];

            }

            reader.Close();
            con.Close();
        }
        /* ---------------------------------------------------------- */
        /* ---------------------------------------------------------- */
        private void cbox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            篩選學員名稱();
        }

        private void cbox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            產生學員電話();
            if (chk值日生.Checked == true)
            {
                btn開啟訂購單.Visible = true;
            }
            else
            {
                btn開啟訂購單.Visible = false;
            }
            
        }

        private void cbox_restaurant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn加入訂單列_Click(object sender, EventArgs e)
        {
            if (lbl餐廳名.Text != "餐廳名稱")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into orders values(@餐廳名稱, @餐點項目, @餐點價格,@點單人);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
            
                cmd.Parameters.AddWithValue("@餐廳名稱", lbl餐廳名.Text);
                cmd.Parameters.AddWithValue("@餐點項目", lbl品項.Text);
                cmd.Parameters.AddWithValue("@餐點價格", lbl價錢.Text);
                cmd.Parameters.AddWithValue("@點單人", cbox_name.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                con.Close();

                產生訂單();
                MessageBox.Show("加入成功");
                計算購物車價錢();
                txt刪除品項.Text = dataGridView訂單列表.CurrentCell.Value.ToString();
                dataGridView訂單列表.ClearSelection();
            }
            else
            {
                MessageBox.Show("請點取選項再加入");
            }
        }

        private void dataGridView菜單_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) { return; }
            string strSelID = dataGridView菜單.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intSelID = Convert.ToInt32(strSelID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from restaurant where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            // ado.net特有的搜尋過濾 @SearchName
            cmd.Parameters.AddWithValue("@SearchID", intSelID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
                lbl餐廳名.Text = string.Format("{0}", reader["eatName"]);
                lbl品項.Text = string.Format("{0}", reader["item"]);
                lbl價錢.Text = string.Format("{0} ", reader["price"]);
            }
            else
            {
                MessageBox.Show("查無此品項");
            }
            reader.Close();
            con.Close();
            
        }

        private void dataGridView訂單列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) { return; }
            string strSelID = dataGridView訂單列表.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intSelID = Convert.ToInt32(strSelID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from orders where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            // ado.net特有的搜尋過濾 @SearchName
            cmd.Parameters.AddWithValue("@SearchID", intSelID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txt刪除品項.Text = string.Format("{0}",reader["id"]);
            }
            
            reader.Close();
            con.Close();

            

        }

        private void btn刪除品項_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你確定要刪除此項目?", "刪除作業", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            { 
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "delete from orders where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", txt刪除品項.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("刪除成功");
            產生訂單();
            計算購物車價錢();
            txt刪除品項.Text = dataGridView訂單列表.CurrentCell.Value.ToString();
            dataGridView訂單列表.ClearSelection();
            }
            else
            {

            }
        }

        private void btn後台_Click(object sender, EventArgs e)
        {
            admin_login login = new admin_login();
            login.ShowDialog();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn開啟訂購單_Click(object sender, EventArgs e)
        {
            buyItem openBuyItem = new buyItem();
            openBuyItem.ShowDialog();
        }

        private void btn顯示所有餐廳_Click(object sender, EventArgs e)
        {
            顯示所有餐廳();
            dataGridView菜單.ClearSelection();
        }

        private void btn顯示選擇餐廳_Click(object sender, EventArgs e)
        {
            產生菜單();
            dataGridView菜單.ClearSelection();
        }
    }
}
