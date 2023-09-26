namespace DBTheoryTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtCompanyName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnUpdate = new Button();
            txtMessageText = new RichTextBox();
            BtnCount = new Button();
            dataGridView1 = new DataGridView();
            BtnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(117, 56);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(117, 119);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(100, 23);
            txtCompanyName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 60);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Company Name";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(108, 162);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(118, 23);
            BtnUpdate.TabIndex = 4;
            BtnUpdate.Text = "UpdateDatabase";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // txtMessageText
            // 
            txtMessageText.Enabled = false;
            txtMessageText.Location = new Point(408, 43);
            txtMessageText.Name = "txtMessageText";
            txtMessageText.Size = new Size(358, 99);
            txtMessageText.TabIndex = 5;
            txtMessageText.Text = "";
            // 
            // BtnCount
            // 
            BtnCount.Location = new Point(528, 162);
            BtnCount.Name = "BtnCount";
            BtnCount.Size = new Size(122, 23);
            BtnCount.TabIndex = 6;
            BtnCount.Text = "Count Records";
            BtnCount.UseVisualStyleBackColor = true;
            BtnCount.Click += BtnCount_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(677, 173);
            dataGridView1.TabIndex = 7;
            // 
            // BtnView
            // 
            BtnView.Location = new Point(327, 397);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(118, 23);
            BtnView.TabIndex = 8;
            BtnView.Text = "View Database";
            BtnView.UseVisualStyleBackColor = true;
            BtnView.Click += BtnView_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnView);
            Controls.Add(dataGridView1);
            Controls.Add(BtnCount);
            Controls.Add(txtMessageText);
            Controls.Add(BtnUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCompanyName);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtCompanyName;
        private Label label1;
        private Label label2;
        private Button BtnUpdate;
        private RichTextBox txtMessageText;
        private Button BtnCount;
        private DataGridView dataGridView1;
        private Button BtnView;
    }
}