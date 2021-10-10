
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(77, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(67, 20);
            this.id.TabIndex = 5;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(77, 42);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(67, 20);
            this.fname.TabIndex = 6;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(224, 42);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(67, 20);
            this.lname.TabIndex = 7;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender.Location = new System.Drawing.Point(77, 70);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(67, 21);
            this.gender.TabIndex = 8;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(224, 71);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(67, 20);
            this.age.TabIndex = 9;
            // 
            // cellphone
            // 
            this.cellphone.Location = new System.Drawing.Point(76, 102);
            this.cellphone.Name = "cellphone";
            this.cellphone.Size = new System.Drawing.Size(67, 20);
            this.cellphone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cell Phone";
            // 
            // nationality
            // 
            this.nationality.Location = new System.Drawing.Point(224, 102);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(67, 20);
            this.nationality.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nationality";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(77, 138);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 20);
            this.dob.TabIndex = 14;
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date of Birth";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(15, 193);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 16;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(111, 193);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 17;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(224, 193);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(332, 193);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 19;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

