namespace Helloworld
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
            helloButton = new Button();
            hellowLabel = new Label();
            SuspendLayout();
            // 
            // helloButton
            // 
            helloButton.Cursor = Cursors.IBeam;
            helloButton.Location = new Point(308, 274);
            helloButton.Name = "helloButton";
            helloButton.Size = new Size(75, 23);
            helloButton.TabIndex = 0;
            helloButton.Text = "ボタン";
            helloButton.UseVisualStyleBackColor = true;
            helloButton.Click += button1_Click;
            // 
            // hellowLabel
            // 
            hellowLabel.AutoSize = true;
            hellowLabel.Location = new Point(308, 137);
            hellowLabel.Name = "hellowLabel";
            hellowLabel.Size = new Size(63, 15);
            hellowLabel.TabIndex = 1;
            hellowLabel.Text = "helloworld";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hellowLabel);
            Controls.Add(helloButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button helloButton;
        private Label hellowLabel;
    }
}