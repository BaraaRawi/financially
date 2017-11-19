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
    public partial class dateselect : Form
    {
        public static string datepick;
        public dateselect()
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

        private void selectdate_Load(object sender, EventArgs e)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "dd";


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Visual Studio\Financially\Financially\financially_users.mdf';Integrated Security=True;Connect Timeout=10");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SELECT payday FROM user_creds WHERE user_id =" + Login.user_id + ";  ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            currentpayday.Text ="Current payday: "+ reader.GetString(0);
            con.Close();
            datepick = picker.Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Visual Studio\Financially\Financially\financially_users.mdf';Integrated Security=True;Connect Timeout=10");
            SqlCommand cmd = new SqlCommand();            
            con.Open();

            cmd= new SqlCommand("UPDATE user_creds SET payday="+picker.Text+" WHERE user_id=" + Login.user_id + ";", con);
            cmd.ExecuteNonQuery();


            SqlDataReader reader;
            cmd.CommandText = "SELECT payday FROM user_creds WHERE user_id=" + Login.user_id + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            reader =cmd.ExecuteReader();
            reader.Read();        
            MessageBox.Show("Successfully updated.");
            currentpayday.Text = "Current payday: "+reader.GetString(0);
            con.Close();
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



        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
