namespace Pizza_s_Home
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pizzaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wingsInput = new System.Windows.Forms.TextBox();
            this.calulateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.moneyText = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.printLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.subOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza\'s hut";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Pizza:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pizzaInput
            // 
            this.pizzaInput.Location = new System.Drawing.Point(93, 72);
            this.pizzaInput.Name = "pizzaInput";
            this.pizzaInput.Size = new System.Drawing.Size(40, 20);
            this.pizzaInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Drinks:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksInput
            // 
            this.drinksInput.Location = new System.Drawing.Point(93, 98);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(40, 20);
            this.drinksInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Wings";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wingsInput
            // 
            this.wingsInput.Location = new System.Drawing.Point(93, 124);
            this.wingsInput.Name = "wingsInput";
            this.wingsInput.Size = new System.Drawing.Size(40, 20);
            this.wingsInput.TabIndex = 7;
            // 
            // calulateButton
            // 
            this.calulateButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.calulateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.calulateButton.Location = new System.Drawing.Point(1, 150);
            this.calulateButton.Name = "calulateButton";
            this.calulateButton.Size = new System.Drawing.Size(132, 23);
            this.calulateButton.TabIndex = 8;
            this.calulateButton.Text = "Calulate Totals";
            this.calulateButton.UseVisualStyleBackColor = true;
            this.calulateButton.Click += new System.EventHandler(this.calulateButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(1, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 12);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-2, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tendered:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moneyText
            // 
            this.moneyText.Location = new System.Drawing.Point(76, 294);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(57, 20);
            this.moneyText.TabIndex = 12;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(1, 320);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(132, 21);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Calulate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Snow;
            this.changeOutput.Location = new System.Drawing.Point(4, 344);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(129, 23);
            this.changeOutput.TabIndex = 14;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(4, 370);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(129, 35);
            this.printButton.TabIndex = 15;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printLabel
            // 
            this.printLabel.BackColor = System.Drawing.Color.Snow;
            this.printLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLabel.Location = new System.Drawing.Point(139, 72);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(223, 269);
            this.printLabel.TabIndex = 16;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(137, 344);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(225, 35);
            this.newOrderButton.TabIndex = 17;
            this.newOrderButton.Text = "New Order ";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // subOutput
            // 
            this.subOutput.BackColor = System.Drawing.Color.Snow;
            this.subOutput.Location = new System.Drawing.Point(4, 176);
            this.subOutput.Name = "subOutput";
            this.subOutput.Size = new System.Drawing.Size(129, 33);
            this.subOutput.TabIndex = 18;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Snow;
            this.taxOutput.Location = new System.Drawing.Point(4, 209);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(129, 34);
            this.taxOutput.TabIndex = 19;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Snow;
            this.totalOutput.Location = new System.Drawing.Point(4, 243);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(129, 36);
            this.totalOutput.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(379, 410);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subOutput);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calulateButton);
            this.Controls.Add(this.wingsInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pizzaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza\'s Hut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pizzaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wingsInput;
        private System.Windows.Forms.Button calulateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox moneyText;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label printLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label subOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
    }
}

