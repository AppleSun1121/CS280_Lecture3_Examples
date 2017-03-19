namespace Example03
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.product1Bottom = new System.Windows.Forms.Button();
            this.product2Bottom = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.orderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // product1Bottom
            // 
            this.product1Bottom.Location = new System.Drawing.Point(91, 238);
            this.product1Bottom.Name = "product1Bottom";
            this.product1Bottom.Size = new System.Drawing.Size(278, 164);
            this.product1Bottom.TabIndex = 0;
            this.product1Bottom.Text = "button1";
            this.product1Bottom.UseVisualStyleBackColor = true;
            this.product1Bottom.Click += new System.EventHandler(this.product1Bottom_Click);
            // 
            // product2Bottom
            // 
            this.product2Bottom.Location = new System.Drawing.Point(392, 238);
            this.product2Bottom.Name = "product2Bottom";
            this.product2Bottom.Size = new System.Drawing.Size(278, 164);
            this.product2Bottom.TabIndex = 1;
            this.product2Bottom.Text = "button2";
            this.product2Bottom.UseVisualStyleBackColor = true;
            this.product2Bottom.Click += new System.EventHandler(this.product2Bottom_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("新細明體", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.customerLabel.Location = new System.Drawing.Point(493, 53);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(93, 34);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "label1";
            // 
            // orderRichTextBox
            // 
            this.orderRichTextBox.Location = new System.Drawing.Point(91, 482);
            this.orderRichTextBox.Name = "orderRichTextBox";
            this.orderRichTextBox.Size = new System.Drawing.Size(965, 615);
            this.orderRichTextBox.TabIndex = 3;
            this.orderRichTextBox.Text = "";
            this.orderRichTextBox.TextChanged += new System.EventHandler(this.orderRichTextBox_TextChanged);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(803, 45);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(278, 164);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "button1";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.Location = new System.Drawing.Point(803, 238);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(278, 164);
            this.accountButton.TabIndex = 5;
            this.accountButton.Text = "button1";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // tableComboBox
            // 
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.tableComboBox.Location = new System.Drawing.Point(91, 45);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(278, 38);
            this.tableComboBox.TabIndex = 6;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.tableComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 1137);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.orderRichTextBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.product2Bottom);
            this.Controls.Add(this.product1Bottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button product1Bottom;
        private System.Windows.Forms.Button product2Bottom;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.RichTextBox orderRichTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.ComboBox tableComboBox;
    }
}

