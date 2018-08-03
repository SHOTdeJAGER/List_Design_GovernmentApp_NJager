namespace List_Design_GovernmentApp_NJager
{
    partial class PayCalculatorForm
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
            this.lstBxState = new System.Windows.Forms.ListBox();
            this.lblStateSelection = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtBxHours = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtBxHourlyRate = new System.Windows.Forms.TextBox();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.txtBxGrossPay = new System.Windows.Forms.TextBox();
            this.lblFica = new System.Windows.Forms.Label();
            this.txtBxFica = new System.Windows.Forms.TextBox();
            this.txtBxFed = new System.Windows.Forms.TextBox();
            this.lblFed = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBxState = new System.Windows.Forms.TextBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.txtBxHealth = new System.Windows.Forms.TextBox();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.txtBxNetPay = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxState
            // 
            this.lstBxState.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxState.FormattingEnabled = true;
            this.lstBxState.ItemHeight = 19;
            this.lstBxState.Location = new System.Drawing.Point(112, 129);
            this.lstBxState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBxState.Name = "lstBxState";
            this.lstBxState.Size = new System.Drawing.Size(150, 156);
            this.lstBxState.TabIndex = 0;
            this.lstBxState.SelectedIndexChanged += new System.EventHandler(this.lstBxState_SelectedIndexChanged);
            // 
            // lblStateSelection
            // 
            this.lblStateSelection.AutoSize = true;
            this.lblStateSelection.BackColor = System.Drawing.Color.White;
            this.lblStateSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStateSelection.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateSelection.Location = new System.Drawing.Point(119, 82);
            this.lblStateSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStateSelection.Name = "lblStateSelection";
            this.lblStateSelection.Size = new System.Drawing.Size(122, 23);
            this.lblStateSelection.TabIndex = 1;
            this.lblStateSelection.Text = "Select State";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.White;
            this.lblHours.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(374, 82);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(155, 19);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Enter Hours Worked:";
            // 
            // txtBxHours
            // 
            this.txtBxHours.BackColor = System.Drawing.Color.White;
            this.txtBxHours.Location = new System.Drawing.Point(583, 72);
            this.txtBxHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxHours.Name = "txtBxHours";
            this.txtBxHours.Size = new System.Drawing.Size(148, 26);
            this.txtBxHours.TabIndex = 3;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.BackColor = System.Drawing.Color.White;
            this.lblHourlyRate.Location = new System.Drawing.Point(394, 132);
            this.lblHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(143, 19);
            this.lblHourlyRate.TabIndex = 4;
            this.lblHourlyRate.Text = "Enter Hourly Rate:\r\n";
            // 
            // txtBxHourlyRate
            // 
            this.txtBxHourlyRate.BackColor = System.Drawing.Color.White;
            this.txtBxHourlyRate.Location = new System.Drawing.Point(583, 132);
            this.txtBxHourlyRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxHourlyRate.Name = "txtBxHourlyRate";
            this.txtBxHourlyRate.Size = new System.Drawing.Size(148, 26);
            this.txtBxHourlyRate.TabIndex = 5;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.BackColor = System.Drawing.Color.White;
            this.lblGrossPay.Location = new System.Drawing.Point(448, 266);
            this.lblGrossPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(85, 19);
            this.lblGrossPay.TabIndex = 6;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // txtBxGrossPay
            // 
            this.txtBxGrossPay.BackColor = System.Drawing.Color.White;
            this.txtBxGrossPay.Location = new System.Drawing.Point(583, 256);
            this.txtBxGrossPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxGrossPay.Name = "txtBxGrossPay";
            this.txtBxGrossPay.Size = new System.Drawing.Size(148, 26);
            this.txtBxGrossPay.TabIndex = 7;
            // 
            // lblFica
            // 
            this.lblFica.AutoSize = true;
            this.lblFica.BackColor = System.Drawing.Color.White;
            this.lblFica.Location = new System.Drawing.Point(454, 312);
            this.lblFica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFica.Name = "lblFica";
            this.lblFica.Size = new System.Drawing.Size(86, 19);
            this.lblFica.TabIndex = 8;
            this.lblFica.Text = "FICA Tax:";
            // 
            // txtBxFica
            // 
            this.txtBxFica.BackColor = System.Drawing.Color.White;
            this.txtBxFica.Location = new System.Drawing.Point(583, 301);
            this.txtBxFica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxFica.Name = "txtBxFica";
            this.txtBxFica.Size = new System.Drawing.Size(148, 26);
            this.txtBxFica.TabIndex = 9;
            // 
            // txtBxFed
            // 
            this.txtBxFed.BackColor = System.Drawing.Color.White;
            this.txtBxFed.Location = new System.Drawing.Point(583, 353);
            this.txtBxFed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxFed.Name = "txtBxFed";
            this.txtBxFed.Size = new System.Drawing.Size(148, 26);
            this.txtBxFed.TabIndex = 10;
            // 
            // lblFed
            // 
            this.lblFed.AutoSize = true;
            this.lblFed.BackColor = System.Drawing.Color.White;
            this.lblFed.Location = new System.Drawing.Point(436, 364);
            this.lblFed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(100, 19);
            this.lblFed.TabIndex = 11;
            this.lblFed.Text = "Federal Tax:\r\n";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(454, 410);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(88, 19);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State Tax:\r\n";
            // 
            // txtBxState
            // 
            this.txtBxState.BackColor = System.Drawing.Color.White;
            this.txtBxState.Location = new System.Drawing.Point(583, 400);
            this.txtBxState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxState.Name = "txtBxState";
            this.txtBxState.Size = new System.Drawing.Size(148, 26);
            this.txtBxState.TabIndex = 13;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(436, 457);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(101, 19);
            this.lblHealth.TabIndex = 14;
            this.lblHealth.Text = "Health Care ";
            // 
            // txtBxHealth
            // 
            this.txtBxHealth.BackColor = System.Drawing.Color.White;
            this.txtBxHealth.Location = new System.Drawing.Point(583, 447);
            this.txtBxHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxHealth.Name = "txtBxHealth";
            this.txtBxHealth.Size = new System.Drawing.Size(148, 26);
            this.txtBxHealth.TabIndex = 15;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.BackColor = System.Drawing.Color.White;
            this.lblNetPay.Location = new System.Drawing.Point(463, 509);
            this.lblNetPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(71, 19);
            this.lblNetPay.TabIndex = 16;
            this.lblNetPay.Text = "Net Pay \r\n";
            // 
            // txtBxNetPay
            // 
            this.txtBxNetPay.BackColor = System.Drawing.Color.White;
            this.txtBxNetPay.Location = new System.Drawing.Point(583, 498);
            this.txtBxNetPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxNetPay.Name = "txtBxNetPay";
            this.txtBxNetPay.Size = new System.Drawing.Size(148, 26);
            this.txtBxNetPay.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnCalculate.FlatAppearance.BorderSize = 3;
            this.btnCalculate.Location = new System.Drawing.Point(882, 67);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 34);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(882, 127);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PayCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 657);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBxNetPay);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.txtBxHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.txtBxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFed);
            this.Controls.Add(this.txtBxFed);
            this.Controls.Add(this.txtBxFica);
            this.Controls.Add(this.lblFica);
            this.Controls.Add(this.txtBxGrossPay);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.txtBxHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.txtBxHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblStateSelection);
            this.Controls.Add(this.lstBxState);
            this.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PayCalculatorForm";
            this.Text = "How Much is the Government Robbing You?";
            this.Load += new System.EventHandler(this.StateGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PayCalculator newPayCalculator; //this was added 
        private System.Windows.Forms.ListBox lstBxState;
        private System.Windows.Forms.Label lblStateSelection;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtBxHours;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtBxHourlyRate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.TextBox txtBxGrossPay;
        private System.Windows.Forms.Label lblFica;
        private System.Windows.Forms.TextBox txtBxFica;
        private System.Windows.Forms.TextBox txtBxFed;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtBxState;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox txtBxHealth;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox txtBxNetPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
    }
}

