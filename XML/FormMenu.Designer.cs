namespace XML
{
    partial class FormMenu
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
            rbConvert = new RadioButton();
            rbTable = new RadioButton();
            rbDOM = new RadioButton();
            label1 = new Label();
            panelConvert = new Panel();
            btnConvert = new Button();
            tbXML = new RichTextBox();
            tbQuery = new RichTextBox();
            panelXMLTable = new Panel();
            panelXMLDOM = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            treeView1 = new TreeView();
            dataGridView1 = new DataGridView();
            btnXMLTable = new Button();
            txtFilePath = new TextBox();
            label2 = new Label();
            panelConvert.SuspendLayout();
            panelXMLTable.SuspendLayout();
            panelXMLDOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // rbConvert
            // 
            rbConvert.AutoSize = true;
            rbConvert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbConvert.Location = new Point(12, 37);
            rbConvert.Name = "rbConvert";
            rbConvert.Size = new Size(356, 25);
            rbConvert.TabIndex = 0;
            rbConvert.TabStop = true;
            rbConvert.Text = "Chuyển cơ sở dữ liệu quan hệ sang tài liệu XML";
            rbConvert.UseVisualStyleBackColor = true;
            rbConvert.CheckedChanged += rbConvert_CheckedChanged;
            // 
            // rbTable
            // 
            rbTable.AutoSize = true;
            rbTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbTable.Location = new Point(12, 68);
            rbTable.Name = "rbTable";
            rbTable.Size = new Size(279, 25);
            rbTable.TabIndex = 1;
            rbTable.TabStop = true;
            rbTable.Text = "Biểu thị tài liệu XML dưới dạng bảng";
            rbTable.UseVisualStyleBackColor = true;
            rbTable.CheckedChanged += rbTable_CheckedChanged;
            // 
            // rbDOM
            // 
            rbDOM.AutoSize = true;
            rbDOM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbDOM.Location = new Point(12, 99);
            rbDOM.Name = "rbDOM";
            rbDOM.Size = new Size(303, 25);
            rbDOM.TabIndex = 2;
            rbDOM.TabStop = true;
            rbDOM.Text = "Biểu thị tài liệu XML theo mô hình DOM";
            rbDOM.UseVisualStyleBackColor = true;
            rbDOM.CheckedChanged += rbDOM_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(108, 13);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 3;
            label1.Text = "Chọn chức năng";
            // 
            // panelConvert
            // 
            panelConvert.Controls.Add(btnConvert);
            panelConvert.Controls.Add(tbXML);
            panelConvert.Controls.Add(tbQuery);
            panelConvert.Location = new Point(9, 133);
            panelConvert.Name = "panelConvert";
            panelConvert.Size = new Size(779, 357);
            panelConvert.TabIndex = 4;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.Location = new Point(343, 132);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(100, 50);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Chuyển đổi";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // tbXML
            // 
            tbXML.Location = new Point(476, 0);
            tbXML.Name = "tbXML";
            tbXML.Size = new Size(300, 350);
            tbXML.TabIndex = 3;
            tbXML.Text = "";
            // 
            // tbQuery
            // 
            tbQuery.Location = new Point(3, 0);
            tbQuery.Name = "tbQuery";
            tbQuery.Size = new Size(300, 350);
            tbQuery.TabIndex = 2;
            tbQuery.Text = "";
            // 
            // panelXMLTable
            // 
            panelXMLTable.Controls.Add(dataGridView1);
            panelXMLTable.Controls.Add(btnXMLTable);
            panelXMLTable.Controls.Add(txtFilePath);
            panelXMLTable.Controls.Add(label2);
            panelXMLTable.Location = new Point(9, 133);
            panelXMLTable.Name = "panelXMLTable";
            panelXMLTable.Size = new Size(779, 357);
            panelXMLTable.TabIndex = 5;
            // 
            // panelXMLDOM
            // 
            panelXMLDOM.Controls.Add(button1);
            panelXMLDOM.Controls.Add(textBox1);
            panelXMLDOM.Controls.Add(label3);
            panelXMLDOM.Controls.Add(treeView1);
            panelXMLDOM.Location = new Point(9, 130);
            panelXMLDOM.Name = "panelXMLDOM";
            panelXMLDOM.Size = new Size(779, 357);
            panelXMLDOM.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(405, 18);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 5;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(136, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 29);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 21);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 3;
            label3.Text = "Chọn đường dẫn:";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 55);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(468, 295);
            treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(773, 313);
            dataGridView1.TabIndex = 4;
            // 
            // btnXMLTable
            // 
            btnXMLTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXMLTable.Location = new Point(402, 6);
            btnXMLTable.Name = "btnXMLTable";
            btnXMLTable.Size = new Size(75, 30);
            btnXMLTable.TabIndex = 2;
            btnXMLTable.Text = "Browse";
            btnXMLTable.UseVisualStyleBackColor = true;
            btnXMLTable.Click += btnXMLTable_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilePath.Location = new Point(133, 6);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(263, 29);
            txtFilePath.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 0;
            label2.Text = "Chọn đường dẫn:";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 529);
            Controls.Add(panelXMLDOM);
            Controls.Add(panelXMLTable);
            Controls.Add(panelConvert);
            Controls.Add(label1);
            Controls.Add(rbDOM);
            Controls.Add(rbTable);
            Controls.Add(rbConvert);
            Name = "FormMenu";
            Text = "FormMenu";
            panelConvert.ResumeLayout(false);
            panelXMLTable.ResumeLayout(false);
            panelXMLTable.PerformLayout();
            panelXMLDOM.ResumeLayout(false);
            panelXMLDOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbConvert;
        private RadioButton rbTable;
        private RadioButton rbDOM;
        private Label label1;
        private Panel panelConvert;
        private Button btnConvert;
        private RichTextBox tbXML;
        private RichTextBox tbQuery;
        private Panel panelXMLTable;
        private Panel panelXMLDOM;
        private Button btnXMLTable;
        private TextBox txtFilePath;
        private Label label2;
        private DataGridView dataGridView1;
        private TreeView treeView1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
    }
}