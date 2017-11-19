namespace Test_3
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.title = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.moveform = new System.Windows.Forms.Timer(this.components);
            this.income = new System.Windows.Forms.Label();
            this.inclabel = new System.Windows.Forms.Label();
            this.savlabel = new System.Windows.Forms.Label();
            this.savings = new System.Windows.Forms.Label();
            this.selecttype = new System.Windows.Forms.ComboBox();
            this.insertitem = new System.Windows.Forms.Button();
            this.moneyspent = new System.Windows.Forms.TextBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.selectdate = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Label();
            this.viewsbutton = new System.Windows.Forms.Button();
            this.incbase = new System.Windows.Forms.Label();
            this.changeincome = new System.Windows.Forms.Button();
            this.changesavings = new System.Windows.Forms.Button();
            this.incomebox = new System.Windows.Forms.TextBox();
            this.savingsbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.log_in = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.maximize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.titlebar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(58, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(181, 39);
            this.title.TabIndex = 1;
            this.title.Text = "Financially";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Welcome.Location = new System.Drawing.Point(50, 96);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(287, 33);
            this.Welcome.TabIndex = 16;
            this.Welcome.Text = "Welcome, username";
            // 
            // moveform
            // 
            this.moveform.Interval = 1;
            this.moveform.Tick += new System.EventHandler(this.moveform_Tick);
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.income.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.income.Location = new System.Drawing.Point(165, 154);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(116, 33);
            this.income.TabIndex = 17;
            this.income.Text = "income";
            // 
            // inclabel
            // 
            this.inclabel.AutoSize = true;
            this.inclabel.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.inclabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.inclabel.Location = new System.Drawing.Point(50, 154);
            this.inclabel.Name = "inclabel";
            this.inclabel.Size = new System.Drawing.Size(123, 33);
            this.inclabel.TabIndex = 18;
            this.inclabel.Text = "Income:";
            // 
            // savlabel
            // 
            this.savlabel.AutoSize = true;
            this.savlabel.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.savlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.savlabel.Location = new System.Drawing.Point(50, 212);
            this.savlabel.Name = "savlabel";
            this.savlabel.Size = new System.Drawing.Size(120, 33);
            this.savlabel.TabIndex = 19;
            this.savlabel.Text = "Savings:";
            // 
            // savings
            // 
            this.savings.AutoSize = true;
            this.savings.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.savings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.savings.Location = new System.Drawing.Point(165, 212);
            this.savings.Name = "savings";
            this.savings.Size = new System.Drawing.Size(110, 33);
            this.savings.TabIndex = 20;
            this.savings.Text = "savings";
            // 
            // selecttype
            // 
            this.selecttype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.selecttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecttype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selecttype.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.selecttype.ForeColor = System.Drawing.Color.White;
            this.selecttype.FormattingEnabled = true;
            this.selecttype.Items.AddRange(new object[] {
            "water",
            "electricity",
            "shopping",
            "internet",
            "phone",
            "taxes",
            "clothing",
            "restaurants",
            "other"});
            this.selecttype.Location = new System.Drawing.Point(615, 99);
            this.selecttype.Name = "selecttype";
            this.selecttype.Size = new System.Drawing.Size(121, 30);
            this.selecttype.TabIndex = 3;
            this.selecttype.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            // 
            // insertitem
            // 
            this.insertitem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.insertitem.Enabled = false;
            this.insertitem.FlatAppearance.BorderSize = 0;
            this.insertitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertitem.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.insertitem.ForeColor = System.Drawing.Color.White;
            this.insertitem.Location = new System.Drawing.Point(878, 99);
            this.insertitem.Name = "insertitem";
            this.insertitem.Size = new System.Drawing.Size(110, 30);
            this.insertitem.TabIndex = 5;
            this.insertitem.Text = "Insert";
            this.insertitem.UseVisualStyleBackColor = false;
            this.insertitem.Click += new System.EventHandler(this.insertitem_Click);
            // 
            // moneyspent
            // 
            this.moneyspent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.moneyspent.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.moneyspent.ForeColor = System.Drawing.Color.White;
            this.moneyspent.Location = new System.Drawing.Point(742, 99);
            this.moneyspent.Name = "moneyspent";
            this.moneyspent.Size = new System.Drawing.Size(130, 30);
            this.moneyspent.TabIndex = 4;
            this.moneyspent.Text = "Money spent";
            this.moneyspent.Click += new System.EventHandler(this.moneyspent_Click);
            this.moneyspent.TextChanged += new System.EventHandler(this.moneyspent_TextChanged);
            this.moneyspent.Leave += new System.EventHandler(this.moneyspent_Leave);
            // 
            // datepicker
            // 
            this.datepicker.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(504, 99);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(105, 30);
            this.datepicker.TabIndex = 2;
            // 
            // selectdate
            // 
            this.selectdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.selectdate.FlatAppearance.BorderSize = 0;
            this.selectdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectdate.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.selectdate.ForeColor = System.Drawing.Color.White;
            this.selectdate.Location = new System.Drawing.Point(25, 475);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(110, 30);
            this.selectdate.TabIndex = 1;
            this.selectdate.Text = "pay day";
            this.selectdate.UseVisualStyleBackColor = false;
            this.selectdate.Click += new System.EventHandler(this.selectdate_Click);
            // 
            // update
            // 
            this.update.Enabled = false;
            this.update.Font = new System.Drawing.Font("Century Gothic", 15.5F);
            this.update.ForeColor = System.Drawing.Color.Gray;
            this.update.Location = new System.Drawing.Point(307, 220);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(418, 37);
            this.update.TabIndex = 21;
            this.update.Text = "Successfully added income to savings!";
            this.update.Visible = false;
            // 
            // viewsbutton
            // 
            this.viewsbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.viewsbutton.FlatAppearance.BorderSize = 0;
            this.viewsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewsbutton.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.viewsbutton.ForeColor = System.Drawing.Color.White;
            this.viewsbutton.Location = new System.Drawing.Point(878, 445);
            this.viewsbutton.Name = "viewsbutton";
            this.viewsbutton.Size = new System.Drawing.Size(110, 60);
            this.viewsbutton.TabIndex = 22;
            this.viewsbutton.Text = "View history";
            this.viewsbutton.UseVisualStyleBackColor = false;
            this.viewsbutton.Click += new System.EventHandler(this.viewsbutton_Click);
            // 
            // incbase
            // 
            this.incbase.AutoSize = true;
            this.incbase.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.incbase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.incbase.Location = new System.Drawing.Point(305, 154);
            this.incbase.Name = "incbase";
            this.incbase.Size = new System.Drawing.Size(158, 33);
            this.incbase.TabIndex = 23;
            this.incbase.Text = "incomeleft";
            // 
            // changeincome
            // 
            this.changeincome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeincome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.changeincome.Enabled = false;
            this.changeincome.FlatAppearance.BorderSize = 0;
            this.changeincome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeincome.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.changeincome.ForeColor = System.Drawing.Color.White;
            this.changeincome.Location = new System.Drawing.Point(213, 283);
            this.changeincome.Name = "changeincome";
            this.changeincome.Size = new System.Drawing.Size(180, 30);
            this.changeincome.TabIndex = 24;
            this.changeincome.Text = "Change income";
            this.changeincome.UseVisualStyleBackColor = false;
            this.changeincome.Click += new System.EventHandler(this.changeincome_Click);
            // 
            // changesavings
            // 
            this.changesavings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changesavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.changesavings.Enabled = false;
            this.changesavings.FlatAppearance.BorderSize = 0;
            this.changesavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changesavings.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.changesavings.ForeColor = System.Drawing.Color.White;
            this.changesavings.Location = new System.Drawing.Point(213, 337);
            this.changesavings.Name = "changesavings";
            this.changesavings.Size = new System.Drawing.Size(180, 30);
            this.changesavings.TabIndex = 25;
            this.changesavings.Text = "Change savings";
            this.changesavings.UseVisualStyleBackColor = false;
            this.changesavings.Click += new System.EventHandler(this.changesavings_Click);
            // 
            // incomebox
            // 
            this.incomebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.incomebox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.incomebox.ForeColor = System.Drawing.Color.White;
            this.incomebox.Location = new System.Drawing.Point(56, 283);
            this.incomebox.Name = "incomebox";
            this.incomebox.Size = new System.Drawing.Size(139, 30);
            this.incomebox.TabIndex = 26;
            this.incomebox.TextChanged += new System.EventHandler(this.incomebox_TextChanged);
            this.incomebox.Leave += new System.EventHandler(this.incomebox_Leave);
            // 
            // savingsbox
            // 
            this.savingsbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.savingsbox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.savingsbox.ForeColor = System.Drawing.Color.White;
            this.savingsbox.Location = new System.Drawing.Point(56, 337);
            this.savingsbox.Name = "savingsbox";
            this.savingsbox.Size = new System.Drawing.Size(139, 30);
            this.savingsbox.TabIndex = 27;
            this.savingsbox.TextChanged += new System.EventHandler(this.savingsbox_TextChanged);
            this.savingsbox.Leave += new System.EventHandler(this.savingsbox_Leave);
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
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.log_in.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_in.Location = new System.Drawing.Point(0, 30);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(1000, 50);
            this.log_in.TabIndex = 13;
            this.log_in.TabStop = false;
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
            this.minimize.TabIndex = 12;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimize_MouseDown);
            this.minimize.MouseEnter += new System.EventHandler(this.minimize_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
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
            this.maximize.TabIndex = 11;
            this.maximize.TabStop = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            this.maximize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.maximize_MouseDown);
            this.maximize.MouseEnter += new System.EventHandler(this.maximize_MouseEnter);
            this.maximize.MouseLeave += new System.EventHandler(this.maximize_MouseLeave);
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
            this.exit.TabIndex = 10;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exit_MouseDown);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1000, 30);
            this.titlebar.TabIndex = 9;
            this.titlebar.TabStop = false;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseDown);
            this.titlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseUp);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 530);
            this.Controls.Add(this.savingsbox);
            this.Controls.Add(this.incomebox);
            this.Controls.Add(this.changesavings);
            this.Controls.Add(this.changeincome);
            this.Controls.Add(this.incbase);
            this.Controls.Add(this.viewsbutton);
            this.Controls.Add(this.update);
            this.Controls.Add(this.selectdate);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.moneyspent);
            this.Controls.Add(this.insertitem);
            this.Controls.Add(this.selecttype);
            this.Controls.Add(this.savings);
            this.Controls.Add(this.savlabel);
            this.Controls.Add(this.inclabel);
            this.Controls.Add(this.income);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.maximize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.titlebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox log_in;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox maximize;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox titlebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Timer moveform;
        private System.Windows.Forms.Label income;
        private System.Windows.Forms.Label inclabel;
        private System.Windows.Forms.Label savlabel;
        private System.Windows.Forms.Label savings;
        private System.Windows.Forms.ComboBox selecttype;
        private System.Windows.Forms.Button insertitem;
        private System.Windows.Forms.TextBox moneyspent;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Button selectdate;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Button viewsbutton;
        private System.Windows.Forms.Label incbase;
        private System.Windows.Forms.Button changeincome;
        private System.Windows.Forms.Button changesavings;
        private System.Windows.Forms.TextBox incomebox;
        private System.Windows.Forms.TextBox savingsbox;
    }
}