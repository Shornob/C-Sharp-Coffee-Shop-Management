using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace myProject
{
    public partial class Form1 : Form
    {
        MySqlConnection con =new MySqlConnection( "Server=127.0.0.1;PORT=3306;DATABASE=projectcs;UID=Shornob;PASSWORD=123456");
       //private bool false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtAfrican.Text = "0";
            txtBlackForest.Text = "0";
            txtBoston.Text = "0";
            txtButter.Text = "0";
            txtCappuccino.Text = "0";
            txtCoffe.Text = "0";
            txtEspresso.Text = "0";
            txtIcedLatte.Text = "0";
            txtLagos.Text = "0";
            txtLatte.Text = "0";
            txtRedValvet.Text = "0";
            txtRglr.Text = "0";
            lblCostofcakes.Text = "0";
            lblCostofDrinks.Text = "0";
            lblServiceCharge.Text = "1.75";

            txtLatte.Enabled = false;
            txtAfrican.Enabled = false;
            txtBlackForest.Enabled = false;
            txtBoston.Enabled = false;
            txtButter.Enabled = false;
            txtCappuccino.Enabled = false;
            txtCoffe.Enabled = false;
            txtEspresso.Enabled = false;
            txtIcedLatte.Enabled = false;
            txtLagos.Enabled = false;
            txtRedValvet.Enabled = false;
            txtRglr.Enabled = false;

            chkAfrican.Checked = false;
            chkBlackForest.Checked = false;
            chkBostonCream.Checked = false;
            chkBtr.Checked = false;
            chkCappuccino.Checked = false;
            chkCoffe.Checked = false;
            chkEspresso.Checked = false;
            chkIcedLatte.Checked = false;
            chkLagos.Checked = false;
            chkRedValvet.Checked = false;
            chkLatte.Checked = false;
            chkRglr.Checked = false;

            


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
            rtfReceipt.AppendText(Environment.NewLine);
           
            rtfReceipt.AppendText("\t\t" + "ABC CAFE " + Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Latte \t\t\t\t\t" + txtLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Latte \t\t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cappucciono \t\t\t" + txtCappuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Coffe \t\t\t\t" + txtCoffe.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos \t\t\t\t" + txtLagos.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Valvet \t\t\t\t" + txtRedValvet.Text + Environment.NewLine);
            rtfReceipt.AppendText("Regular \t\t\t\t" + txtRglr.Text + Environment.NewLine);
            rtfReceipt.AppendText("African \t\t\t\t" + txtAfrican.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest \t\t\t" + txtBlackForest.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston \t\t\t\t" + txtBoston.Text + Environment.NewLine);
            rtfReceipt.AppendText("Butter \t\t\t\t" + txtButter.Text + Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Vat \t\t\t\t\t" + lblVat.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub ToTal \t\t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total \t\t\t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "t\t\t\t" + lblDate.Text);


        }

        private void butReset_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = "0";
            txtBlackForest.Text = "0";
            txtBoston.Text = "0";
            txtButter.Text = "0";
            txtCappuccino.Text = "0";
            txtCoffe.Text = "0";
            txtEspresso.Text = "0";
            txtIcedLatte.Text = "0";
            txtLagos.Text = "0";
            txtLatte.Text = "0";
            txtRedValvet.Text = "0";
            txtRglr.Text = "0";
            lblCostofcakes.Text = "0";
            lblCostofDrinks.Text = "0";
            lblServiceCharge.Text = "1.75";
            lblSubTotal.Text = "0";
            lblVat.Text = "0";
            lblTotal.Text = "0";


            chkAfrican.Checked = false;
            chkBlackForest.Checked = false;
            chkBostonCream.Checked = false;
            chkBtr.Checked = false;
            chkCappuccino.Checked = false;
            chkCoffe.Checked = false;
            chkEspresso.Checked = false;
            chkLatte.Checked = false;
            chkIcedLatte.Checked = false;
            chkLagos.Checked = false;
            chkRedValvet.Checked = false;
           chkRglr.Checked = false;
            
                






        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {
                txtLatte.Enabled = true;

            }
            if (chkLatte.Checked== false)
            {
            txtLatte.Enabled = false;
            txtLatte.Text = "0";
            }

        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;

            }
            if (chkEspresso.Checked == false)
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }

        }

        private void chkIcedLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedLatte.Checked == true)
            {
                txtIcedLatte.Enabled = true;

            }
            if (chkIcedLatte.Checked == false)
            {
                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }

        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCappuccino.Enabled = true;

            }
            if (chkCappuccino.Checked == false)
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }

        }

        private void chkAfrican_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfrican.Checked == true)
            {
                txtAfrican.Enabled = true;

            }
            if (chkAfrican.Checked == false)
            {
                txtAfrican.Enabled = false;
                txtAfrican.Text = "0";
            }

        }

        private void chkRglr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRglr.Checked == true)
            {
                txtRglr.Enabled = true;

            }
            if (chkRglr.Checked == false)
            {
                txtRglr.Enabled = false;
                txtRglr.Text = "0";
            }

        }

        private void chkCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffe.Checked == true)
            {
                txtCoffe.Enabled = true;

            }
            if (chkCoffe.Checked == false)
            {
                txtCoffe.Enabled = false;
                txtCoffe.Text = "0";
            }

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkRedValvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedValvet.Checked == true)
            {
                txtRedValvet.Enabled = true;

            }
            if (chkRedValvet.Checked == false)
            {
                txtRedValvet.Enabled = false;
                txtRedValvet.Text = "0";
            }

        }

        private void chkBlackForest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForest.Checked == true)
            {
                txtBlackForest.Enabled = true;

            }
            if (chkBlackForest.Checked == false)
            {
                txtBlackForest.Enabled = false;
                txtBlackForest.Text = "0";
            }

        }

        private void chkBostonCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBostonCream.Checked == true)
            {
               txtBoston.Enabled = true;

            }
            if (chkBostonCream.Checked == false)
            {
                txtBoston.Enabled = false;
                txtBoston.Text = "0";
            }

        }

        private void chkLagos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagos.Checked == true)
            {
                txtLagos.Enabled = true;

            }
            if (chkLagos.Checked == false)
            {
                txtLagos.Enabled = false;
                txtLagos.Text = "0";
            }

        }

        private void chkBtr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBtr.Checked == true)
            {
                txtButter.Enabled = true;
                
                

            }
            if (chkBtr.Checked == false)
            {
                txtButter.Enabled = false;
                txtButter.Text = "0";
            }

        }

        private void txtLatte_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = " ";
            txtLatte.Focus();
        }

        private void txtRglr_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            double vat;
            vat = 15;

            double latte, ilatte, espresso, african, rglr, cappuccino;
            double coffecake, redvalvet, blackforest, bostoncream, lagos, butter;
            latte = 100; ilatte = 120; cappuccino = 80; espresso = 40; african = 150; rglr = 70;
            coffecake = 75; redvalvet = 65; blackforest = 95; bostoncream = 90; lagos = 120; butter=50;
            double Latte_c = Convert.ToDouble(txtLatte.Text);
            double cappu = Convert.ToDouble(txtCappuccino.Text);
            double IcedLatte = Convert.ToDouble(txtIcedLatte.Text);
            double espresson = Convert.ToDouble(txtEspresso.Text);
            double africano = Convert.ToDouble(txtAfrican.Text);
            double rglro = Convert.ToDouble(txtRglr.Text);
            double coffecako = Convert.ToDouble(txtCoffe.Text);
            double redvlvt = Convert.ToDouble(txtRedValvet.Text);
            double blkforest = Convert.ToDouble(txtBlackForest.Text);
            double boston = Convert.ToDouble(txtBoston.Text);
            double lagoos = Convert.ToDouble(txtLagos.Text);
            double buttry = Convert.ToDouble(txtButter.Text);

            Cafe eat_in_cafe = new Cafe(Latte_c,cappu,IcedLatte,espresson,africano,rglro,coffecako,redvlvt,blkforest,boston,lagoos,buttry);

            double cost_of_dronks = (Latte_c * latte) + (cappu * cappuccino) + (IcedLatte * ilatte) + (espresson * espresso) + (africano * african) + (rglro * rglr);
            lblCostofDrinks.Text = Convert.ToString(cost_of_dronks);

            double cost_of_cakes = (coffecako * coffecake) + (redvlvt * redvalvet) + (blkforest * blackforest) + (boston * bostoncream) + (lagoos * lagos) + (buttry * butter);
            lblCostofcakes.Text = Convert.ToString(cost_of_cakes);

            double service_charge = Convert.ToDouble(lblServiceCharge.Text);
            lblSubTotal.Text = Convert.ToString(cost_of_cakes + cost_of_dronks + service_charge);
            lblVat.Text = Convert.ToString(((cost_of_cakes + cost_of_dronks + service_charge)*vat) / 100);
            double ivat = Convert.ToDouble(lblVat.Text);
            lblTotal.Text = Convert.ToString(cost_of_cakes + cost_of_dronks + ivat + service_charge);

            lblCostofcakes.Text = String.Format("{0:#.00}", cost_of_cakes);
            lblCostofDrinks.Text = String.Format("{0:#.00}", cost_of_dronks);
            lblServiceCharge.Text = String.Format("{0:#.00}", service_charge);
            lblSubTotal.Text = String.Format("{0:#.00}", (cost_of_cakes + cost_of_dronks + service_charge));
            lblVat.Text = String.Format("{0:#.00}", ivat);
            lblTotal.Text = String.Format("{0:#.00}", (cost_of_cakes + cost_of_dronks + ivat + service_charge));


        }


       // public double capuchino { get; set; }

        public int cappuccino { get; set; }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = " ";
            txtEspresso.Focus();
        }

        private void txtIcedLatte_Click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = " ";
            txtIcedLatte.Focus();
        }

        private void txtCappuccino_Click(object sender, EventArgs e)
        {
            txtCappuccino.Text = " ";
            txtCappuccino.Focus();
        }

        private void txtAfrican_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = " ";
            txtAfrican.Focus();
        }

        private void txtRglr_Click(object sender, EventArgs e)
        {
              txtRglr.Text = " ";
            txtRglr.Focus();
        }

        private void txtCoffe_Click(object sender, EventArgs e)
        {
         txtCoffe.Text = " ";
           txtCoffe.Focus();
        }

        private void txtRedValvet_Click(object sender, EventArgs e)
        {
          txtRedValvet.Text = " ";
           txtRedValvet.Focus();
        }

        private void txtBlackForest_Click(object sender, EventArgs e)
        {
            txtBlackForest.Text = " ";
           txtBlackForest.Focus();
        }

        private void txtBoston_Click(object sender, EventArgs e)
        {
        txtBoston.Text = " ";
           txtBoston.Focus();
        }

        private void txtLagos_Click(object sender, EventArgs e)
        {
        txtLagos.Text = " ";
          txtLagos.Focus();
        }

        private void txtButter_Click(object sender, EventArgs e)
        {
        txtButter.Text = " ";
          txtButter.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                MessageBox.Show("Sir,Your order has been successfully placed ,please wait for approval");
                string query = "insert into projectcs.order(Latte,Espresso,IcedLatte,Cappuccino,AfricanCoffe,RegularCoffe,CoffeCake,RedValvetCake,BlackForestCake,BostonCreamCake,LagosChocolateCake,ButterCake,CostOfDrinks,CostOfCakes,ServiceCharge,Vat,SubTotal,Total) values('" + this.txtLatte.Text + "','" + this.txtEspresso.Text + "','" + this.txtIcedLatte.Text + "','" + this.txtCappuccino.Text + "','" + this.txtAfrican.Text + "','" + this.txtRglr.Text + "','" + this.txtCoffe.Text + "','" + this.txtRedValvet.Text + "','" + this.txtBlackForest.Text + "','" + this.txtBoston.Text + "','" + this.txtLagos.Text + "','" + this.txtButter.Text + "','" + this.lblCostofDrinks.Text + "','" + this.lblCostofcakes.Text + "','" + this.lblServiceCharge.Text + "','" + this.lblVat.Text + "','" + this.lblSubTotal.Text + "','" + this.lblTotal.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                con.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

                MessageBox.Show(@"Error: " + ex.Message);
            }
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 ss = new Form2();
            ss.Show();
            this.Hide();

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                string MyConnection2 = "Server=127.0.0.1;PORT=3306;DATABASE=projectcs;UID=Shornob;PASSWORD=123456";
                string Query = "select approved from projectcs.order  where Id='" + this.textBox1.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {

                    string ap = Convert.ToString(MyReader2["approved"]);
                    if (ap == Convert.ToString(1))
                    {
                        MessageBox.Show("Sir,Your order has been approved , please wait 10 minutes!");
                    }

                    else
                    {
                        MessageBox.Show("Sir,your order has not been approved yet,please Pay First");
                    }
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }


        }
    }

