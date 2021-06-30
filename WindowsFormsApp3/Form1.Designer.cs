
namespace WindowsFormsApp3
{
    partial class login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbox值日生 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn開啟訂購單 = new System.Windows.Forms.Button();
            this.chk值日生 = new System.Windows.Forms.CheckBox();
            this.btn後台 = new System.Windows.Forms.Button();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.cbox_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_class = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn顯示選擇餐廳 = new System.Windows.Forms.Button();
            this.btn顯示所有餐廳 = new System.Windows.Forms.Button();
            this.lbl餐廳名 = new System.Windows.Forms.Label();
            this.lbl價錢 = new System.Windows.Forms.Label();
            this.lbl品項 = new System.Windows.Forms.Label();
            this.btn加入訂單列 = new System.Windows.Forms.Button();
            this.dataGridView菜單 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_restaurant = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt刪除品項 = new System.Windows.Forms.TextBox();
            this.dataGridView訂單列表 = new System.Windows.Forms.DataGridView();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.btn刪除品項 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView菜單)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView訂單列表)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbox值日生);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn開啟訂購單);
            this.groupBox1.Controls.Add(this.chk值日生);
            this.groupBox1.Controls.Add(this.btn後台);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.cbox_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbox_class);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(198, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂購人資訊";
            // 
            // lbox值日生
            // 
            this.lbox值日生.FormattingEnabled = true;
            this.lbox值日生.ItemHeight = 20;
            this.lbox值日生.Location = new System.Drawing.Point(23, 339);
            this.lbox值日生.Name = "lbox值日生";
            this.lbox值日生.Size = new System.Drawing.Size(152, 64);
            this.lbox值日生.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "今日值日生";
            // 
            // btn開啟訂購單
            // 
            this.btn開啟訂購單.Location = new System.Drawing.Point(43, 243);
            this.btn開啟訂購單.Name = "btn開啟訂購單";
            this.btn開啟訂購單.Size = new System.Drawing.Size(113, 46);
            this.btn開啟訂購單.TabIndex = 9;
            this.btn開啟訂購單.Text = "開啟訂購單";
            this.btn開啟訂購單.UseVisualStyleBackColor = true;
            this.btn開啟訂購單.Visible = false;
            this.btn開啟訂購單.Click += new System.EventHandler(this.btn開啟訂購單_Click);
            // 
            // chk值日生
            // 
            this.chk值日生.AutoSize = true;
            this.chk值日生.Enabled = false;
            this.chk值日生.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk值日生.ForeColor = System.Drawing.Color.Blue;
            this.chk值日生.Location = new System.Drawing.Point(43, 199);
            this.chk值日生.Name = "chk值日生";
            this.chk值日生.Size = new System.Drawing.Size(115, 38);
            this.chk值日生.TabIndex = 8;
            this.chk值日生.Text = "值日生";
            this.chk值日生.UseVisualStyleBackColor = true;
            // 
            // btn後台
            // 
            this.btn後台.Location = new System.Drawing.Point(41, 423);
            this.btn後台.Name = "btn後台";
            this.btn後台.Size = new System.Drawing.Size(113, 46);
            this.btn後台.TabIndex = 6;
            this.btn後台.Text = "後台登入";
            this.btn後台.UseVisualStyleBackColor = true;
            this.btn後台.Click += new System.EventHandler(this.btn後台_Click);
            // 
            // txt_tel
            // 
            this.txt_tel.Enabled = false;
            this.txt_tel.Location = new System.Drawing.Point(58, 149);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(116, 29);
            this.txt_tel.TabIndex = 5;
            // 
            // cbox_name
            // 
            this.cbox_name.FormattingEnabled = true;
            this.cbox_name.Location = new System.Drawing.Point(58, 96);
            this.cbox_name.Name = "cbox_name";
            this.cbox_name.Size = new System.Drawing.Size(117, 28);
            this.cbox_name.TabIndex = 4;
            this.cbox_name.SelectedIndexChanged += new System.EventHandler(this.cbox_name_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "電話";
            // 
            // cbox_class
            // 
            this.cbox_class.FormattingEnabled = true;
            this.cbox_class.Location = new System.Drawing.Point(58, 42);
            this.cbox_class.Name = "cbox_class";
            this.cbox_class.Size = new System.Drawing.Size(117, 28);
            this.cbox_class.TabIndex = 2;
            this.cbox_class.SelectedIndexChanged += new System.EventHandler(this.cbox_class_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "班級";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn顯示選擇餐廳);
            this.groupBox2.Controls.Add(this.btn顯示所有餐廳);
            this.groupBox2.Controls.Add(this.lbl餐廳名);
            this.groupBox2.Controls.Add(this.lbl價錢);
            this.groupBox2.Controls.Add(this.lbl品項);
            this.groupBox2.Controls.Add(this.btn加入訂單列);
            this.groupBox2.Controls.Add(this.dataGridView菜單);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbox_restaurant);
            this.groupBox2.Location = new System.Drawing.Point(248, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 498);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "餐廳";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "元";
            // 
            // btn顯示選擇餐廳
            // 
            this.btn顯示選擇餐廳.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn顯示選擇餐廳.Location = new System.Drawing.Point(162, 56);
            this.btn顯示選擇餐廳.Name = "btn顯示選擇餐廳";
            this.btn顯示選擇餐廳.Size = new System.Drawing.Size(117, 31);
            this.btn顯示選擇餐廳.TabIndex = 32;
            this.btn顯示選擇餐廳.Text = "顯示選擇餐廳";
            this.btn顯示選擇餐廳.UseVisualStyleBackColor = false;
            this.btn顯示選擇餐廳.Click += new System.EventHandler(this.btn顯示選擇餐廳_Click);
            // 
            // btn顯示所有餐廳
            // 
            this.btn顯示所有餐廳.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn顯示所有餐廳.Location = new System.Drawing.Point(285, 54);
            this.btn顯示所有餐廳.Name = "btn顯示所有餐廳";
            this.btn顯示所有餐廳.Size = new System.Drawing.Size(114, 35);
            this.btn顯示所有餐廳.TabIndex = 31;
            this.btn顯示所有餐廳.Text = "顯示所有餐廳";
            this.btn顯示所有餐廳.UseVisualStyleBackColor = false;
            this.btn顯示所有餐廳.Click += new System.EventHandler(this.btn顯示所有餐廳_Click);
            // 
            // lbl餐廳名
            // 
            this.lbl餐廳名.AutoSize = true;
            this.lbl餐廳名.Location = new System.Drawing.Point(15, 404);
            this.lbl餐廳名.Name = "lbl餐廳名";
            this.lbl餐廳名.Size = new System.Drawing.Size(73, 20);
            this.lbl餐廳名.TabIndex = 7;
            this.lbl餐廳名.Text = "餐廳名稱";
            // 
            // lbl價錢
            // 
            this.lbl價錢.AutoSize = true;
            this.lbl價錢.Location = new System.Drawing.Point(198, 433);
            this.lbl價錢.Name = "lbl價錢";
            this.lbl價錢.Size = new System.Drawing.Size(41, 20);
            this.lbl價錢.TabIndex = 6;
            this.lbl價錢.Text = "價錢";
            // 
            // lbl品項
            // 
            this.lbl品項.AutoSize = true;
            this.lbl品項.Location = new System.Drawing.Point(83, 433);
            this.lbl品項.Name = "lbl品項";
            this.lbl品項.Size = new System.Drawing.Size(73, 20);
            this.lbl品項.TabIndex = 5;
            this.lbl品項.Text = "品項名稱";
            // 
            // btn加入訂單列
            // 
            this.btn加入訂單列.Location = new System.Drawing.Point(285, 425);
            this.btn加入訂單列.Name = "btn加入訂單列";
            this.btn加入訂單列.Size = new System.Drawing.Size(123, 37);
            this.btn加入訂單列.TabIndex = 4;
            this.btn加入訂單列.Text = "加入訂單列表";
            this.btn加入訂單列.UseVisualStyleBackColor = true;
            this.btn加入訂單列.Click += new System.EventHandler(this.btn加入訂單列_Click);
            // 
            // dataGridView菜單
            // 
            this.dataGridView菜單.AllowUserToAddRows = false;
            this.dataGridView菜單.AllowUserToResizeColumns = false;
            this.dataGridView菜單.AllowUserToResizeRows = false;
            this.dataGridView菜單.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView菜單.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView菜單.Location = new System.Drawing.Point(17, 115);
            this.dataGridView菜單.Name = "dataGridView菜單";
            this.dataGridView菜單.ReadOnly = true;
            this.dataGridView菜單.RowHeadersVisible = false;
            this.dataGridView菜單.RowHeadersWidth = 102;
            this.dataGridView菜單.RowTemplate.Height = 24;
            this.dataGridView菜單.Size = new System.Drawing.Size(382, 270);
            this.dataGridView菜單.TabIndex = 0;
            this.dataGridView菜單.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView菜單_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "菜單";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "餐廳選擇";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbox_restaurant
            // 
            this.cbox_restaurant.FormattingEnabled = true;
            this.cbox_restaurant.Location = new System.Drawing.Point(17, 58);
            this.cbox_restaurant.Name = "cbox_restaurant";
            this.cbox_restaurant.Size = new System.Drawing.Size(139, 28);
            this.cbox_restaurant.TabIndex = 0;
            this.cbox_restaurant.SelectedIndexChanged += new System.EventHandler(this.cbox_restaurant_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt刪除品項);
            this.groupBox3.Controls.Add(this.dataGridView訂單列表);
            this.groupBox3.Controls.Add(this.lbl總價);
            this.groupBox3.Controls.Add(this.btn刪除品項);
            this.groupBox3.Location = new System.Drawing.Point(669, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 496);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訂單列表";
            // 
            // txt刪除品項
            // 
            this.txt刪除品項.Enabled = false;
            this.txt刪除品項.Location = new System.Drawing.Point(16, 392);
            this.txt刪除品項.Name = "txt刪除品項";
            this.txt刪除品項.Size = new System.Drawing.Size(60, 29);
            this.txt刪除品項.TabIndex = 8;
            // 
            // dataGridView訂單列表
            // 
            this.dataGridView訂單列表.AllowUserToAddRows = false;
            this.dataGridView訂單列表.AllowUserToResizeColumns = false;
            this.dataGridView訂單列表.AllowUserToResizeRows = false;
            this.dataGridView訂單列表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView訂單列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView訂單列表.Location = new System.Drawing.Point(16, 26);
            this.dataGridView訂單列表.Name = "dataGridView訂單列表";
            this.dataGridView訂單列表.ReadOnly = true;
            this.dataGridView訂單列表.RowHeadersVisible = false;
            this.dataGridView訂單列表.RowHeadersWidth = 102;
            this.dataGridView訂單列表.RowTemplate.Height = 24;
            this.dataGridView訂單列表.Size = new System.Drawing.Size(432, 347);
            this.dataGridView訂單列表.TabIndex = 7;
            this.dataGridView訂單列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView訂單列表_CellClick);
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.Location = new System.Drawing.Point(250, 431);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(87, 20);
            this.lbl總價.TabIndex = 7;
            this.lbl總價.Text = "總價XXX元";
            // 
            // btn刪除品項
            // 
            this.btn刪除品項.Location = new System.Drawing.Point(82, 392);
            this.btn刪除品項.Name = "btn刪除品項";
            this.btn刪除品項.Size = new System.Drawing.Size(116, 29);
            this.btn刪除品項.TabIndex = 5;
            this.btn刪除品項.Text = "刪除品項";
            this.btn刪除品項.UseVisualStyleBackColor = true;
            this.btn刪除品項.Click += new System.EventHandler(this.btn刪除品項_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.Text = "訂便當系統";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView菜單)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView訂單列表)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView菜單;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_restaurant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn加入訂單列;
        private System.Windows.Forms.Button btn刪除品項;
        private System.Windows.Forms.Label lbl價錢;
        private System.Windows.Forms.Label lbl品項;
        private System.Windows.Forms.DataGridView dataGridView訂單列表;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Label lbl餐廳名;
        private System.Windows.Forms.Button btn後台;
        private System.Windows.Forms.TextBox txt刪除品項;
        private System.Windows.Forms.CheckBox chk值日生;
        private System.Windows.Forms.Button btn開啟訂購單;
        private System.Windows.Forms.Button btn顯示所有餐廳;
        private System.Windows.Forms.Button btn顯示選擇餐廳;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbox值日生;
        private System.Windows.Forms.Label label7;
    }
}

