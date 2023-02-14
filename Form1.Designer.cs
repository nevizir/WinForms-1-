namespace WinForms_1_
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.peopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.economRadioButon = new System.Windows.Forms.RadioButton();
            this.standartRadioButton = new System.Windows.Forms.RadioButton();
            this.luxRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.notesText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.policyCheckBox = new System.Windows.Forms.CheckBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(206, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(198, 27);
            this.nameBox.TabIndex = 1;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(206, 102);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(198, 27);
            this.surnameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Information:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(238, 167);
            this.phoneTextBox.Mask = "+ 38 (000) 000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(139, 27);
            this.phoneTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of people:";
            // 
            // peopleUpDown
            // 
            this.peopleUpDown.Location = new System.Drawing.Point(220, 219);
            this.peopleUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.peopleUpDown.Name = "peopleUpDown";
            this.peopleUpDown.Size = new System.Drawing.Size(150, 27);
            this.peopleUpDown.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type:";
            // 
            // economRadioButon
            // 
            this.economRadioButon.AutoSize = true;
            this.economRadioButon.Location = new System.Drawing.Point(103, 281);
            this.economRadioButon.Name = "economRadioButon";
            this.economRadioButon.Size = new System.Drawing.Size(84, 24);
            this.economRadioButon.TabIndex = 9;
            this.economRadioButon.TabStop = true;
            this.economRadioButon.Text = "econom";
            this.economRadioButon.UseVisualStyleBackColor = true;
            // 
            // standartRadioButton
            // 
            this.standartRadioButton.AutoSize = true;
            this.standartRadioButton.Location = new System.Drawing.Point(206, 281);
            this.standartRadioButton.Name = "standartRadioButton";
            this.standartRadioButton.Size = new System.Drawing.Size(84, 24);
            this.standartRadioButton.TabIndex = 10;
            this.standartRadioButton.TabStop = true;
            this.standartRadioButton.Text = "standart";
            this.standartRadioButton.UseVisualStyleBackColor = true;
            // 
            // luxRadioButton
            // 
            this.luxRadioButton.AutoSize = true;
            this.luxRadioButton.Location = new System.Drawing.Point(314, 281);
            this.luxRadioButton.Name = "luxRadioButton";
            this.luxRadioButton.Size = new System.Drawing.Size(49, 24);
            this.luxRadioButton.TabIndex = 11;
            this.luxRadioButton.TabStop = true;
            this.luxRadioButton.Text = "lux";
            this.luxRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Length of stay at the hotel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Special notes:";
            // 
            // notesText
            // 
            this.notesText.Location = new System.Drawing.Point(165, 346);
            this.notesText.Multiline = true;
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(264, 71);
            this.notesText.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 438);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // policyCheckBox
            // 
            this.policyCheckBox.AutoSize = true;
            this.policyCheckBox.Location = new System.Drawing.Point(12, 519);
            this.policyCheckBox.Name = "policyCheckBox";
            this.policyCheckBox.Size = new System.Drawing.Size(119, 24);
            this.policyCheckBox.TabIndex = 17;
            this.policyCheckBox.Text = "Accept Policy";
            this.policyCheckBox.UseVisualStyleBackColor = true;
            this.policyCheckBox.CheckedChanged += new System.EventHandler(this.policyCheckBox_CheckedChanged);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(335, 514);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(94, 29);
            this.orderButton.TabIndex = 18;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(196, 516);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(94, 29);
            this.cancelbutton.TabIndex = 19;
            this.cancelbutton.Text = "cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(512, 563);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.policyCheckBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.notesText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.luxRadioButton);
            this.Controls.Add(this.standartRadioButton);
            this.Controls.Add(this.economRadioButon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.peopleUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private TextBox surnameBox;
        private Label label2;
        private Label label3;
        private MaskedTextBox phoneTextBox;
        private Label label4;
        private NumericUpDown peopleUpDown;
        private Label label5;
        private RadioButton economRadioButon;
        private RadioButton standartRadioButton;
        private RadioButton luxRadioButton;
        private Label label6;
        private Label label7;
        private TextBox notesText;
        private DateTimePicker dateTimePicker1;
        private CheckBox policyCheckBox;
        private Button orderButton;
        private Button cancelbutton;
    }
}