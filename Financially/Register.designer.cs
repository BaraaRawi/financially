namespace Test_3
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.username = new System.Windows.Forms.TextBox();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.maximize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.titleholder = new System.Windows.Forms.PictureBox();
            this.titlebar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.moveform = new System.Windows.Forms.Timer(this.components);
            this.savings = new System.Windows.Forms.TextBox();
            this.income = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleholder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(440, 157);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(150, 25);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // confirmpass
            // 
            this.confirmpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmpass.BackColor = System.Drawing.SystemColors.Control;
            this.confirmpass.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.confirmpass.ForeColor = System.Drawing.Color.Gray;
            this.confirmpass.Location = new System.Drawing.Point(440, 243);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(150, 25);
            this.confirmpass.TabIndex = 4;
            this.confirmpass.Text = "Confirm Password";
            this.confirmpass.Enter += new System.EventHandler(this.confirmpass_Enter);
            this.confirmpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmpass_KeyDown);
            this.confirmpass.Leave += new System.EventHandler(this.confirmpass_Leave);
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.BackColor = System.Drawing.SystemColors.Control;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.pass.ForeColor = System.Drawing.Color.Gray;
            this.pass.Location = new System.Drawing.Point(440, 200);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(150, 25);
            this.pass.TabIndex = 3;
            this.pass.Text = "Password";
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // signup
            // 
            this.signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.signup.FlatAppearance.BorderSize = 0;
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(410, 398);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(180, 36);
            this.signup.TabIndex = 7;
            this.signup.Text = "Register";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            this.signup.MouseEnter += new System.EventHandler(this.signup_MouseEnter);
            this.signup.MouseLeave += new System.EventHandler(this.signup_MouseLeave);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(58, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(181, 39);
            this.title.TabIndex = 1;
            this.title.Text = "Financially";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.pictureBox1.Image = global::Test_3.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(25, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.Image = global::Test_3.Properties.Resources.padlock;
            this.pictureBox7.Location = new System.Drawing.Point(410, 243);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.Image = global::Test_3.Properties.Resources.padlock;
            this.pictureBox8.Location = new System.Drawing.Point(410, 200);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Image = global::Test_3.Properties.Resources.user_3;
            this.pictureBox6.Location = new System.Drawing.Point(410, 157);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.minimize.Image = global::Test_3.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(895, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(35, 30);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimize.TabIndex = 4;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.pictureBox5_Click);
            this.minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimize_MouseDown);
            this.minimize.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.maximize.Image = global::Test_3.Properties.Resources.maximize1;
            this.maximize.Location = new System.Drawing.Point(930, 0);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(35, 30);
            this.maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.maximize.TabIndex = 3;
            this.maximize.TabStop = false;
            this.maximize.Click += new System.EventHandler(this.pictureBox4_Click);
            this.maximize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.maximize_MouseDown);
            this.maximize.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.maximize.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.exit.Image = global::Test_3.Properties.Resources.cross3;
            this.exit.Location = new System.Drawing.Point(965, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(35, 30);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exit_MouseDown);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // titleholder
            // 
            this.titleholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.titleholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleholder.Location = new System.Drawing.Point(0, 30);
            this.titleholder.Name = "titleholder";
            this.titleholder.Size = new System.Drawing.Size(1000, 50);
            this.titleholder.TabIndex = 1;
            this.titleholder.TabStop = false;
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1000, 30);
            this.titlebar.TabIndex = 0;
            this.titlebar.TabStop = false;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.titlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(410, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Already have an account? login!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moveform
            // 
            this.moveform.Interval = 1;
            this.moveform.Tick += new System.EventHandler(this.moveform_Tick);
            // 
            // savings
            // 
            this.savings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savings.BackColor = System.Drawing.SystemColors.Control;
            this.savings.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.savings.ForeColor = System.Drawing.Color.Gray;
            this.savings.Location = new System.Drawing.Point(440, 330);
            this.savings.Name = "savings";
            this.savings.Size = new System.Drawing.Size(150, 25);
            this.savings.TabIndex = 6;
            this.savings.Text = "Savings";
            this.savings.Enter += new System.EventHandler(this.savings_Enter);
            this.savings.Leave += new System.EventHandler(this.savings_Leave);
            // 
            // income
            // 
            this.income.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.income.BackColor = System.Drawing.SystemColors.Control;
            this.income.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.income.ForeColor = System.Drawing.Color.Gray;
            this.income.Location = new System.Drawing.Point(440, 286);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(150, 25);
            this.income.TabIndex = 5;
            this.income.Text = "Income";
            this.income.Enter += new System.EventHandler(this.income_Enter);
            this.income.Leave += new System.EventHandler(this.income_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(409, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(409, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // picker
            // 
            this.picker.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.picker.Location = new System.Drawing.Point(440, 367);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(150, 25);
            this.picker.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::Test_3.Properties.Resources.get_money;
            this.pictureBox4.Location = new System.Drawing.Point(410, 367);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 530);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picker);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.income);
            this.Controls.Add(this.savings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.maximize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.titleholder);
            this.Controls.Add(this.titlebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Manager";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleholder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titlebar;
        private System.Windows.Forms.PictureBox titleholder;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox maximize;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer moveform;
        private System.Windows.Forms.TextBox savings;
        private System.Windows.Forms.TextBox income;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker picker;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
