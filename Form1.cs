using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int scorecount = 0;         // varible set to zero Global use
        double scoretotal = 0;      // varible set to zero Global use.            
        double[] dscores = new double[10];
        private void btnEnterCalculate_Click(object sender, EventArgs e)
        
        
        {
            double score = Convert.ToDouble(txtScore.Text); //convert intger input from txtboxScore.
            double average = 0;
            dscores[scorecount] = score; //
            scorecount = scorecount + 1;                    //Counter increment 
            

            scoretotal = score + scoretotal;                 //Calculation for variable.
            average = scoretotal / scorecount;              //Calculation for txtboxAverage.
            txtAverage.Text = average.ToString("n");        //creates string to output a number.
            txtScoreTotal.Text = scoretotal.ToString("n"); //creates string to output a number.
            txtScoreCount.Text = scorecount.ToString("n"); //creates string to output a number.
            txtScore.Text = "";
            txtScore.Focus();                       // moves focus to textBox for score input.

        }

        private void btnClear_Click(object sender, EventArgs e) 
        {
            txtScore.Text = "";                   //Clearing data enter from varible and textBoxes.
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            scorecount  = 0;
            scoretotal = 0;
        }

        private void btnExitEsc_Click(object sender, EventArgs e)
        {
            this.Close();                           // button EXIT is set here.
        }

        private void BtnDisplayScores_Click(object sender, EventArgs e)
        {
            string numberString  = "" ;
            foreach (double number in dscores)
            {
                 numberString += number + "\n";
            }
            MessageBox.Show(numberString, "Score Total");
        }
    }
}
