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
        private int accumulators = 0, solarPanels = 0;


        private void solarDemandScr_ValueChanged(object sender, EventArgs e)
        {
            this.txtSolarDemand.Text = this.solarDemandScr.Value.ToString();

            this.lblSolarDemandResult.Text = "To fully sustain your factory through a night you will need " + solarPanels.ToString() + " solar panels" + accumulators.ToString() + " accumulators";

        }

        private void txtSolarDemand_TextChanged(object sender, EventArgs e)
        {
            this.solarDemandScr.Value = Convert.ToInt16(this.txtSolarDemand.Text);
            this.lblSolarDemandResult.Text = "To fully sustain your factory through a night you will need " + solarPanels.ToString() + " solar panels " + accumulators.ToString() + " accumulators.";
        }
    }
}
