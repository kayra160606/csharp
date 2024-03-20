namespace Unit4
{
    partial class Unit4_5
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
            txtsalary = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            btnLast = new Button();
            btnnext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            txtdesignation = new TextBox();
            txtbirthdate = new TextBox();
            txtEmpname = new TextBox();
            txtEmpno = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(249, 151);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(185, 23);
            txtsalary.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(173, 147);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 26;
            label6.Text = "Salary:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(55, 356);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(409, 86);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action Buttons";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(306, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(214, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(116, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnnext);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(55, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 77);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Navigation Buttons";
            // 
            // btnLast
            // 
            btnLast.Location = new Point(295, 29);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(49, 31);
            btnLast.TabIndex = 3;
            btnLast.Text = ">I";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(214, 29);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(49, 31);
            btnnext.TabIndex = 2;
            btnnext.Text = ">";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(133, 29);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(49, 31);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(52, 29);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(49, 31);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "I<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // txtdesignation
            // 
            txtdesignation.Location = new Point(247, 211);
            txtdesignation.Name = "txtdesignation";
            txtdesignation.Size = new Size(187, 23);
            txtdesignation.TabIndex = 23;
            // 
            // txtbirthdate
            // 
            txtbirthdate.Location = new Point(247, 181);
            txtbirthdate.Name = "txtbirthdate";
            txtbirthdate.Size = new Size(187, 23);
            txtbirthdate.TabIndex = 22;
            // 
            // txtEmpname
            // 
            txtEmpname.Location = new Point(247, 121);
            txtEmpname.Name = "txtEmpname";
            txtEmpname.Size = new Size(189, 23);
            txtEmpname.TabIndex = 21;
            // 
            // txtEmpno
            // 
            txtEmpno.Location = new Point(247, 92);
            txtEmpno.Name = "txtEmpno";
            txtEmpno.Size = new Size(100, 23);
            txtEmpno.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(121, 207);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 19;
            label5.Text = "Designation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(143, 178);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 18;
            label4.Text = "Birthdate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(88, 118);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 17;
            label3.Text = "Employee Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 89);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 16;
            label2.Text = "Employee Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(135, 39);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 15;
            label1.Text = "Employee Data Entry Form";
            // 
            // Unit4_5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 481);
            Controls.Add(txtsalary);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtdesignation);
            Controls.Add(txtbirthdate);
            Controls.Add(txtEmpname);
            Controls.Add(txtEmpno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Unit4_5";
            Text = "Unit4_5";
            Load += Unit4_5_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsalary;
        private Label label6;
        private GroupBox groupBox2;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Button btnLast;
        private Button btnnext;
        private Button btnPrevious;
        private Button btnFirst;
        private TextBox txtdesignation;
        private TextBox txtbirthdate;
        private TextBox txtEmpname;
        private TextBox txtEmpno;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}