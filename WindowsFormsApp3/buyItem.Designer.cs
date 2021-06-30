
namespace WindowsFormsApp3
{
    partial class buyItem
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
            this.lbox訂購列表 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox餐廳選擇 = new System.Windows.Forms.ComboBox();
            this.btn查詢 = new System.Windows.Forms.Button();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.btn儲存檔案 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbox訂購列表
            // 
            this.lbox訂購列表.FormattingEnabled = true;
            this.lbox訂購列表.ItemHeight = 24;
            this.lbox訂購列表.Location = new System.Drawing.Point(36, 38);
            this.lbox訂購列表.Margin = new System.Windows.Forms.Padding(6);
            this.lbox訂購列表.Name = "lbox訂購列表";
            this.lbox訂購列表.Size = new System.Drawing.Size(433, 340);
            this.lbox訂購列表.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "餐廳選擇";
            // 
            // cbox餐廳選擇
            // 
            this.cbox餐廳選擇.FormattingEnabled = true;
            this.cbox餐廳選擇.Location = new System.Drawing.Point(516, 85);
            this.cbox餐廳選擇.Name = "cbox餐廳選擇";
            this.cbox餐廳選擇.Size = new System.Drawing.Size(177, 32);
            this.cbox餐廳選擇.TabIndex = 2;
            // 
            // btn查詢
            // 
            this.btn查詢.Location = new System.Drawing.Point(718, 85);
            this.btn查詢.Name = "btn查詢";
            this.btn查詢.Size = new System.Drawing.Size(81, 32);
            this.btn查詢.TabIndex = 3;
            this.btn查詢.Text = "查詢";
            this.btn查詢.UseVisualStyleBackColor = true;
            this.btn查詢.Click += new System.EventHandler(this.btn查詢_Click);
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.Location = new System.Drawing.Point(699, 157);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(56, 24);
            this.lbl總價.TabIndex = 4;
            this.lbl總價.Text = "xxx元";
            // 
            // btn儲存檔案
            // 
            this.btn儲存檔案.Location = new System.Drawing.Point(520, 249);
            this.btn儲存檔案.Name = "btn儲存檔案";
            this.btn儲存檔案.Size = new System.Drawing.Size(193, 63);
            this.btn儲存檔案.TabIndex = 5;
            this.btn儲存檔案.Text = "儲存檔案";
            this.btn儲存檔案.UseVisualStyleBackColor = true;
            this.btn儲存檔案.Click += new System.EventHandler(this.btn儲存檔案_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "總共";
            // 
            // buyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn儲存檔案);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.btn查詢);
            this.Controls.Add(this.cbox餐廳選擇);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox訂購列表);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "buyItem";
            this.Text = "訂購單列表";
            this.Load += new System.EventHandler(this.buyItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox訂購列表;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox餐廳選擇;
        private System.Windows.Forms.Button btn查詢;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Button btn儲存檔案;
        private System.Windows.Forms.Label label2;
    }
}