using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        //solar energy, all units in kW
        private int cAccumulators = 0, cSolarPanels = 0;

        private double accu = 0;

        private double demand = 0, sustain = 0;

        private double accuDrain = 300, accuProvide = 300, accuStore = 5000000;//J
        private double accukWh = 1.388889;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.calcAccu().ToString());
            calcSP();
        }

        private void sDemand_TextChanged(object sender, EventArgs e)
        {
            
            if (this.txtCurrAccu.Text != "")
                cAccumulators = Convert.ToInt16(this.txtCurrAccu.Text);
            if (this.txtCurrSP.Text != "")
                cSolarPanels = Convert.ToInt16(this.txtCurrSP.Text);
            if (this.sDemand.Text != "")
            {
                demand = Convert.ToDouble(this.sDemand.Text);
                this.solarDemandScr.Value = Convert.ToInt16(this.sDemand.Text);
            }

            if (this.txtSustain.Text != "")
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcAccu().ToString() + " accumulators " + calcSP().ToString() + " solar panels";
            else
            {
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcSP().ToString() + " solar panels";
            }
        }

        private void solarDemandScr_ValueChanged_1(object sender, EventArgs e)
        {

            this.sDemand.Text = this.solarDemandScr.Value.ToString();

            if (this.txtCurrAccu.Text != "")
                cAccumulators = Convert.ToInt16(this.txtCurrAccu.Text);
            if (this.txtCurrSP.Text != "")
                cSolarPanels = Convert.ToInt16(this.txtCurrSP.Text);
            if (this.sDemand.Text != "")
            {
                demand = Convert.ToDouble(this.sDemand.Text);
                this.solarDemandScr.Value = Convert.ToInt16(this.sDemand.Text);
            }

            if (this.txtSustain.Text != "")
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcAccu().ToString() + " accumulators " + calcSP().ToString() + " solar panels";
            else
            {
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcSP().ToString() + " solar panels";
            }
        }

        private int solarPanelProvide = 60000;

        private void txtCurrAccu_TextChanged(object sender, EventArgs e)
        {

            if (this.txtCurrAccu.Text != "")
                cAccumulators = Convert.ToInt16(this.txtCurrAccu.Text);
            if (this.txtCurrSP.Text != "")
                cSolarPanels = Convert.ToInt16(this.txtCurrSP.Text);
            if (this.sDemand.Text != "")
            {
                demand = Convert.ToDouble(this.sDemand.Text);
                this.solarDemandScr.Value = Convert.ToInt16(this.sDemand.Text);
            }

            if (this.txtSustain.Text != "")
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcAccu().ToString() + " accumulators " + calcSP().ToString() + " solar panels";
            else
            {
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcSP().ToString() + " solar panels";
            }
        }

        private void txtCurrSP_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCurrAccu.Text != "")
                cAccumulators = Convert.ToInt16(this.txtCurrAccu.Text);
            if (this.txtCurrSP.Text != "")
                cSolarPanels = Convert.ToInt16(this.txtCurrSP.Text);
            if (this.sDemand.Text != "")
            {
                demand = Convert.ToDouble(this.sDemand.Text);
                this.solarDemandScr.Value = Convert.ToInt16(this.sDemand.Text);
            }

            if (this.txtSustain.Text != "")
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcAccu().ToString() + " accumulators " + calcSP().ToString() + " solar panels";
            else
            {
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcSP().ToString() + " solar panels";
            }
        }

        private void txtSustain_TextChanged(object sender, EventArgs e)
        {
            this.sustainScrl.Value = Convert.ToInt16(this.txtSustain.Text);
            this.sustain = this.sustainScrl.Value;

            if (this.txtCurrAccu.Text != "")
                cAccumulators = Convert.ToInt16(this.txtCurrAccu.Text);
            if (this.txtCurrSP.Text != "")
                cSolarPanels = Convert.ToInt16(this.txtCurrSP.Text);

            if (this.txtSustain.Text != "")
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcAccu().ToString() + " accumulators " + calcSP().ToString() + " solar panels";
            else
            {
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcSP().ToString() + " solar panels";
            }
        } 

        private void sustainScrl_ValueChanged(object sender, EventArgs e)
        {
            this.txtSustain.Text = this.sustainScrl.Value.ToString();
            this.sustain = this.sustainScrl.Value;

            if (this.txtCurrAccu.Text != "")
                cAccumulators = Convert.ToInt16(this.txtCurrAccu.Text);
            if (this.txtCurrSP.Text != "")
                cSolarPanels = Convert.ToInt16(this.txtCurrSP.Text);

            if (this.txtSustain.Text != "")
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcAccu().ToString() + " accumulators " + calcSP().ToString() + " solar panels";
            else
            {
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcSP().ToString() + " solar panels";
            }
        }

        private void solarDemandScr_ValueChanged(object sender, EventArgs e)
        {
            this.sDemand.Text = this.solarDemandScr.Value.ToString();

            if (this.txtCurrAccu.Text != "")
                cAccumulators = Convert.ToInt16(this.txtCurrAccu.Text);
            if (this.txtCurrSP.Text != "")
                cSolarPanels = Convert.ToInt16(this.txtCurrSP.Text);
            if (this.sDemand.Text != "")
            {
                demand = Convert.ToDouble(this.sDemand.Text);
                this.solarDemandScr.Value = Convert.ToInt16(this.sDemand.Text);
            }

            if(this.txtSustain.Text != "")
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcAccu().ToString() + " accumulators " + calcSP().ToString() + " solar panels";
            else
            {
                this.lblSolarDemandResult.Text = "To fully sustain your factory you will need " + calcSP().ToString() + " solar panels";
            }
        }


        private double calcAccu()
        {
            this.accu = Math.Ceiling((Convert.ToDouble(this.sustain) * 1000000) * 90) / this.accuStore;
            return this.accu;
        }

        private double calcSP()
        {
            if(this.cAccumulators != 0 && this.cAccumulators < accu)
                return Math.Ceiling(((1000000 * this.demand) + (this.accu - this.cAccumulators) * 30000) / solarPanelProvide);
            else
            {
                return Math.Ceiling(1000000 * this.demand / solarPanelProvide);
            }

        }

    }
}
