namespace Unit4
{
    partial class Unit4_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnOk = new Button();
            btnCancle = new Button();
            txtPassword = new TextBox();
            txtUname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(97, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 78);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 112);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(85, 158);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 28);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancle
            // 
            btnCancle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancle.Location = new Point(166, 158);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(75, 30);
            btnCancle.TabIndex = 4;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(137, 109);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(139, 25);
            txtPassword.TabIndex = 2;
            // 
            // txtUname
            // 
            txtUname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtUname.Location = new Point(137, 75);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(139, 25);
            txtUname.TabIndex = 1;
            // 
            // Unit4_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 216);
            Controls.Add(txtUname);
            Controls.Add(txtPassword);
            Controls.Add(btnCancle);
            Controls.Add(btnOk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Unit4_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Unit4_2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOk;
        private Button btnCancle;
        private TextBox txtPassword;
        private TextBox txtUname;
    }
}