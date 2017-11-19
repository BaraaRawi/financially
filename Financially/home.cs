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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        //-----------------------------------Move Form---------------------------------------------//

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

        //------------------------------------Username welcome---------------------------------------//

        private void home_Load(object sender, EventArgs e)
        {
            Welcome.Text = "Welcome, "+Login.gname+".";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Visual Studio\Financially\Financially\financially_users.mdf';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            //---------------------------------------------Fetches Payday value---------------------------------------------------//

            cmd.CommandText = "SELECT payday FROM user_creds WHERE user_id=" + Login.user_id + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            string payday = reader.GetSqlValue(0).ToString();
            con.Close();

            //------------------------------------- Limits to 1 incrementation per month--------------------------------//

            bool set = false;
            SqlCommand command2 = new SqlCommand("UPDATE user_creds SET monthstart=1 WHERE user_id='" + Login.user_id + "'", con);
            con.Open();
            int b = command2.ExecuteNonQuery();
            if (b > 0) { set = true; }
            else { set = false; }
            con.Close();

            cmd.CommandText = "SELECT payday FROM user_creds WHERE user_id=" + Login.user_id + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            int dbday = Convert.ToInt32(reader.GetString(0));
            con.Close();

            var now = DateTime.Now;
            var monthstart = new DateTime(now.Year, now.Month, dbday);
            var day = DateTime.Today;
            if (set == true)
            {
                if (day == monthstart)
                {
                    cmd.CommandText = "UPDATE user_creds SET monthstart=0 WHERE user_id='" + Login.user_id + "'";
                    cmd.Connection = con;
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    con.Close();
                }
            }


            //----------------------------Increments income into savings on payday, displays label-------------------------------//

            SqlCommand command = new SqlCommand("UPDATE user_creds SET savings = savings + incbase, incbase=income WHERE monthstart=0 AND user_id ='" + Login.user_id + "' AND payday ='" + payday + "'", con);
            con.Open();
            int a = command.ExecuteNonQuery();
            if (a>0) { update.Visible = true; }
            con.Close();


            //--------------------------------------Welcome screen values savings/income-----------------------------------------//

            cmd.CommandText = "SELECT income from user_creds WHERE user_id=" + Login.user_id + ";  ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            income.Text = reader.GetSqlDecimal(0).ToString();
            con.Close();

            cmd.CommandText = "SELECT savings from user_creds WHERE user_id=" + Login.user_id + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            savings.Text = reader.GetSqlDecimal(0).ToString();
            con.Close();

            cmd.CommandText = "SELECT incbase from user_creds WHERE user_id=" + Login.user_id + ";  ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            incbase.Text = "("+reader.GetSqlDecimal(0).ToString()+" left)";
            con.Close();
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

        //=====================================================Info insertion==================================================//

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            insertitem.Focus();
        }

        private void insertitem_Click(object sender, EventArgs e)
        {

            //----------------------------------------Connection----------------------------------------------//

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Visual Studio\Financially\Financially\financially_users.mdf';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            con.Open();

            //----------------------------------------Spending Register---------------------------------------//

            cmd = new SqlCommand("INSERT INTO spending (user_id,date,type,price)  VALUES (@user_id,@date,@type,@price) ", con);
            cmd.Parameters.AddWithValue("@user_id", Login.user_id);
            cmd.Parameters.AddWithValue("@date",datepicker.Text);
            cmd.Parameters.AddWithValue("@type",selecttype.SelectedItem);
            cmd.Parameters.AddWithValue("@price",moneyspent.Text);
            cmd.ExecuteNonQuery();

            //-----------------------------------------Update incbase-----------------------------------------//

            cmd = new SqlCommand("UPDATE user_creds SET incbase=incbase - '"+moneyspent.Text+"' WHERE user_id='"+Login.user_id+"'", con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            cmd.CommandText = "SELECT incbase from user_creds WHERE user_id=" + Login.user_id + ";  ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            reader.Read();
            incbase.Text = "("+reader.GetSqlDecimal(0).ToString()+" left)";
            con.Close();
            MessageBox.Show("Successfully inserted spending.");
        }

        private void selectdate_Click(object sender, EventArgs e)
        {
            dateselect FL = new dateselect();
            FL.Show();
        }

        private void viewsbutton_Click(object sender, EventArgs e)
        {
            views FL = new views();
            FL.Show();
        }

        //--------------------------------------------Change income-----------------------------------------------------//

        private void changeincome_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Visual Studio\Financially\Financially\financially_users.mdf';Integrated Security=True;Connect Timeout=30");
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE user_creds SET income='" + incomebox.Text + "' WHERE user_id='" + Login.user_id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader=cmd.ExecuteReader();
            reader.Read();
            con.Close();
            MessageBox.Show("Successfuly updated!");

            //-----------------------------------Refreshes income---------------------------------------//

            cmd.CommandText = "SELECT income from user_creds WHERE user_id=" + Login.user_id + ";  ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            income.Text = reader.GetSqlDecimal(0).ToString();
            con.Close();
        }

        //-----------------------------------------Add to savings--------------------------------------------------------//

        private void changesavings_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Visual Studio\Financially\Financially\financially_users.mdf';Integrated Security=True;Connect Timeout=30");
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE user_creds SET savings='" + savingsbox.Text + "' WHERE user_id='" + Login.user_id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            con.Close();
            MessageBox.Show("Successfuly updated!");

            //-----------------------------------Refreshes income---------------------------------------//

            cmd.CommandText = "SELECT savings from user_creds WHERE user_id=" + Login.user_id + ";  ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            savings.Text = reader.GetSqlDecimal(0).ToString();
            con.Close();
        }


        //--------------------------------------------Incomebox styling-------------------------------------------------//

        private void incomebox_TextChanged(object sender, EventArgs e)
        {
            decimal moneyinfo;
            bool hasnumbers = Decimal.TryParse(incomebox.Text, out moneyinfo);
            if (hasnumbers == false)
            {
                changeincome.Enabled = false;
            }
            else
            {
                changeincome.Enabled = true;
            }
        }

        private void incomebox_Leave(object sender, EventArgs e)
        {
            decimal moneyinfo;
            bool hasnumbers = Decimal.TryParse(incomebox.Text, out moneyinfo);
            if (hasnumbers == false)
            {
                incomebox.Text = null;
            }
        }

        //------------------------------------------------Savingsbox styling-----------------------------------------------------//

        private void savingsbox_TextChanged(object sender, EventArgs e)
        {
            decimal moneyinfo;
            bool hasnumbers = Decimal.TryParse(savingsbox.Text, out moneyinfo);
            if (hasnumbers == false)
            {
                changesavings.Enabled = false;
            }
            else
            {
                changesavings.Enabled = true;
            }
        }

        private void savingsbox_Leave(object sender, EventArgs e)
        {
            decimal moneyinfo;
            bool hasnumbers = Decimal.TryParse(savingsbox.Text, out moneyinfo);
            if (hasnumbers == false)
            {
                savingsbox.Text = null;
            }
        }

        //--------------------------------------------Moneyspent box styling-------------------------------------------//

        private void moneyspent_Click(object sender, EventArgs e)
        {
            decimal moneyinfo;
            bool hasnumbers = Decimal.TryParse(moneyspent.Text, out moneyinfo);
            if (hasnumbers == false)
            {
                if (moneyspent != null)
                {
                    moneyspent.Text = null;
                }
            }

        }

        private void moneyspent_Leave(object sender, EventArgs e)
        {
            decimal moneyinfo;
            bool hasnumbers = Decimal.TryParse(moneyspent.Text, out moneyinfo);
            if (hasnumbers == false)
            {
                if (moneyspent != null)
                {
                    moneyspent.Text = "Money spent";
                }
            }
        }

        private void moneyspent_TextChanged(object sender, EventArgs e)
        {
            decimal moneyinfo;
            bool hasnumbers = Decimal.TryParse(moneyspent.Text, out moneyinfo);
            if (hasnumbers == false)
            {
                insertitem.Enabled = false;
            }
            else
            {
                insertitem.Enabled = true;
            }

        }


    }
}
