using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_3
{
    public partial class Login : Form
    {
        public static string user_id, gname, gpass;
        public Login()
        {

            InitializeComponent();
        }

        //-------------------------------------Move form----------------------------------------------//

        int mousex, formleft, mousey, formtop;
        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousex = Cursor.Position.X;
                mousey = Cursor.Position.Y;
                formleft = this.Left;
                formtop = this.Top;
                moveform.Start();
            }

        }

        private void moveform_Tick(object sender, EventArgs e)
        {
            this.Left = formleft - (mousex - Cursor.Position.X);
            this.Top = formtop - (mousey - Cursor.Position.Y);
        }

        private void titlebar_MouseUp(object sender, MouseEventArgs e)
        {
            moveform.Stop();
        }

        //-------------------------------------Close Button-------------------------------------------//

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(255, 80, 80);
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(60, 141, 147);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void exit_MouseDown(object sender, MouseEventArgs e)
        {
            exit.BackColor = Color.FromArgb(255, 00, 00);
        }

        //---------------------------------Maximize Button--------------------------------------------//

        private void maximize_MouseEnter(object sender, EventArgs e)
        {
            maximize.BackColor = Color.FromArgb(76, 186, 194);
        }

        private void maximize_MouseLeave(object sender, EventArgs e)
        {
            maximize.BackColor = Color.FromArgb(60, 141, 147);
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void maximize_MouseDown(object sender, MouseEventArgs e)
        {
            maximize.BackColor = Color.FromArgb(215, 215, 215);
        }

        //---------------------------------Minimize Button------------------------------------------//

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(76, 186, 194);
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(60, 141, 147);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minimize_MouseDown(object sender, MouseEventArgs e)
        {
            minimize.BackColor = Color.FromArgb(215, 215, 215);
        }
        
        //----------------------------------------------Switch to register form---------------------------------------------//

        private void button1_Click(object sender, EventArgs e)
        {
            Register FL = new Test_3.Register();
            this.Hide();
            FL.Show();
        }

        //------------------------------------------------Additional Styling------------------------------------------------//

        private void username_Enter(object sender, EventArgs e)
        {
            if ((username.Text == "") || (username.Text == "Username"))
            {
                username.Clear();
            }
            username.ForeColor = Color.Black;
        }


        private void pass_Enter(object sender, EventArgs e)
        {
            if ((pass.Text == "") || (pass.Text == "Password"))
            {
                pass.Clear();
            }
            pass.ForeColor = Color.Black;
            pass.PasswordChar = '*';
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.ForeColor = Color.Gray;
                username.Text = "Username";
            }
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button.PerformClick();
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.ForeColor = Color.Gray;
                pass.PasswordChar = '\0';
                pass.Text = "Password";
            }
        }

        //------------------------------------Login Sequence------------------------------------------//

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Visual Studio\Financially\Financially\financially_users.mdf';Integrated Security=True;Connect Timeout=30");
            String sqlquery = "select username,password from user_creds where username='"+username.Text+"' and password='"+pass.Text+"'";

            SqlDataAdapter adp = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >0)
            {
                home fl = new home();
                String uid = "select user_id from user_creds where username='"+username.Text+"'";
                SqlDataAdapter adp2 = new SqlDataAdapter(uid, con);
                DataSet ds2 = new DataSet();
                adp2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                Object a = dt2.Rows[0]["user_id"];
                user_id = Convert.ToString(a);
                gname = username.Text;
                gpass = pass.Text;
                this.Hide();
                fl.Show();

            }

            else
            {
                MessageBox.Show("Invalid login credentials.");
            }

        }

    }
}
