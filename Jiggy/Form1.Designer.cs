namespace Jiggy
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            mouseTimer = new System.Windows.Forms.Timer(components);
            numPixels = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPixels).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 29);
            button1.Name = "button1";
            button1.Size = new Size(111, 48);
            button1.TabIndex = 0;
            button1.Text = "Start/Stop (F6)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mouseTimer
            // 
            mouseTimer.Interval = 20000;
            mouseTimer.Tick += mouseTimer_Tick;
            // 
            // numPixels
            // 
            numPixels.Location = new Point(246, 54);
            numPixels.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numPixels.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPixels.Name = "numPixels";
            numPixels.Size = new Size(115, 23);
            numPixels.TabIndex = 2;
            numPixels.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 36);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Pixels";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 196);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "V1.0.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(numPixels);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Jiggy";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)numPixels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer mouseTimer;
        private NumericUpDown numPixels;
        private Label label2;
        private Label label1;
    }
}
