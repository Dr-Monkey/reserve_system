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
    public partial class admin_manage : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public admin_manage()
        {
            InitializeComponent();
        }

        void 快速填入班級()
        {
            cbox填入班級.Items.Clear();
            string strSQL = "select distinct class from member";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbox填入班級.Items.Add(reader["class"]);
            }
            reader.Close();
            con.Close();
        }

        void 值日生介面()
        {
            string strSQL = "select * from member";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介
                dt.Load(reader);
                dataGridView值日生.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }


        void 快速填入餐廳名稱()
        {
            cbox_restaurant.Items.Clear();
            string strSQL = "select distinct eatName from restaurant";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbox_restaurant.Items.Add(reader["eatName"]);
            }
            reader.Close();
            con.Close();
        }
        /* ---------------------------------------------------------- */
        void 清空欄位()
        {
            txt餐點ID.Text = "";
            txt餐廳名稱.Text = "";
            txt餐點項目.Text = "";
            txt餐點價錢.Text = "";
        }
        void 清空欄位2()
        {
            txt人員ID新增用.Text = "";
            txt班級.Text = "";
            txt姓名.Text = "";
            txt電話.Text = "";
        }
        /* ---------------------------------------------------------- */
        /* ---------------------------------------------------------- */
        void 餐廳選擇()
        {
            cbox_restaurantChoose.Items.Clear();
            string strSQL = "select distinct eatName from restaurant";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbox_restaurantChoose.Items.Add(reader["eatName"]);
            }
            reader.Close();
            con.Close();
        }

        void 班級選擇()
        {
            cbox班級選擇.Items.Clear();
            string strSQL = "select distinct class from member";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbox班級選擇.Items.Add(reader["class"]);
            }
            reader.Close();
            con.Close();
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

        void 產生菜單()
        {
            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from restaurant where eatName = @NewEatName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewEatName", cbox_restaurantChoose.SelectedItem.ToString());
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
        
        private void admin_manage_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "workDB";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();

            顯示所有餐廳();
            
            餐廳選擇();  // 加入餐廳名稱
            
            快速填入餐廳名稱();  // 右側的  快速填寫介面

            值日生介面();  // 右側的值日生介面
            班級選擇();

            快速填入班級();  // 右側的 快速填寫介面
            cbox_restaurantChoose.SelectedIndex = 0;
            cbox班級選擇.SelectedIndex = 0;
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
                
                txt餐點ID.Text = string.Format("{0}", reader["id"]);
                txt餐廳名稱.Text = string.Format("{0}", reader["eatName"]);
                txt餐點項目.Text = string.Format("{0} ", reader["item"]);
                txt餐點價錢.Text = string.Format("{0}", reader["price"]);
            }
            else
            {
                MessageBox.Show("查無此品項");
            }
            reader.Close();
            con.Close();
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn新增餐點_Click(object sender, EventArgs e)
        {
            if ( (txt餐廳名稱.Text != "") && (txt餐點價錢.Text != "") && (txt餐點項目.Text != "") )
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into restaurant values(@eatName, @item, @price);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@eatName", txt餐廳名稱.Text);
                cmd.Parameters.AddWithValue("@item", txt餐點項目.Text);
                cmd.Parameters.AddWithValue("@price", txt餐點價錢.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料新增成功");
                餐廳選擇();
                快速填入餐廳名稱();
                顯示所有餐廳();


                txt餐點項目.Text = "";
                txt餐點價錢.Text = "";
                dataGridView菜單.ClearSelection();
            }
            else
            {
                MessageBox.Show("請填入所有欄位");
            }
            


        }

        private void btn修改餐點_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt餐點ID.Text, out intID);

            if (intID > 0)
            {
                if ((txt餐廳名稱.Text != "") && (txt餐點價錢.Text != "") && (txt餐點項目.Text != ""))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update restaurant set eatName=@NewEatName, item=@NewItem , price=@newPrice where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    cmd.Parameters.AddWithValue("@NewEatName", txt餐廳名稱.Text);
                    cmd.Parameters.AddWithValue("@NewItem", txt餐點項目.Text);
                    cmd.Parameters.AddWithValue("@newPrice", txt餐點價錢.Text);


                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(rows.ToString() + "筆資料修改成功");

                    餐廳選擇();
                    快速填入餐廳名稱();
                    清空欄位();
                    顯示所有餐廳();
                    dataGridView菜單.ClearSelection();
                }
                else
                {
                    MessageBox.Show("請填入所有欄位");
                }
            }
        }

        private void btn刪除餐點_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt餐點ID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from restaurant where id =@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                

                MessageBox.Show(rows.ToString() + "筆資料刪除成功");
                餐廳選擇();
                快速填入餐廳名稱();
                清空欄位();
                顯示所有餐廳();
                dataGridView菜單.ClearSelection();

            }
        }

        private void cbox_restaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView菜單.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt餐廳名稱.Text = cbox_restaurant.SelectedItem.ToString();
        }

        private void cbox_restaurantChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btn顯示所有餐廳_Click(object sender, EventArgs e)
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
            dataGridView菜單.ClearSelection();
        }

        private void dataGridView值日生_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            string strSelID = dataGridView值日生.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intSelID = Convert.ToInt32(strSelID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from member where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            // ado.net特有的搜尋過濾 @SearchName
            cmd.Parameters.AddWithValue("@SearchID", intSelID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt指定值日生ID.Text = string.Format("{0}", reader["id"]);
                txt人員ID新增用.Text = string.Format("{0}", reader["id"]);
                txt班級.Text = string.Format("{0}", reader["class"]);
                txt姓名.Text = string.Format("{0}", reader["name"]);
                txt電話.Text = string.Format("{0}", reader["tel"]);
            }
            else
            {
                MessageBox.Show("查無此品項");
            }
            reader.Close();
            con.Close();
        }

        private void btn指定值日生_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt指定值日生ID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update member set 值日生狀態=@New值日生狀態 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@New值日生狀態", true);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料修改成功");
                值日生介面();
                dataGridView值日生.ClearSelection();
            }
        }

        private void btn取消值日生_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt指定值日生ID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update member set 值日生狀態=@New值日生狀態 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@New值日生狀態", false);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料修改成功");
                值日生介面();
            }
        }

        private void btn清空欄位2_Click(object sender, EventArgs e)
        {
            清空欄位2();
        }

        private void btn新增人員_Click(object sender, EventArgs e)
        {
            if ((txt班級.Text != "") && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into member values(@eatName, @item, @price,0);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@eatName", txt班級.Text);
                cmd.Parameters.AddWithValue("@item", txt姓名.Text);
                cmd.Parameters.AddWithValue("@price", txt電話.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows.ToString() + "筆資料新增成功");
                值日生介面();
                快速填入班級();
                班級選擇();
                txt姓名.Text = "";
                txt電話.Text = "";
            }
            else
            {
                MessageBox.Show("請填入所有欄位");
            }
        }

        private void btn修改人員_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt人員ID新增用.Text, out intID);

            if (intID > 0)
            {
                if ((txt班級.Text != "") && (txt姓名.Text != "") && (txt電話.Text != ""))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update member set class=@NewEatName, name=@NewItem , tel=@newPrice,值日生狀態=0 where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    cmd.Parameters.AddWithValue("@NewEatName", txt班級.Text);
                    cmd.Parameters.AddWithValue("@NewItem", txt姓名.Text);
                    cmd.Parameters.AddWithValue("@newPrice", txt電話.Text);
                    

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(rows.ToString() + "筆資料修改成功");
                    值日生介面();
                    清空欄位2();
                    dataGridView值日生.ClearSelection();
                }
                else
                {
                    MessageBox.Show("請填入所有欄位");
                }
            }
        }

        private void btn刪除人員_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt人員ID新增用.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from member where id =@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show(rows.ToString() + "筆資料刪除成功");
                值日生介面();
                清空欄位2();
                dataGridView值日生.ClearSelection();
            }
        }

        private void btn填入班級_Click(object sender, EventArgs e)
        {
            txt班級.Text = cbox填入班級.SelectedItem.ToString();
        }

        private void Restart()
        {
            System.Threading.Thread thtmp = new System.Threading.Thread(new
            System.Threading.ParameterizedThreadStart(run));

            object appName = Application.ExecutablePath;
            System.Threading.Thread.Sleep(500);
            thtmp.Start(appName);
            
        }

        private void run(Object obj)
        {
            MessageBox.Show("後台已更新完成，重新載入表單");
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }

        private void admin_manage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Restart();
        }

        private void btn顯示選擇餐廳_Click(object sender, EventArgs e)
        {
            產生菜單();
            dataGridView菜單.ClearSelection();
        }

        private void btn顯示所有班級_Click(object sender, EventArgs e)
        {
            值日生介面();
            dataGridView值日生.ClearSelection();
        }

        private void btn顯示選擇班級_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from member where class = @NewEatName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewEatName", cbox班級選擇.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介
                dt.Load(reader);
                dataGridView值日生.DataSource = dt;
            }
            reader.Close();
            con.Close();
            dataGridView值日生.ClearSelection();
        }
    }
}
