namespace WinFormsApp_GuessNumber
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            buttonOK = new Button();
            textBox1 = new TextBox();
            buttonGO = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(739, 70);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(buttonOK);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(30, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(193, 38);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "buttonOK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // buttonGO
            // 
            buttonGO.Location = new Point(694, 102);
            buttonGO.Name = "buttonGO";
            buttonGO.Size = new Size(75, 23);
            buttonGO.TabIndex = 2;
            buttonGO.Text = "buttonGO";
            buttonGO.UseVisualStyleBackColor = true;
            buttonGO.Click += buttonGO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGO);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button buttonOK;
        private TextBox textBox1;
        private Button buttonGO;
    }
}
