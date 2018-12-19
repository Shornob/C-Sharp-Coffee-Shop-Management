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
    public partial class AdminForm : Form

    {

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;PORT=3306;DATABASE=projectcs;UID=Shornob;PASSWORD=123456");
        public AdminForm()
        {
            InitializeComponent();
        }

        
     
        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM projectcs.order;", con);
            try
            {
                string MyConnection2 = "Server=127.0.0.1;PORT=3306;DATABASE=projectcs;UID=Shornob;PASSWORD=123456";

                string Query = "select * from projectcs.order;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //display_data();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Dispose();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Server=127.0.0.1;PORT=3306;DATABASE=projectcs;UID=Shornob;PASSWORD=123456";
                string Query = "delete from projectcs.order where Id='" + this.textBox2.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "Latte")
            {



                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, Latte FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Espresso")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, Espresso FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }

            if (comboBox1.Text == "Iced Latte")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id,IcedLatte FROM projectcs.order ", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Cappuccino")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, Cappuccino FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "African Coffe")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, AfricanCoffe FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Regular Coffe")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, RegularCoffe FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Coffe Cake")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, CoffeCake FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Red Valvet Cake")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, RedValvetCake FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Black Forest Cake")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, BlackForestCake FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Boston Cream Cake")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, BostonCreamCake FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Lagos Chocolate Cake")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, LagosChocolateCake FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }
            if (comboBox1.Text == "Butter Cake")
            {


                MySqlDataAdapter sda = new MySqlDataAdapter("select Id, ButterCake FROM projectcs.order", con);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Server=127.0.0.1;PORT=3306;DATABASE=projectcs;UID=Shornob;PASSWORD=123456";
                string Query = "update projectcs.order set approved ='" + this.textBox1.Text + "' where Id='" + this.textBox2.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Approved");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 ss4 = new Form2();
            ss4.Show();
               
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Server=127.0.0.1;PORT=3306;DATABASE=projectcs;UID=Shornob;PASSWORD=123456";
                string Query = "Select Sum(Total) From projectcs.order";
                
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                //txtTotal.Text = 


                //MessageBox.Show(MyReader2);
                //Decimal sum = (Decimal)query.ExecuteScalar();
                //MessageBox.Show("Approved");
                while (MyReader2.Read())
                {
                    //string ap = Convert.ToString(MyReader2["Total"]);
                    //MessageBox.Show(ap);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // ("Select Sum(price) FROM transfer");
        }
    }
}
