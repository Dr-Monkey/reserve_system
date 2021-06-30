
namespace WindowsFormsApp3
{
    partial class admin_manage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn顯示選擇餐廳 = new System.Windows.Forms.Button();
            this.btn顯示所有餐廳 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_restaurantChoose = new System.Windows.Forms.ComboBox();
            this.dataGridView菜單 = new System.Windows.Forms.DataGridView();
            this.txt餐點ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt餐廳名稱 = new System.Windows.Forms.TextBox();
            this.txt餐點項目 = new System.Windows.Forms.TextBox();
            this.txt餐點價錢 = new System.Windows.Forms.TextBox();
            this.btn刪除餐點 = new System.Windows.Forms.Button();
            this.btn修改餐點 = new System.Windows.Forms.Button();
            this.btn新增餐點 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbox_restaurant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView值日生 = new System.Windows.Forms.DataGridView();
            this.txt指定值日生ID = new System.Windows.Forms.TextBox();
            this.btn取消值日生 = new System.Windows.Forms.Button();
            this.btn指定值日生 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt班級 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.btn新增人員 = new System.Windows.Forms.Button();
            this.btn刪除人員 = new System.Windows.Forms.Button();
            this.btn修改人員 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt人員ID新增用 = new System.Windows.Forms.TextBox();
            this.btn清空欄位2 = new System.Windows.Forms.Button();
            this.btn填入班級 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbox填入班級 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn顯示選擇班級 = new System.Windows.Forms.Button();
            this.btn顯示所有班級 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbox班級選擇 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView菜單)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView值日生)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn顯示選擇餐廳);
            this.groupBox1.Controls.Add(this.btn顯示所有餐廳);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbox_restaurantChoose);
            this.groupBox1.Controls.Add(this.dataGridView菜單);
            this.groupBox1.Location = new System.Drawing.Point(34, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(469, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餐廳";
            // 
            // btn顯示選擇餐廳
            // 
            this.btn顯示選擇餐廳.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn顯示選擇餐廳.Location = new System.Drawing.Point(174, 60);
            this.btn顯示選擇餐廳.Name = "btn顯示選擇餐廳";
            this.btn顯示選擇餐廳.Size = new System.Drawing.Size(117, 28);
            this.btn顯示選擇餐廳.TabIndex = 55;
            this.btn顯示選擇餐廳.Text = "顯示選擇餐廳";
            this.btn顯示選擇餐廳.UseVisualStyleBackColor = false;
            this.btn顯示選擇餐廳.Click += new System.EventHandler(this.btn顯示選擇餐廳_Click);
            // 
            // btn顯示所有餐廳
            // 
            this.btn顯示所有餐廳.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn顯示所有餐廳.Location = new System.Drawing.Point(311, 60);
            this.btn顯示所有餐廳.Name = "btn顯示所有餐廳";
            this.btn顯示所有餐廳.Size = new System.Drawing.Size(124, 28);
            this.btn顯示所有餐廳.TabIndex = 30;
            this.btn顯示所有餐廳.Text = "顯示所有餐廳";
            this.btn顯示所有餐廳.UseVisualStyleBackColor = false;
            this.btn顯示所有餐廳.Click += new System.EventHandler(this.btn顯示所有餐廳_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "餐廳選擇";
            // 
            // cbox_restaurantChoose
            // 
            this.cbox_restaurantChoose.FormattingEnabled = true;
            this.cbox_restaurantChoose.Location = new System.Drawing.Point(12, 61);
            this.cbox_restaurantChoose.Name = "cbox_restaurantChoose";
            this.cbox_restaurantChoose.Size = new System.Drawing.Size(137, 28);
            this.cbox_restaurantChoose.TabIndex = 34;
            this.cbox_restaurantChoose.SelectedIndexChanged += new System.EventHandler(this.cbox_restaurantChoose_SelectedIndexChanged);
            // 
            // dataGridView菜單
            // 
            this.dataGridView菜單.AllowUserToAddRows = false;
            this.dataGridView菜單.AllowUserToResizeColumns = false;
            this.dataGridView菜單.AllowUserToResizeRows = false;
            this.dataGridView菜單.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView菜單.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView菜單.Location = new System.Drawing.Point(10, 107);
            this.dataGridView菜單.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView菜單.Name = "dataGridView菜單";
            this.dataGridView菜單.RowHeadersVisible = false;
            this.dataGridView菜單.RowHeadersWidth = 102;
            this.dataGridView菜單.RowTemplate.Height = 24;
            this.dataGridView菜單.Size = new System.Drawing.Size(425, 291);
            this.dataGridView菜單.TabIndex = 1;
            this.dataGridView菜單.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView菜單_CellClick);
            // 
            // txt餐點ID
            // 
            this.txt餐點ID.Enabled = false;
            this.txt餐點ID.Location = new System.Drawing.Point(130, 120);
            this.txt餐點ID.Margin = new System.Windows.Forms.Padding(5);
            this.txt餐點ID.Name = "txt餐點ID";
            this.txt餐點ID.Size = new System.Drawing.Size(153, 29);
            this.txt餐點ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "餐點項目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "餐廳名稱";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "餐點ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "餐點價錢";
            // 
            // txt餐廳名稱
            // 
            this.txt餐廳名稱.Location = new System.Drawing.Point(130, 159);
            this.txt餐廳名稱.Margin = new System.Windows.Forms.Padding(5);
            this.txt餐廳名稱.Name = "txt餐廳名稱";
            this.txt餐廳名稱.Size = new System.Drawing.Size(153, 29);
            this.txt餐廳名稱.TabIndex = 23;
            // 
            // txt餐點項目
            // 
            this.txt餐點項目.Location = new System.Drawing.Point(130, 199);
            this.txt餐點項目.Margin = new System.Windows.Forms.Padding(5);
            this.txt餐點項目.Name = "txt餐點項目";
            this.txt餐點項目.Size = new System.Drawing.Size(153, 29);
            this.txt餐點項目.TabIndex = 24;
            // 
            // txt餐點價錢
            // 
            this.txt餐點價錢.Location = new System.Drawing.Point(130, 242);
            this.txt餐點價錢.Margin = new System.Windows.Forms.Padding(5);
            this.txt餐點價錢.Name = "txt餐點價錢";
            this.txt餐點價錢.Size = new System.Drawing.Size(153, 29);
            this.txt餐點價錢.TabIndex = 25;
            // 
            // btn刪除餐點
            // 
            this.btn刪除餐點.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn刪除餐點.Location = new System.Drawing.Point(161, 300);
            this.btn刪除餐點.Name = "btn刪除餐點";
            this.btn刪除餐點.Size = new System.Drawing.Size(124, 35);
            this.btn刪除餐點.TabIndex = 27;
            this.btn刪除餐點.Text = "刪除餐點";
            this.btn刪除餐點.UseVisualStyleBackColor = false;
            this.btn刪除餐點.Click += new System.EventHandler(this.btn刪除餐點_Click);
            // 
            // btn修改餐點
            // 
            this.btn修改餐點.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn修改餐點.Location = new System.Drawing.Point(19, 300);
            this.btn修改餐點.Name = "btn修改餐點";
            this.btn修改餐點.Size = new System.Drawing.Size(123, 35);
            this.btn修改餐點.TabIndex = 26;
            this.btn修改餐點.Text = "修改餐點";
            this.btn修改餐點.UseVisualStyleBackColor = false;
            this.btn修改餐點.Click += new System.EventHandler(this.btn修改餐點_Click);
            // 
            // btn新增餐點
            // 
            this.btn新增餐點.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn新增餐點.Location = new System.Drawing.Point(161, 354);
            this.btn新增餐點.Name = "btn新增餐點";
            this.btn新增餐點.Size = new System.Drawing.Size(124, 35);
            this.btn新增餐點.TabIndex = 28;
            this.btn新增餐點.Text = "新增餐點";
            this.btn新增餐點.UseVisualStyleBackColor = false;
            this.btn新增餐點.Click += new System.EventHandler(this.btn新增餐點_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn清空欄位.Location = new System.Drawing.Point(19, 354);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(123, 35);
            this.btn清空欄位.TabIndex = 29;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn清空欄位);
            this.groupBox2.Controls.Add(this.btn新增餐點);
            this.groupBox2.Controls.Add(this.btn刪除餐點);
            this.groupBox2.Controls.Add(this.txt餐點ID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt餐廳名稱);
            this.groupBox2.Controls.Add(this.txt餐點項目);
            this.groupBox2.Controls.Add(this.txt餐點價錢);
            this.groupBox2.Controls.Add(this.btn修改餐點);
            this.groupBox2.Controls.Add(this.cbox_restaurant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(511, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 451);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新增餐點";
            // 
            // cbox_restaurant
            // 
            this.cbox_restaurant.FormattingEnabled = true;
            this.cbox_restaurant.Location = new System.Drawing.Point(19, 75);
            this.cbox_restaurant.Name = "cbox_restaurant";
            this.cbox_restaurant.Size = new System.Drawing.Size(163, 28);
            this.cbox_restaurant.TabIndex = 31;
            this.cbox_restaurant.SelectedIndexChanged += new System.EventHandler(this.cbox_restaurant_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "快速填入餐廳名稱";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "填入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView值日生
            // 
            this.dataGridView值日生.AllowUserToAddRows = false;
            this.dataGridView值日生.AllowUserToResizeColumns = false;
            this.dataGridView值日生.AllowUserToResizeRows = false;
            this.dataGridView值日生.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView值日生.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView值日生.Location = new System.Drawing.Point(10, 107);
            this.dataGridView值日生.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView值日生.Name = "dataGridView值日生";
            this.dataGridView值日生.ReadOnly = true;
            this.dataGridView值日生.RowHeadersVisible = false;
            this.dataGridView值日生.RowHeadersWidth = 102;
            this.dataGridView值日生.RowTemplate.Height = 24;
            this.dataGridView值日生.Size = new System.Drawing.Size(357, 291);
            this.dataGridView值日生.TabIndex = 36;
            this.dataGridView值日生.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView值日生_CellClick);
            // 
            // txt指定值日生ID
            // 
            this.txt指定值日生ID.Enabled = false;
            this.txt指定值日生ID.Location = new System.Drawing.Point(77, 410);
            this.txt指定值日生ID.Margin = new System.Windows.Forms.Padding(5);
            this.txt指定值日生ID.Name = "txt指定值日生ID";
            this.txt指定值日生ID.Size = new System.Drawing.Size(40, 29);
            this.txt指定值日生ID.TabIndex = 37;
            // 
            // btn取消值日生
            // 
            this.btn取消值日生.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn取消值日生.Location = new System.Drawing.Point(231, 406);
            this.btn取消值日生.Name = "btn取消值日生";
            this.btn取消值日生.Size = new System.Drawing.Size(101, 35);
            this.btn取消值日生.TabIndex = 39;
            this.btn取消值日生.Text = "取消值日生";
            this.btn取消值日生.UseVisualStyleBackColor = false;
            this.btn取消值日生.Click += new System.EventHandler(this.btn取消值日生_Click);
            // 
            // btn指定值日生
            // 
            this.btn指定值日生.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn指定值日生.Location = new System.Drawing.Point(125, 406);
            this.btn指定值日生.Name = "btn指定值日生";
            this.btn指定值日生.Size = new System.Drawing.Size(100, 35);
            this.btn指定值日生.TabIndex = 38;
            this.btn指定值日生.Text = "指定值日生";
            this.btn指定值日生.UseVisualStyleBackColor = false;
            this.btn指定值日生.Click += new System.EventHandler(this.btn指定值日生_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "電話";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "班級";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "姓名";
            // 
            // txt班級
            // 
            this.txt班級.Location = new System.Drawing.Point(97, 159);
            this.txt班級.Margin = new System.Windows.Forms.Padding(5);
            this.txt班級.Name = "txt班級";
            this.txt班級.Size = new System.Drawing.Size(111, 29);
            this.txt班級.TabIndex = 44;
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(97, 199);
            this.txt姓名.Margin = new System.Windows.Forms.Padding(5);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(111, 29);
            this.txt姓名.TabIndex = 45;
            // 
            // txt電話
            // 
            this.txt電話.Location = new System.Drawing.Point(97, 242);
            this.txt電話.Margin = new System.Windows.Forms.Padding(5);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(111, 29);
            this.txt電話.TabIndex = 46;
            // 
            // btn新增人員
            // 
            this.btn新增人員.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn新增人員.Location = new System.Drawing.Point(136, 355);
            this.btn新增人員.Name = "btn新增人員";
            this.btn新增人員.Size = new System.Drawing.Size(93, 33);
            this.btn新增人員.TabIndex = 47;
            this.btn新增人員.Text = "新增人員";
            this.btn新增人員.UseVisualStyleBackColor = false;
            this.btn新增人員.Click += new System.EventHandler(this.btn新增人員_Click);
            // 
            // btn刪除人員
            // 
            this.btn刪除人員.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn刪除人員.Location = new System.Drawing.Point(136, 300);
            this.btn刪除人員.Name = "btn刪除人員";
            this.btn刪除人員.Size = new System.Drawing.Size(93, 35);
            this.btn刪除人員.TabIndex = 49;
            this.btn刪除人員.Text = "刪除人員";
            this.btn刪除人員.UseVisualStyleBackColor = false;
            this.btn刪除人員.Click += new System.EventHandler(this.btn刪除人員_Click);
            // 
            // btn修改人員
            // 
            this.btn修改人員.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn修改人員.Location = new System.Drawing.Point(31, 300);
            this.btn修改人員.Name = "btn修改人員";
            this.btn修改人員.Size = new System.Drawing.Size(93, 35);
            this.btn修改人員.TabIndex = 48;
            this.btn修改人員.Text = "修改人員";
            this.btn修改人員.UseVisualStyleBackColor = false;
            this.btn修改人員.Click += new System.EventHandler(this.btn修改人員_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "人員ID";
            // 
            // txt人員ID新增用
            // 
            this.txt人員ID新增用.Enabled = false;
            this.txt人員ID新增用.Location = new System.Drawing.Point(97, 120);
            this.txt人員ID新增用.Margin = new System.Windows.Forms.Padding(5);
            this.txt人員ID新增用.Name = "txt人員ID新增用";
            this.txt人員ID新增用.Size = new System.Drawing.Size(111, 29);
            this.txt人員ID新增用.TabIndex = 50;
            // 
            // btn清空欄位2
            // 
            this.btn清空欄位2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn清空欄位2.Location = new System.Drawing.Point(31, 355);
            this.btn清空欄位2.Name = "btn清空欄位2";
            this.btn清空欄位2.Size = new System.Drawing.Size(93, 33);
            this.btn清空欄位2.TabIndex = 30;
            this.btn清空欄位2.Text = "清空欄位";
            this.btn清空欄位2.UseVisualStyleBackColor = false;
            this.btn清空欄位2.Click += new System.EventHandler(this.btn清空欄位2_Click);
            // 
            // btn填入班級
            // 
            this.btn填入班級.Location = new System.Drawing.Point(158, 60);
            this.btn填入班級.Name = "btn填入班級";
            this.btn填入班級.Size = new System.Drawing.Size(75, 34);
            this.btn填入班級.TabIndex = 54;
            this.btn填入班級.Text = "填入";
            this.btn填入班級.UseVisualStyleBackColor = true;
            this.btn填入班級.Click += new System.EventHandler(this.btn填入班級_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "快速填入班級名稱";
            // 
            // cbox填入班級
            // 
            this.cbox填入班級.FormattingEnabled = true;
            this.cbox填入班級.Location = new System.Drawing.Point(29, 64);
            this.cbox填入班級.Name = "cbox填入班級";
            this.cbox填入班級.Size = new System.Drawing.Size(115, 28);
            this.cbox填入班級.TabIndex = 52;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn顯示選擇班級);
            this.groupBox3.Controls.Add(this.dataGridView值日生);
            this.groupBox3.Controls.Add(this.btn顯示所有班級);
            this.groupBox3.Controls.Add(this.txt指定值日生ID);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cbox班級選擇);
            this.groupBox3.Controls.Add(this.btn指定值日生);
            this.groupBox3.Controls.Add(this.btn取消值日生);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(810, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(383, 451);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "人員";
            // 
            // btn顯示選擇班級
            // 
            this.btn顯示選擇班級.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn顯示選擇班級.Location = new System.Drawing.Point(109, 63);
            this.btn顯示選擇班級.Name = "btn顯示選擇班級";
            this.btn顯示選擇班級.Size = new System.Drawing.Size(117, 28);
            this.btn顯示選擇班級.TabIndex = 59;
            this.btn顯示選擇班級.Text = "顯示選擇班級";
            this.btn顯示選擇班級.UseVisualStyleBackColor = false;
            this.btn顯示選擇班級.Click += new System.EventHandler(this.btn顯示選擇班級_Click);
            // 
            // btn顯示所有班級
            // 
            this.btn顯示所有班級.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn顯示所有班級.Location = new System.Drawing.Point(243, 63);
            this.btn顯示所有班級.Name = "btn顯示所有班級";
            this.btn顯示所有班級.Size = new System.Drawing.Size(124, 28);
            this.btn顯示所有班級.TabIndex = 56;
            this.btn顯示所有班級.Text = "顯示所有班級";
            this.btn顯示所有班級.UseVisualStyleBackColor = false;
            this.btn顯示所有班級.Click += new System.EventHandler(this.btn顯示所有班級_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 58;
            this.label13.Text = "班級選擇";
            // 
            // cbox班級選擇
            // 
            this.cbox班級選擇.FormattingEnabled = true;
            this.cbox班級選擇.Location = new System.Drawing.Point(10, 63);
            this.cbox班級選擇.Name = "cbox班級選擇";
            this.cbox班級選擇.Size = new System.Drawing.Size(93, 28);
            this.cbox班級選擇.TabIndex = 57;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn清空欄位2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btn填入班級);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbox填入班級);
            this.groupBox4.Controls.Add(this.txt班級);
            this.groupBox4.Controls.Add(this.txt姓名);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt電話);
            this.groupBox4.Controls.Add(this.txt人員ID新增用);
            this.groupBox4.Controls.Add(this.btn新增人員);
            this.groupBox4.Controls.Add(this.btn刪除人員);
            this.groupBox4.Controls.Add(this.btn修改人員);
            this.groupBox4.Location = new System.Drawing.Point(1201, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 451);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "新增人員";
            // 
            // admin_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 477);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "admin_manage";
            this.Text = "後台管理系統";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.admin_manage_FormClosed);
            this.Load += new System.EventHandler(this.admin_manage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView菜單)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView值日生)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView菜單;
        private System.Windows.Forms.TextBox txt餐點ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt餐廳名稱;
        private System.Windows.Forms.TextBox txt餐點項目;
        private System.Windows.Forms.TextBox txt餐點價錢;
        private System.Windows.Forms.Button btn刪除餐點;
        private System.Windows.Forms.Button btn修改餐點;
        private System.Windows.Forms.Button btn新增餐點;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_restaurant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_restaurantChoose;
        private System.Windows.Forms.Button btn顯示所有餐廳;
        private System.Windows.Forms.DataGridView dataGridView值日生;
        private System.Windows.Forms.TextBox txt指定值日生ID;
        private System.Windows.Forms.Button btn取消值日生;
        private System.Windows.Forms.Button btn指定值日生;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt班級;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.Button btn新增人員;
        private System.Windows.Forms.Button btn刪除人員;
        private System.Windows.Forms.Button btn修改人員;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt人員ID新增用;
        private System.Windows.Forms.Button btn清空欄位2;
        private System.Windows.Forms.Button btn填入班級;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbox填入班級;
        private System.Windows.Forms.Button btn顯示選擇餐廳;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn顯示選擇班級;
        private System.Windows.Forms.Button btn顯示所有班級;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbox班級選擇;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}