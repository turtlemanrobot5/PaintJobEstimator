using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintJobEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const decimal HOUR_RATE_VALUE = 20.00m;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sqft;
                decimal gallon;
                decimal gneeded;
                decimal lbrneeded;
                decimal cstpaint;
                decimal laborchrg;
                decimal totalcost;
                sqft = decimal.Parse(squareFeetTextBox.Text);
                gallon = decimal.Parse(priceOfThePaintPerGallonTextBox.Text);
                gneeded = sqft / 115;
                gneeded = Math.Round(gneeded, 0);
                lbrneeded = (sqft * 8) / 115;
                lbrneeded = Math.Round(lbrneeded, 2);
                cstpaint = (sqft * gallon) / 115m;
                laborchrg = lbrneeded * 20m;
                totalcost = laborchrg + cstpaint;
                gallonsOfPaintNeededLabel.Text = gneeded.ToString("");
                hoursOfLaborRequiredLabel.Text = lbrneeded.ToString("");
                costOfPaintLabel.Text = cstpaint.ToString("c");
                laborChargesLabel.Text = laborchrg.ToString("c");
                totalCostOfThePaintJobLabel.Text = totalcost.ToString("c");
                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            squareFeetTextBox.Text = "";
            priceOfThePaintPerGallonTextBox.Text = "";
            gallonsOfPaintNeededLabel.Text = "";
            hoursOfLaborRequiredLabel.Text = "";
            costOfPaintLabel.Text = "";
            laborChargesLabel.Text = "";
            totalCostOfThePaintJobLabel.Text = "";
            squareFeetTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
