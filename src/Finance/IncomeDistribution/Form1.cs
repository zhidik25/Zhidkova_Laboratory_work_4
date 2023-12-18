using System;
using System.Windows.Forms;

namespace IncomeDistribution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCalculat_Click(object sender, EventArgs e)
        {
            float InputData, FinancialCushion, MandatoryExpenses, CurrentExpenses, Goal, Investment;

            InputData = float.Parse(textBoxInputData.Text);

            FinancialCushion = (InputData * 10) / 100;
            MandatoryExpenses = (InputData * 30) / 100;
            CurrentExpenses = (InputData * 30) / 100;
            Goal = (InputData * 15) / 100;
            Investment = (InputData * 15) / 100;

            textBoxFinancialCushion.Text = Convert.ToString(Math.Round(FinancialCushion, 2));
            textBoxMandatoryExpenses.Text = Convert.ToString(Math.Round(MandatoryExpenses, 2));
            textBoxCurrentExpenses.Text = Convert.ToString(Math.Round(CurrentExpenses, 2));
            textBoxGoal.Text = Convert.ToString(Math.Round(Goal, 2));
            textBoxInvestment.Text = Convert.ToString(Math.Round(Investment, 2));
        }
    }
}
