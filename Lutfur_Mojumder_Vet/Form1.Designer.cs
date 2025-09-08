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
            label1.Location = new Point(49, 59);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            label1.Click += label1_Click;
            // 
            // textCustomerName
            // 
            textCustomerName.Location = new Point(186, 56);
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new Size(100, 23);
            textCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 99);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of Widgets";
            // 
            // textNumWidgets
            // 
            textNumWidgets.Location = new Point(186, 91);
            textNumWidgets.Name = "textNumWidgets";
            textNumWidgets.Size = new Size(100, 23);
            textNumWidgets.TabIndex = 3;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(49, 202);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(237, 94);
            lstOut.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(48, 330);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "calculate Total";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(175, 330);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(309, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Quit";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(48, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 5;
            button1.Text = "calculate Total";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(175, 330);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 6;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(309, 330);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 7;
            button3.Text = "Quit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
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
            Name = "Form1";
            Text = "Lutfur Widgets-Vet office 2 Form";
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
