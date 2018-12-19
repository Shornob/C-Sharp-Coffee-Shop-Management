using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace myProject
{
    public partial class Form2 : Form
    {

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;PORT=3306;DATABASE=projectcs;UID=Shornob;PASSWORD=123456");
        int i;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            string pass = txtPassword.Text.Trim();
            string unmae = txtUserName.Text.Trim();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from admin where UserName='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            
            if (dt.Rows.Count>0)
            {
               if(pass ==dt.Rows[i]["Password"].ToString() && unmae == dt.Rows[i]["UserName"].ToString())
               {
               this.Dispose();
                AdminForm ss2 = new AdminForm();
                ss2.Show();
               
               
               }
                else{
               MessageBox.Show("Invalid Information");
               }


            }
            else if(i==0)
            {
                MessageBox.Show("Invalid Information");
            
            
            }
            else
            {

            }

            con.Close();




            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 ss3 = new Form1();
            ss3.Show();
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Must Login as Admin");
        }
    }
}
