namespace Lutfur_Mojumder_Vet
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
            textCustomerName = new TextBox();
            label2 = new Label();
            textNumWidgets = new TextBox();
            lstOut = new ListBox();
            btnCalc = new Button();
            btnReset = new Button();
            btnClear = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 79);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Animal weight";
            label1.Click += label1_Click;
            // 
            // textCustomerName
            // 
            textCustomerName.Location = new Point(213, 75);
            textCustomerName.Margin = new Padding(3, 4, 3, 4);
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new Size(114, 27);
            textCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 132);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 2;
            label2.Text = "Vaccine dose price";
            // 
            // textNumWidgets
            // 
            textNumWidgets.Location = new Point(213, 121);
            textNumWidgets.Margin = new Padding(3, 4, 3, 4);
            textNumWidgets.Name = "textNumWidgets";
            textNumWidgets.Size = new Size(114, 27);
            textNumWidgets.TabIndex = 3;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(56, 269);
            lstOut.Margin = new Padding(3, 4, 3, 4);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(270, 124);
            lstOut.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(55, 440);
            btnCalc.Margin = new Padding(3, 4, 3, 4);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(86, 31);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "calculate Total";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(200, 440);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(353, 440);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 7;
            btnClear.Text = "Quit";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(55, 440);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 55);
            button1.TabIndex = 5;
            button1.Text = "&Calculate Total";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(200, 440);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 55);
            button2.TabIndex = 6;
            button2.Text = "&Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(353, 440);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 55);
            button3.TabIndex = 7;
            button3.Text = "&Quit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 741);
            Controls.Add(button3);
            Controls.Add(btnClear);
            Controls.Add(button2);
            Controls.Add(btnReset);
            Controls.Add(button1);
            Controls.Add(btnCalc);
            Controls.Add(lstOut);
            Controls.Add(textNumWidgets);
            Controls.Add(label2);
            Controls.Add(textCustomerName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Lutfur Mojumder-ICA1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textCustomerName;
        private Label label2;
        private TextBox textNumWidgets;
        private ListBox lstOut;
        private Button btnCalc;
        private Button btnReset;
        private Button btnClear;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
