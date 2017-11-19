namespace Test_3
{
    partial class dateselect
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
            this.titlebar = new System.Windows.Forms.PictureBox();
            this.picker = new System.Windows.Forms.DateTimePicker();
            this.moveform = new System.Windows.Forms.Timer(this.components);
            this.back = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.currentpayday = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_in)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.titlebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(300, 30);
            this.titlebar.TabIndex = 14;
            this.titlebar.TabStop = false;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseDown);
            this.titlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseUp);
            // 
            // picker
            // 
            this.picker.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.picker.Location = new System.Drawing.Point(12, 123);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(276, 34);
            this.picker.TabIndex = 3;
            // 
            // moveform
            // 
            this.moveform.Interval = 1;
            this.moveform.Tick += new System.EventHandler(this.moveform_Tick);
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(29, 258);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 30);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(162, 258);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(110, 30);
            this.submit.TabIndex = 2;
            this.submit.Text = "update";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // currentpayday
            // 
            this.currentpayday.AutoSize = true;
            this.currentpayday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.currentpayday.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.currentpayday.ForeColor = System.Drawing.Color.White;
            this.currentpayday.Location = new System.Drawing.Point(12, 78);
            this.currentpayday.Name = "currentpayday";
            this.currentpayday.Size = new System.Drawing.Size(225, 33);
            this.currentpayday.TabIndex = 16;
            this.currentpayday.Text = "current payday:";
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(69)))), ((int)(((byte)(83)))));
            this.log_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_in.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_in.Location = new System.Drawing.Point(0, 30);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(300, 275);
            this.log_in.TabIndex = 15;
            this.log_in.TabStop = false;
            // 
            // dateselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.currentpayday);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.picker);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.titlebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dateselect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selectdate";
            this.Load += new System.EventHandler(this.selectdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_in)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox titlebar;
        private System.Windows.Forms.Timer moveform;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker picker;
        private System.Windows.Forms.Label currentpayday;
        private System.Windows.Forms.PictureBox log_in;
    }
}