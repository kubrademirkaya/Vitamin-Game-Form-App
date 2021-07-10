
namespace VitaminGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.citrusButton = new System.Windows.Forms.Button();
            this.solidFruitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.liquidAmountList = new System.Windows.Forms.ListBox();
            this.pureeAmountList = new System.Windows.Forms.ListBox();
            this.vitAList = new System.Windows.Forms.ListBox();
            this.vitCList = new System.Windows.Forms.ListBox();
            this.vitALabel = new System.Windows.Forms.Label();
            this.vitCLabel = new System.Windows.Forms.Label();
            this.liquidAmountSum = new System.Windows.Forms.Label();
            this.pureeAmountSum = new System.Windows.Forms.Label();
            this.vitCAmountSum = new System.Windows.Forms.Label();
            this.vitAAmountSum = new System.Windows.Forms.Label();
            this.vitAAmountSumLabel = new System.Windows.Forms.Label();
            this.pureeAmountSumLabel = new System.Windows.Forms.Label();
            this.vitCAmountSumLabel = new System.Windows.Forms.Label();
            this.liquidAmountSumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Black;
            this.ımageList1.Images.SetKeyName(0, "apple.jpg");
            this.ımageList1.Images.SetKeyName(1, "grapefruit.jpg");
            this.ımageList1.Images.SetKeyName(2, "mandarin.jpg");
            this.ımageList1.Images.SetKeyName(3, "orange.jpg");
            this.ımageList1.Images.SetKeyName(4, "pear.jpg");
            this.ımageList1.Images.SetKeyName(5, "strawberry.jpg");
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ImageList = this.ımageList1;
            this.label1.Location = new System.Drawing.Point(521, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 252);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Maroon;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.LightCoral;
            this.startButton.Location = new System.Drawing.Point(563, 374);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 49);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // citrusButton
            // 
            this.citrusButton.BackColor = System.Drawing.Color.Maroon;
            this.citrusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.citrusButton.ForeColor = System.Drawing.Color.LightCoral;
            this.citrusButton.Location = new System.Drawing.Point(311, 169);
            this.citrusButton.Name = "citrusButton";
            this.citrusButton.Size = new System.Drawing.Size(159, 38);
            this.citrusButton.TabIndex = 2;
            this.citrusButton.Text = "Citrus Juicer";
            this.citrusButton.UseVisualStyleBackColor = false;
            this.citrusButton.Click += new System.EventHandler(this.citrusButton_Click);
            // 
            // solidFruitButton
            // 
            this.solidFruitButton.BackColor = System.Drawing.Color.Maroon;
            this.solidFruitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.solidFruitButton.ForeColor = System.Drawing.Color.LightCoral;
            this.solidFruitButton.Location = new System.Drawing.Point(311, 386);
            this.solidFruitButton.Name = "solidFruitButton";
            this.solidFruitButton.Size = new System.Drawing.Size(159, 38);
            this.solidFruitButton.TabIndex = 3;
            this.solidFruitButton.Text = "Solid Fruit Juicer";
            this.solidFruitButton.UseVisualStyleBackColor = false;
            this.solidFruitButton.Click += new System.EventHandler(this.solidFruitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(677, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // liquidAmountList
            // 
            this.liquidAmountList.FormattingEnabled = true;
            this.liquidAmountList.ItemHeight = 15;
            this.liquidAmountList.Location = new System.Drawing.Point(298, 69);
            this.liquidAmountList.Name = "liquidAmountList";
            this.liquidAmountList.Size = new System.Drawing.Size(188, 94);
            this.liquidAmountList.TabIndex = 5;
            // 
            // pureeAmountList
            // 
            this.pureeAmountList.FormattingEnabled = true;
            this.pureeAmountList.ItemHeight = 15;
            this.pureeAmountList.Location = new System.Drawing.Point(298, 286);
            this.pureeAmountList.Name = "pureeAmountList";
            this.pureeAmountList.Size = new System.Drawing.Size(188, 94);
            this.pureeAmountList.TabIndex = 6;
            this.pureeAmountList.SelectedIndexChanged += new System.EventHandler(this.pureeAmountList_SelectedIndexChanged);
            // 
            // vitAList
            // 
            this.vitAList.FormattingEnabled = true;
            this.vitAList.ItemHeight = 15;
            this.vitAList.Location = new System.Drawing.Point(54, 69);
            this.vitAList.Name = "vitAList";
            this.vitAList.Size = new System.Drawing.Size(188, 94);
            this.vitAList.TabIndex = 7;
            // 
            // vitCList
            // 
            this.vitCList.FormattingEnabled = true;
            this.vitCList.ItemHeight = 15;
            this.vitCList.Location = new System.Drawing.Point(54, 286);
            this.vitCList.Name = "vitCList";
            this.vitCList.Size = new System.Drawing.Size(188, 94);
            this.vitCList.TabIndex = 8;
            // 
            // vitALabel
            // 
            this.vitALabel.AutoSize = true;
            this.vitALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vitALabel.Location = new System.Drawing.Point(87, 176);
            this.vitALabel.Name = "vitALabel";
            this.vitALabel.Size = new System.Drawing.Size(117, 21);
            this.vitALabel.TabIndex = 9;
            this.vitALabel.Text = "Vitamin A (iu)";
            // 
            // vitCLabel
            // 
            this.vitCLabel.AutoSize = true;
            this.vitCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vitCLabel.Location = new System.Drawing.Point(87, 393);
            this.vitCLabel.Name = "vitCLabel";
            this.vitCLabel.Size = new System.Drawing.Size(126, 21);
            this.vitCLabel.TabIndex = 10;
            this.vitCLabel.Text = "Vitamin C (mg)";
            // 
            // liquidAmountSum
            // 
            this.liquidAmountSum.AutoSize = true;
            this.liquidAmountSum.BackColor = System.Drawing.Color.LightCoral;
            this.liquidAmountSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.liquidAmountSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.liquidAmountSum.ForeColor = System.Drawing.Color.Firebrick;
            this.liquidAmountSum.Location = new System.Drawing.Point(298, 20);
            this.liquidAmountSum.Name = "liquidAmountSum";
            this.liquidAmountSum.Size = new System.Drawing.Size(196, 23);
            this.liquidAmountSum.TabIndex = 11;
            this.liquidAmountSum.Text = "Total Amount of Liquid: ";
            // 
            // pureeAmountSum
            // 
            this.pureeAmountSum.AutoSize = true;
            this.pureeAmountSum.BackColor = System.Drawing.Color.LightCoral;
            this.pureeAmountSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pureeAmountSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pureeAmountSum.ForeColor = System.Drawing.Color.Firebrick;
            this.pureeAmountSum.Location = new System.Drawing.Point(298, 237);
            this.pureeAmountSum.Name = "pureeAmountSum";
            this.pureeAmountSum.Size = new System.Drawing.Size(192, 23);
            this.pureeAmountSum.TabIndex = 12;
            this.pureeAmountSum.Text = "Total Amount of Puree: ";
            // 
            // vitCAmountSum
            // 
            this.vitCAmountSum.AutoSize = true;
            this.vitCAmountSum.BackColor = System.Drawing.Color.LightCoral;
            this.vitCAmountSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vitCAmountSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vitCAmountSum.ForeColor = System.Drawing.Color.Firebrick;
            this.vitCAmountSum.Location = new System.Drawing.Point(54, 237);
            this.vitCAmountSum.Name = "vitCAmountSum";
            this.vitCAmountSum.Size = new System.Drawing.Size(180, 23);
            this.vitCAmountSum.TabIndex = 13;
            this.vitCAmountSum.Text = "Total Amount of VitC: ";
            // 
            // vitAAmountSum
            // 
            this.vitAAmountSum.AutoSize = true;
            this.vitAAmountSum.BackColor = System.Drawing.Color.LightCoral;
            this.vitAAmountSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vitAAmountSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vitAAmountSum.ForeColor = System.Drawing.Color.Firebrick;
            this.vitAAmountSum.Location = new System.Drawing.Point(54, 20);
            this.vitAAmountSum.Name = "vitAAmountSum";
            this.vitAAmountSum.Size = new System.Drawing.Size(181, 23);
            this.vitAAmountSum.TabIndex = 14;
            this.vitAAmountSum.Text = "Total Amount of VitA: ";
            // 
            // vitAAmountSumLabel
            // 
            this.vitAAmountSumLabel.AutoSize = true;
            this.vitAAmountSumLabel.BackColor = System.Drawing.Color.LightCoral;
            this.vitAAmountSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vitAAmountSumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vitAAmountSumLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.vitAAmountSumLabel.Location = new System.Drawing.Point(54, 43);
            this.vitAAmountSumLabel.Name = "vitAAmountSumLabel";
            this.vitAAmountSumLabel.Size = new System.Drawing.Size(21, 23);
            this.vitAAmountSumLabel.TabIndex = 15;
            this.vitAAmountSumLabel.Text = "0";
            // 
            // pureeAmountSumLabel
            // 
            this.pureeAmountSumLabel.AutoSize = true;
            this.pureeAmountSumLabel.BackColor = System.Drawing.Color.LightCoral;
            this.pureeAmountSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pureeAmountSumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pureeAmountSumLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.pureeAmountSumLabel.Location = new System.Drawing.Point(298, 260);
            this.pureeAmountSumLabel.Name = "pureeAmountSumLabel";
            this.pureeAmountSumLabel.Size = new System.Drawing.Size(21, 23);
            this.pureeAmountSumLabel.TabIndex = 16;
            this.pureeAmountSumLabel.Text = "0";
            // 
            // vitCAmountSumLabel
            // 
            this.vitCAmountSumLabel.AutoSize = true;
            this.vitCAmountSumLabel.BackColor = System.Drawing.Color.LightCoral;
            this.vitCAmountSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vitCAmountSumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vitCAmountSumLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.vitCAmountSumLabel.Location = new System.Drawing.Point(54, 260);
            this.vitCAmountSumLabel.Name = "vitCAmountSumLabel";
            this.vitCAmountSumLabel.Size = new System.Drawing.Size(21, 23);
            this.vitCAmountSumLabel.TabIndex = 17;
            this.vitCAmountSumLabel.Text = "0";
            // 
            // liquidAmountSumLabel
            // 
            this.liquidAmountSumLabel.AutoSize = true;
            this.liquidAmountSumLabel.BackColor = System.Drawing.Color.LightCoral;
            this.liquidAmountSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.liquidAmountSumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.liquidAmountSumLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.liquidAmountSumLabel.Location = new System.Drawing.Point(298, 43);
            this.liquidAmountSumLabel.Name = "liquidAmountSumLabel";
            this.liquidAmountSumLabel.Size = new System.Drawing.Size(21, 23);
            this.liquidAmountSumLabel.TabIndex = 18;
            this.liquidAmountSumLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(563, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 45);
            this.label3.TabIndex = 19;
            this.label3.Text = "TIME:";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightLbl.Location = new System.Drawing.Point(540, 276);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(131, 40);
            this.weightLbl.TabIndex = 20;
            this.weightLbl.Text = "Weight: ";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightLabel.Location = new System.Drawing.Point(677, 274);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(36, 42);
            this.weightLabel.TabIndex = 21;
            this.weightLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liquidAmountSumLabel);
            this.Controls.Add(this.vitCAmountSumLabel);
            this.Controls.Add(this.pureeAmountSumLabel);
            this.Controls.Add(this.vitAAmountSumLabel);
            this.Controls.Add(this.vitAAmountSum);
            this.Controls.Add(this.vitCAmountSum);
            this.Controls.Add(this.pureeAmountSum);
            this.Controls.Add(this.liquidAmountSum);
            this.Controls.Add(this.vitCLabel);
            this.Controls.Add(this.vitALabel);
            this.Controls.Add(this.vitCList);
            this.Controls.Add(this.vitAList);
            this.Controls.Add(this.pureeAmountList);
            this.Controls.Add(this.liquidAmountList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.solidFruitButton);
            this.Controls.Add(this.citrusButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vitamin Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button citrusButton;
        private System.Windows.Forms.Button solidFruitButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox liquidAmountList;
        private System.Windows.Forms.ListBox pureeAmountList;
        private System.Windows.Forms.ListBox vitAList;
        private System.Windows.Forms.ListBox vitCList;
        private System.Windows.Forms.Label vitALabel;
        private System.Windows.Forms.Label vitCLabel;
        private System.Windows.Forms.Label liquidAmountSum;
        private System.Windows.Forms.Label pureeAmountSum;
        private System.Windows.Forms.Label vitCAmountSum;
        private System.Windows.Forms.Label vitAAmountSum;
        private System.Windows.Forms.Label vitAAmountSumLabel;
        private System.Windows.Forms.Label pureeAmountSumLabel;
        private System.Windows.Forms.Label vitCAmountSumLabel;
        private System.Windows.Forms.Label liquidAmountSumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label weightLabel;
    }
}

