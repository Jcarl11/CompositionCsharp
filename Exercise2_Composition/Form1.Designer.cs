namespace Exercise2_Composition
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_newrecord = new System.Windows.Forms.Button();
            this.groupbox_gender = new System.Windows.Forms.GroupBox();
            this.radiobtn_male = new System.Windows.Forms.RadioButton();
            this.radiobtn_female = new System.Windows.Forms.RadioButton();
            this.numeric_diastolic = new System.Windows.Forms.NumericUpDown();
            this.numeric_systolic = new System.Windows.Forms.NumericUpDown();
            this.button_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patient_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.doctor_lname = new System.Windows.Forms.TextBox();
            this.doctor_fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupbox_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_diastolic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_systolic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_newrecord);
            this.groupBox1.Controls.Add(this.groupbox_gender);
            this.groupBox1.Controls.Add(this.numeric_diastolic);
            this.groupBox1.Controls.Add(this.numeric_systolic);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.patient_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient info";
            this.groupBox1.Visible = false;
            // 
            // button_newrecord
            // 
            this.button_newrecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_newrecord.FlatAppearance.BorderSize = 0;
            this.button_newrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newrecord.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newrecord.Location = new System.Drawing.Point(104, 242);
            this.button_newrecord.Name = "button_newrecord";
            this.button_newrecord.Size = new System.Drawing.Size(114, 27);
            this.button_newrecord.TabIndex = 12;
            this.button_newrecord.Text = "NEW RECORD";
            this.button_newrecord.UseVisualStyleBackColor = false;
            this.button_newrecord.Click += new System.EventHandler(this.Button_newrecord_Click);
            // 
            // groupbox_gender
            // 
            this.groupbox_gender.Controls.Add(this.radiobtn_male);
            this.groupbox_gender.Controls.Add(this.radiobtn_female);
            this.groupbox_gender.Location = new System.Drawing.Point(10, 165);
            this.groupbox_gender.Name = "groupbox_gender";
            this.groupbox_gender.Size = new System.Drawing.Size(208, 71);
            this.groupbox_gender.TabIndex = 11;
            this.groupbox_gender.TabStop = false;
            this.groupbox_gender.Text = "Gender";
            // 
            // radiobtn_male
            // 
            this.radiobtn_male.AutoSize = true;
            this.radiobtn_male.Location = new System.Drawing.Point(28, 31);
            this.radiobtn_male.Name = "radiobtn_male";
            this.radiobtn_male.Size = new System.Drawing.Size(60, 21);
            this.radiobtn_male.TabIndex = 4;
            this.radiobtn_male.TabStop = true;
            this.radiobtn_male.Text = "Male";
            this.radiobtn_male.UseVisualStyleBackColor = true;
            // 
            // radiobtn_female
            // 
            this.radiobtn_female.AutoSize = true;
            this.radiobtn_female.Location = new System.Drawing.Point(116, 31);
            this.radiobtn_female.Name = "radiobtn_female";
            this.radiobtn_female.Size = new System.Drawing.Size(79, 21);
            this.radiobtn_female.TabIndex = 5;
            this.radiobtn_female.TabStop = true;
            this.radiobtn_female.Text = "Female";
            this.radiobtn_female.UseVisualStyleBackColor = true;
            // 
            // numeric_diastolic
            // 
            this.numeric_diastolic.Location = new System.Drawing.Point(178, 113);
            this.numeric_diastolic.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric_diastolic.Name = "numeric_diastolic";
            this.numeric_diastolic.Size = new System.Drawing.Size(97, 25);
            this.numeric_diastolic.TabIndex = 7;
            // 
            // numeric_systolic
            // 
            this.numeric_systolic.Location = new System.Drawing.Point(13, 113);
            this.numeric_systolic.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric_systolic.Name = "numeric_systolic";
            this.numeric_systolic.Size = new System.Drawing.Size(97, 25);
            this.numeric_systolic.TabIndex = 6;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(10, 242);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(88, 27);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Diastolic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Systolic";
            // 
            // patient_name
            // 
            this.patient_name.Location = new System.Drawing.Point(10, 56);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(208, 25);
            this.patient_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_show.FlatAppearance.BorderSize = 0;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show.Location = new System.Drawing.Point(0, 450);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(399, 44);
            this.button_show.TabIndex = 10;
            this.button_show.Text = "SHOW LIST";
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.Button_show_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.doctor_lname);
            this.groupBox2.Controls.Add(this.doctor_fname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor info";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(393, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // doctor_lname
            // 
            this.doctor_lname.Location = new System.Drawing.Point(178, 52);
            this.doctor_lname.Name = "doctor_lname";
            this.doctor_lname.Size = new System.Drawing.Size(198, 25);
            this.doctor_lname.TabIndex = 2;
            // 
            // doctor_fname
            // 
            this.doctor_fname.Location = new System.Drawing.Point(13, 52);
            this.doctor_fname.Name = "doctor_fname";
            this.doctor_fname.Size = new System.Drawing.Size(133, 25);
            this.doctor_fname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox_gender.ResumeLayout(false);
            this.groupbox_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_diastolic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_systolic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox patient_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox doctor_lname;
        private System.Windows.Forms.TextBox doctor_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiobtn_male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radiobtn_female;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.NumericUpDown numeric_systolic;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.NumericUpDown numeric_diastolic;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupbox_gender;
        private System.Windows.Forms.Button button_newrecord;
        private System.Windows.Forms.Button button2;
    }
}

