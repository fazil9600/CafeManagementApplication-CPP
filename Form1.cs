using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_reset_Click(object sender, EventArgs e)
        {
            tb_latte.Text = "0";
            tb_espresso.Text = "0";
            tb_iced_latte.Text = "0";
            tb_vale_cofee.Text = "0";
            tb_mango_juice.Text = "0";
            tb_banana_shake.Text = "0";
            tb_italian_special.Text = "0";
            tb_minchi_latte.Text = "0";
            tb_espresso.Text = "0";
            tb_vanila_ck.Text = "0";
            tb_pie_donut.Text = "0";
            tb_mango_ck.Text = "0";
            tb_sweet.Text = "0";
            tb_kibula.Text = "0";
            tb_malu_paan.Text = "0";
            tb_wade.Text = "0";
            tb_athirasa.Text = "0";
            tb_cost_of_drink.Text = "0";
            tb_cost_eating.Text = "0";
            tb_service_charge.Text = "0";
            tb_tax.Text = "0";
            tb_sub_total.Text = "0";
            tb_total.Text = "0";

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
            label8.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();



            tb_latte.Text = "0";
            tb_espresso.Text = "0";
            tb_iced_latte.Text = "0";
            tb_vale_cofee.Text = "0";
            tb_mango_juice.Text = "0";
            tb_banana_shake.Text = "0";
            tb_italian_special.Text = "0";
            tb_minchi_latte.Text = "0";
            tb_espresso.Text = "0";
            tb_vanila_ck.Text = "0";
            tb_pie_donut.Text = "0";
            tb_mango_ck.Text = "0";
            tb_sweet.Text = "0";
            tb_kibula.Text = "0";
            tb_malu_paan.Text = "0";
            tb_wade.Text = "0";
            tb_athirasa.Text = "0";
            tb_cost_of_drink.Text = "0";
            tb_cost_eating.Text = "0";
            tb_service_charge.Text = "10";
            tb_tax.Text = "0";
            tb_sub_total.Text = "0";
            tb_total.Text = "0";


            //tb_latte.Enabled = false;
            //tb_espresso.Enabled = false;
            //tb_iced_latte.Enabled = false;
            //tb_vale_cofee.Enabled = false;
            //tb_mango_juice.Enabled = false;
            //tb_banana_shake.Enabled = false;
            //tb_italian_special.Enabled = false;
            //tb_minchi_latte.Enabled = false;
            //tb_espresso.Enabled = false;
            //tb_vanila_ck.Enabled = false;
            //tb_pie_donut.Enabled = false;
            //tb_mango_ck.Enabled = false;
            //tb_sweet.Enabled = false;
            //tb_kibula.Enabled = false;
            //tb_malu_paan.Enabled = false;
            //tb_wade.Enabled = false;
            //tb_athirasa.Enabled = false;
            //tb_cost_of_drink.Enabled = false;
            //tb_cost_eating.Enabled = false;
            //tb_service_charge.Enabled = false;
            //tb_tax.Enabled = false;
            //tb_sub_total.Enabled = false;
            //tb_total.Enabled = false;
        }

        private void tb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_latte_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_latte.Checked == true)
            {
                tb_latte.Enabled = true;
            }
            else
            {
                tb_latte.Enabled = false;
                tb_latte.Text = "0";
            }
        }

        private void tb_latte_Click(object sender, EventArgs e)
        {
            tb_latte.Text = "";
            tb_latte.Focus();
        }

        private void tb_receipt_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Now.ToLongDateString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tb_final_total_Click(object sender, EventArgs e)
        {

            double tax;
            tax = 5;


            double totalServiceCharge;
            double serviceChargeRate = 15;

            double dLatte, dEspresso, dIceLatte, dValeCofee, dMangoJ, dBananaS, dItalianS, dMunchiL;
            double eVanilaC, ePieD, eMangoC, eSweetP, eKimbulaB, eMaluP, eWade, eAthirasa;

            //Totaling Drink Bevarages Total //

            dLatte = 150.00; dEspresso = 200.00; dIceLatte = 300.00; dValeCofee = 280.00; dMangoJ = 150.00; dBananaS = 190.00; dItalianS = 450.00; dMunchiL = 450.00;

            double dlatteTotal =        Convert.ToDouble(tb_latte.Text) /** dLatte*/;
            double dEspressoTotal =     Convert.ToDouble(tb_espresso.Text) /** dEspresso*/;
            double dIceLatteTotal =     Convert.ToDouble(tb_iced_latte.Text) /** dIceLatte*/;
            double dValeCofeeTotal =    Convert.ToDouble(tb_vale_cofee.Text) /** dValeCofee*/;
            double dMangoJTotal =       Convert.ToDouble(tb_mango_juice.Text) /** dMangoJ*/;
            double dBananaSTotal =      Convert.ToDouble(tb_banana_shake.Text) /** dBananaS*/;
            double dItalianSTotal =     Convert.ToDouble(tb_italian_special.Text) /** dBananaS*/;
            double dMunchiLTotal =      Convert.ToDouble(tb_minchi_latte.Text) /** dMunchiL*/;


            //Totaling Food Total //


            eVanilaC = 50.00; ePieD = 70.00; eMangoC = 90.00; eSweetP = 60.00; eKimbulaB = 25.00; eMaluP = 50.00; eWade = 60.00; eAthirasa = 50.00;


            double eVanilaCTotal =  Convert.ToDouble(tb_vanila_ck.Text) /** eVanilaC*/;
            double ePieDTotal =     Convert.ToDouble(tb_pie_donut.Text)/* * ePieD*/;
            double eMangoCTotal =   Convert.ToDouble(tb_mango_ck.Text) /** eMangoC*/;
            double eSweetPTotal =   Convert.ToDouble(tb_sweet.Text) /** eSweetP*/;
            double eKimbulaBTotal = Convert.ToDouble(tb_kibula.Text) /** eKimbulaB*/;
            double eMaluPTotal =    Convert.ToDouble(tb_malu_paan.Text) /** eMaluP*/;
            double eWadeTotal =     Convert.ToDouble(tb_wade.Text) /** eWade*/;
            double eAthirasaTotal = Convert.ToDouble(tb_athirasa.Text) /** eAthirasa*/;

            Cafe Eat = new Cafe (dlatteTotal, dEspressoTotal, dIceLatteTotal, dValeCofeeTotal, dMangoJTotal, dBananaSTotal, dItalianS, dMunchiLTotal, eVanilaCTotal, ePieDTotal, eMangoCTotal, eSweetPTotal, eKimbulaBTotal, eMangoCTotal, eWadeTotal, eAthirasaTotal);

            double costDrinking = (dlatteTotal * dLatte) +
                                    (dEspressoTotal * dEspresso) +
                                    (dIceLatteTotal * dLatte) +
                                    (dValeCofeeTotal * dValeCofee) +
                                    (dMangoJTotal * dMangoJ) +
                                    (dBananaSTotal * dBananaS) +
                                    (dMunchiLTotal * dMunchiL) +
                                    (dlatteTotal * dLatte);
            tb_cost_of_drink.Text = Convert.ToString(costDrinking);

            double costEating = (eVanilaCTotal * eVanilaC) +
                                    (ePieDTotal * ePieD) +
                                    (eMangoCTotal * eMangoC) +
                                    (eSweetPTotal * eSweetP) +
                                    (eKimbulaBTotal * eKimbulaB) +
                                    (eMaluPTotal * eMaluP) +
                                    (eWadeTotal * eWade) +
                                    (eAthirasaTotal * eAthirasa);
            tb_cost_eating.Text = Convert.ToString(costEating);

            double serivceCharge = Convert.ToDouble(tb_service_charge.Text);

            totalServiceCharge = (((costEating + costDrinking) * serviceChargeRate) / 100);
            tb_service_charge.Text = Convert.ToString(totalServiceCharge);

            tb_sub_total.Text = Convert.ToString(costEating + costDrinking + totalServiceCharge);
            tb_tax.Text = Convert.ToString(((costEating+costDrinking+ totalServiceCharge) * tax) / 100);
            double itax = Convert.ToDouble(tb_tax.Text);

            tb_total.Text = Convert.ToString(costEating + costDrinking+ totalServiceCharge + itax);

 

            




            



        }

        private void tb_service_charge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
