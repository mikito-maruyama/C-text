namespace TaxCalc
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
            priceBox = new TextBox();
            taxPriceBox = new TextBox();
            calcButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // priceBox
            // 
            priceBox.Location = new Point(481, 58);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(359, 23);
            priceBox.TabIndex = 0;
            // 
            // taxPriceBox
            // 
            taxPriceBox.Enabled = false;
            taxPriceBox.Location = new Point(481, 123);
            taxPriceBox.Name = "taxPriceBox";
            taxPriceBox.Size = new Size(359, 23);
            taxPriceBox.TabIndex = 1;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(721, 205);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(119, 35);
            calcButton.TabIndex = 2;
            calcButton.Text = "計算する";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += CalcButtonClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 66);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "税抜き価格";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 140);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "税込み価格";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 469);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calcButton);
            Controls.Add(taxPriceBox);
            Controls.Add(priceBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox priceBox;
        private TextBox taxPriceBox;
        private Button calcButton;
        private Label label1;
        private Label label2;
    }
}