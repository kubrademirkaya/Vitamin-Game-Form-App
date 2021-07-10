using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaminGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Random random = new Random();
        int second = 60;
        
        SolidFruitJuicer solidFruitJuicer = new SolidFruitJuicer();
        CitrusJuicer citrusJuicer = new CitrusJuicer();

        Orange orange = new Orange();
        Mandarin mandarin = new Mandarin();
        Pomelo pomelo = new Pomelo();

        Apple apple = new Apple();
        Strawberry strawberry = new Strawberry();
        Pear pear = new Pear();

        FruitClass fruit = new FruitClass();

        float liquidSum = 0;
        float pureeSum = 0;
        float vitAAmount = 0;
        float vitCAmount = 0;
        float vitASum = 0;
        float vitCSum = 0;
        int weight = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 10000;
            label1.AutoSize = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            label1.ImageIndex = random.Next(0, 6);
            weight = fruit.RandomWeightCalculate(weight);
            weightLabel.Text = Convert.ToString(weight + " gr");
            citrusButton.Enabled = true;
            solidFruitButton.Enabled = true;
            timer1.Enabled = true;
            label2.Text = Convert.ToString(second = 60);
            liquidAmountList.Items.Clear();
            pureeAmountList.Items.Clear();
            vitAList.Items.Clear();
            vitCList.Items.Clear();
            liquidAmountSumLabel.Text = Convert.ToString(liquidSum = 0);
            pureeAmountSumLabel.Text = Convert.ToString(pureeSum = 0);
            vitAAmountSumLabel.Text = Convert.ToString(vitASum = 0);
            vitCAmountSumLabel.Text = Convert.ToString(vitCSum = 0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            label2.Text = second.ToString();
            if(second==0)
            {
                timer1.Enabled = false;
                solidFruitButton.Enabled = false;
                citrusButton.Enabled = false;
            }
        }

        private void citrusButton_Click(object sender, EventArgs e)
        {
            
            float liquidW=0;
            if (label1.ImageIndex == 1)
            {
                label1.ImageIndex = random.Next(0, 6);
                liquidW = citrusJuicer.LiquidWeightCalculate(liquidW, weight, pomelo.yield);
                liquidAmountList.Items.Add("Pomelo Liquid Amount: " + liquidW);
                liquidAmountSumLabel.Text = Convert.ToString(liquidSum += liquidW);
                liquidAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", liquidSum));
                vitAAmount = citrusJuicer.VitAAmountCalculate(vitAAmount, liquidW, pomelo.vitA);
                vitAList.Items.Add("Pomelo Vitamin A: " + vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(vitASum += vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitASum));
                vitCAmount = citrusJuicer.VitCAmountCalculate(vitCAmount, liquidW, pomelo.vitC);
                vitCList.Items.Add("Pomelo Vitamin C: " + vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(vitCSum += vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitCSum));
                weight = fruit.RandomWeightCalculate(weight);
                weightLabel.Text = Convert.ToString(weight + " gr");

            }
            else if(label1.ImageIndex == 2)
            {
                label1.ImageIndex = random.Next(0, 6);
                liquidW = citrusJuicer.LiquidWeightCalculate(liquidW, weight, mandarin.yield);
                liquidAmountList.Items.Add("Mandarin Liquid Amount: " + liquidW);
                liquidAmountSumLabel.Text = Convert.ToString(liquidSum += liquidW);
                liquidAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", liquidSum));
                vitAAmount = citrusJuicer.VitAAmountCalculate(vitAAmount, liquidW, mandarin.vitA);
                vitAList.Items.Add("Mandarin Vitamin A: " + vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(vitASum += vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitASum));
                vitCAmount = citrusJuicer.VitCAmountCalculate(vitCAmount, liquidW, mandarin.vitC);
                vitCList.Items.Add("Mandarin Vitamin C: " + vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(vitCSum += vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitCSum));
                weight = fruit.RandomWeightCalculate(weight);
                weightLabel.Text = Convert.ToString(weight + " gr");
            }
            else if(label1.ImageIndex == 3)
            {
                label1.ImageIndex = random.Next(0, 6);
                liquidW = citrusJuicer.LiquidWeightCalculate(liquidW, weight, orange.yield);
                liquidAmountList.Items.Add("Orange Liquid Amount: " + liquidW);
                liquidAmountSumLabel.Text = Convert.ToString(liquidSum += liquidW);
                liquidAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", liquidSum));
                vitAAmount = citrusJuicer.VitAAmountCalculate(vitAAmount, liquidW, orange.vitA);
                vitAList.Items.Add("Orange Vitamin A: " + vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(vitASum += vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitASum));
                vitCAmount = citrusJuicer.VitCAmountCalculate(vitCAmount, liquidW, orange.vitC);
                vitCList.Items.Add("Orange Vitamin C: " + vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(vitCSum += vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitCSum));
                weight = fruit.RandomWeightCalculate(weight);
                weightLabel.Text = Convert.ToString(weight + " gr");
            }
        }

        private void solidFruitButton_Click(object sender, EventArgs e)
        {
            float pureeW = 0;
            if (label1.ImageIndex == 0)
            {
                label1.ImageIndex = random.Next(0, 6);
                pureeW = solidFruitJuicer.PureeWeightCalculate(pureeW, weight, apple.yield);
                pureeAmountList.Items.Add("Apple Puree Amount: " + pureeW);
                pureeAmountSumLabel.Text = Convert.ToString(pureeSum += pureeW);
                pureeAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", pureeSum));
                vitAAmount = solidFruitJuicer.VitAAmountCalculate(vitAAmount, pureeW, apple.vitA);
                vitAList.Items.Add("Apple Vitamin A: " + vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(vitASum += vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitASum));
                vitCAmount = solidFruitJuicer.VitCAmountCalculate(vitCAmount, pureeW, apple.vitC);
                vitCList.Items.Add("Apple Vitamin C: " + vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(vitCSum += vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitCSum));
                weight = fruit.RandomWeightCalculate(weight);
                weightLabel.Text = Convert.ToString(weight + " gr");
            }
            else if (label1.ImageIndex == 4)
            {
                label1.ImageIndex = random.Next(0, 6);
                pureeW = solidFruitJuicer.PureeWeightCalculate(pureeW, weight, pear.yield);
                pureeAmountList.Items.Add("Pear Puree Amount: " + pureeW);
                pureeAmountSumLabel.Text = Convert.ToString(pureeSum += pureeW);
                pureeAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", pureeSum));
                vitAAmount = solidFruitJuicer.VitAAmountCalculate(vitAAmount, pureeW, pear.vitA);
                vitAList.Items.Add("Pear Vitamin A: " + vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(vitASum += vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitASum));
                vitCAmount = solidFruitJuicer.VitCAmountCalculate(vitCAmount, pureeW, pear.vitC);
                vitCList.Items.Add("Pear Vitamin C: " + vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(vitCSum += vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitCSum));
                weight = fruit.RandomWeightCalculate(weight);
                weightLabel.Text = Convert.ToString(weight + " gr");
            }
            else if (label1.ImageIndex == 5)
            {
                label1.ImageIndex = random.Next(0, 6);
                pureeW = solidFruitJuicer.PureeWeightCalculate(pureeW, weight, strawberry.yield);
                pureeAmountList.Items.Add("Strawberry Puree Amount: " + pureeW);
                pureeAmountSumLabel.Text = Convert.ToString(pureeSum += pureeW);
                pureeAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", pureeSum));
                vitAAmount = solidFruitJuicer.VitAAmountCalculate(vitAAmount, pureeW, strawberry.vitA);
                vitAList.Items.Add("Strawberry Vitamin A: " + vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(vitASum += vitAAmount);
                vitAAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitASum));
                vitCAmount = solidFruitJuicer.VitCAmountCalculate(vitCAmount, pureeW, strawberry.vitC);
                vitCList.Items.Add("Strawberry Vitamin C: " + vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(vitCSum += vitCAmount);
                vitCAmountSumLabel.Text = Convert.ToString(string.Format("{0:0.00}", vitCSum));
                weight = fruit.RandomWeightCalculate(weight);
                weightLabel.Text = Convert.ToString(weight + " gr");
            }
        }

        private void pureeAmountList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
