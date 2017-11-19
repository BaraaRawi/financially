using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Test_3
{

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        //--------------------------------------SQL Connection----------------------------------------//
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        //------------------------------Move form without WindowsBorder-------------------------------//
        int mousex, formleft, mousey, formtop;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            maximize.BackColor= Color.FromArgb(76, 186, 194);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            maximize.BackColor = Color.FromArgb(60, 141, 147);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else WindowState = FormWindowState.Maximized;
        }

        private void maximize_MouseDown(object sender, MouseEventArgs e)
        {
            maximize.BackColor = Color.FromArgb(215, 215, 215);
        }

        //---------------------------------Minimize Button------------------------------------------//

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            minimize.BackColor= Color.FromArgb(76, 186, 194);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(60, 141, 147);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minimize_MouseDown(object sender, MouseEventArgs e)
        {
            minimize.BackColor = Color.FromArgb(215, 215, 215);
        }

        //------------------------------------Textbox Styles---------------------------------------//

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

        private void confirmpass_Enter(object sender, EventArgs e)
        {
            if ((confirmpass.Text == "") || (confirmpass.Text == "Confirm Password"))
            {
                confirmpass.Clear();
            }
            confirmpass.ForeColor = Color.Black;
            confirmpass.PasswordChar = '*';

        }

        private void income_Enter(object sender, EventArgs e)
        {
            if ((income.Text == "") || (income.Text == "Income"))
            {
                income.Clear();
            }
            income.ForeColor = Color.Black;
        }

        private void savings_Enter(object sender, EventArgs e)
        {
            if ((savings.Text == "") || (savings.Text == "Savings"))
            {
                savings.Clear();
            }
            savings.ForeColor = Color.Black;
        }

        //---------------------------------Signup Button Style--------------------------------//

        private void signup_MouseEnter(object sender, EventArgs e)
        {
            signup.BackColor = Color.FromArgb(76, 186, 194);
        }

        private void signup_MouseLeave(object sender, EventArgs e)
        {
            signup.BackColor = Color.FromArgb(60, 141, 147);
        }

        //-------------------------------Textbox tabbing-----------------------------------//

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.ForeColor = Color.Gray;
                username.Text = "Username";
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

        private void income_Leave(object sender, EventArgs e)
        {
            if (income.Text == "")
            {
                income.ForeColor = Color.Gray;
                income.Text = "Income";
            }
        }

        private void savings_Leave(object sender, EventArgs e)
        {
            if (savings.Text == "")
            {
                savings.ForeColor = Color.Gray;
                savings.Text = "Savings";
            }
        }

        private void confirmpass_Leave(object sender, EventArgs e)
        {
            if (confirmpass.Text == "")
            {
                confirmpass.ForeColor = Color.Gray;
                confirmpass.PasswordChar = '\0';
                confirmpass.Text = "Confirm Password";
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "dd";
        }

        //-------------------------------Signup Sequence------------------------------//

        private void signup_Click(object sender, EventArgs e)
        {
            //-------------------------------------Connection--------------------------------------//

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Visual Studio\Financially\Financially\financially_users.mdf';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            con.Open();

            //-----------------------------------Variables---------------------------------//

            decimal inc,sav;
            bool numbercheck = (Decimal.TryParse(income.Text, out inc))&(Decimal.TryParse(savings.Text, out sav));
            bool userx=false;

            //-------------------------------Check if user exists-------------------------//

            SqlDataReader reader;

            cmd.CommandText= "SELECT username FROM user_creds WHERE username ='"+username.Text+"';";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                userx = true;
            }
            reader.Close();

            if (userx == false)
            {
                if (numbercheck == true)
                {
                    if ((pass.Text == confirmpass.Text) & (username.Text != "Username") & (pass.Text != "Password") & (confirmpass.Text != "Confirm Password")
                                    & (income.Text != null) & (savings.Text != null) & (picker.Text != null)
                                    & (numbercheck = true))
                    {
                        Cursor = Cursors.WaitCursor;
                        Cursor = Cursors.Arrow;
                        cmd = new SqlCommand("INSERT INTO user_creds (username,password,income,incbase,savings,payday, monthstart)  VALUES (@username,@password,@income,@incbase,@savings,@payday,@monthstart) ", con);
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", pass.Text);
                        cmd.Parameters.AddWithValue("@income", income.Text);
                        cmd.Parameters.AddWithValue("@incbase", income.Text);
                        cmd.Parameters.AddWithValue("@savings", savings.Text);
                        cmd.Parameters.AddWithValue("@payday", picker.Text);
                        cmd.Parameters.AddWithValue("@monthstart", 0);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You have been successfully registered.");
                    }
                    else if ((pass.Text != confirmpass.Text) & (username.Text != "") & (pass.Text != "") & (confirmpass.Text != ""))
                    {
                        MessageBox.Show("The passwords do not match, please try again.");
                    }
                    else if ((username.Text == "Username") || (pass.Text == "Password") || (confirmpass.Text == "Confirm Password"))
                    {
                        MessageBox.Show("Incomplete fields, please fill all the required fields");
                    }
                }
                else
                    MessageBox.Show("Only numbers are accepted in the savings and income fields.");
            }
            else
                MessageBox.Show("Username already exists.");

        }


        /*-------------------------------Additional styling------------------------------*/


        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();

        }

        private void confirmpass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                signup.PerformClick();
            }
        }
    }
}
