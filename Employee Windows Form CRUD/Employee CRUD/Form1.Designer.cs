
namespace Employee_CRUD
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.cellphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nationality = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.datagridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(103, 11);
            this.id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(88, 22);
            this.id.TabIndex = 5;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(103, 52);
            this.fname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(88, 22);
            this.fname.TabIndex = 6;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(299, 52);
            this.lname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(88, 22);
            this.lname.TabIndex = 7;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender.Location = new System.Drawing.Point(103, 86);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(88, 24);
            this.gender.TabIndex = 8;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(299, 87);
            this.age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(88, 22);
            this.age.TabIndex = 9;
            // 
            // cellphone
            // 
            this.cellphone.Location = new System.Drawing.Point(101, 126);
            this.cellphone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cellphone.Name = "cellphone";
            this.cellphone.Size = new System.Drawing.Size(88, 22);
            this.cellphone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cell Phone";
            // 
            // nationality
            // 
            this.nationality.Location = new System.Drawing.Point(299, 126);
            this.nationality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(88, 22);
            this.nationality.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nationality";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(103, 170);
            this.dob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(265, 22);
            this.dob.TabIndex = 14;
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date of Birth";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(20, 238);
            this.insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(100, 28);
            this.insert.TabIndex = 16;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(148, 238);
            this.update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 28);
            this.update.TabIndex = 17;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(299, 238);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 28);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(443, 238);
            this.read.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(100, 28);
            this.read.TabIndex = 19;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.button4_Click);
            // 
            // datagridview
            // 
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(20, 297);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(523, 150);
            this.datagridview.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.read);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cellphone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox cellphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nationality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.DataGridView datagridview;
    }
}

