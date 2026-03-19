namespace EchoMessenger
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
            title = new Label();
            lstbx = new ListBox();
            btn = new Button();
            txtbx = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            title.ForeColor = Color.DarkBlue;
            title.Location = new Point(30, 21);
            title.Name = "title";
            title.Size = new Size(296, 50);
            title.TabIndex = 0;
            title.Text = "EchoMessenger";
            // 
            // lstbx
            // 
            lstbx.FormattingEnabled = true;
            lstbx.Location = new Point(30, 97);
            lstbx.Name = "lstbx";
            lstbx.Size = new Size(654, 214);
            lstbx.TabIndex = 1;
            // 
            // btn
            // 
            btn.BackColor = SystemColors.ActiveCaption;
            btn.ForeColor = Color.DarkBlue;
            btn.Location = new Point(538, 351);
            btn.Name = "btn";
            btn.Size = new Size(146, 45);
            btn.TabIndex = 2;
            btn.Text = "전송";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // txtbx
            // 
            txtbx.Location = new Point(30, 351);
            txtbx.Multiline = true;
            txtbx.Name = "txtbx";
            txtbx.Size = new Size(500, 45);
            txtbx.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 454);
            Controls.Add(txtbx);
            Controls.Add(btn);
            Controls.Add(lstbx);
            Controls.Add(title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private ListBox lstbx;
        private Button btn;
        private TextBox txtbx;
    }
}
