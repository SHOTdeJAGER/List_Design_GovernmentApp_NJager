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
            this.lstBxState.FormattingEnabled = true;
            this.lstBxState.Location = new System.Drawing.Point(86, 56);
            this.lstBxState.Name = "lstBxState";
            this.lstBxState.Size = new System.Drawing.Size(62, 82);
            this.lstBxState.TabIndex = 0;
            this.lstBxState.SelectedIndexChanged += new System.EventHandler(this.lstBxState_SelectedIndexChanged);
            // 
            // lblStateSelection
            // 
            this.lblStateSelection.AutoSize = true;
            this.lblStateSelection.Location = new System.Drawing.Point(83, 29);
            this.lblStateSelection.Name = "lblStateSelection";
            this.lblStateSelection.Size = new System.Drawing.Size(65, 13);
            this.lblStateSelection.TabIndex = 1;
            this.lblStateSelection.Text = "Select State";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(250, 56);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(107, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Enter Hours Worked:";
            // 
            // txtBxHours
            // 
            this.txtBxHours.Location = new System.Drawing.Point(389, 49);
            this.txtBxHours.Name = "txtBxHours";
            this.txtBxHours.Size = new System.Drawing.Size(100, 20);
            this.txtBxHours.TabIndex = 3;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(263, 90);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(94, 13);
            this.lblHourlyRate.TabIndex = 4;
            this.lblHourlyRate.Text = "Enter Hourly Rate:\r\n";
            // 
            // txtBxHourlyRate
            // 
            this.txtBxHourlyRate.Location = new System.Drawing.Point(389, 90);
            this.txtBxHourlyRate.Name = "txtBxHourlyRate";
            this.txtBxHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtBxHourlyRate.TabIndex = 5;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(299, 182);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(58, 13);
            this.lblGrossPay.TabIndex = 6;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // txtBxGrossPay
            // 
            this.txtBxGrossPay.Location = new System.Drawing.Point(389, 175);
            this.txtBxGrossPay.Name = "txtBxGrossPay";
            this.txtBxGrossPay.Size = new System.Drawing.Size(100, 20);
            this.txtBxGrossPay.TabIndex = 7;
            // 
            // lblFica
            // 
            this.lblFica.AutoSize = true;
            this.lblFica.Location = new System.Drawing.Point(303, 213);
            this.lblFica.Name = "lblFica";
            this.lblFica.Size = new System.Drawing.Size(54, 13);
            this.lblFica.TabIndex = 8;
            this.lblFica.Text = "FICA Tax:";
            // 
            // txtBxFica
            // 
            this.txtBxFica.Location = new System.Drawing.Point(389, 206);
            this.txtBxFica.Name = "txtBxFica";
            this.txtBxFica.Size = new System.Drawing.Size(100, 20);
            this.txtBxFica.TabIndex = 9;
            // 
            // txtBxFed
            // 
            this.txtBxFed.Location = new System.Drawing.Point(389, 242);
            this.txtBxFed.Name = "txtBxFed";
            this.txtBxFed.Size = new System.Drawing.Size(100, 20);
            this.txtBxFed.TabIndex = 10;
            // 
            // lblFed
            // 
            this.lblFed.AutoSize = true;
            this.lblFed.Location = new System.Drawing.Point(291, 249);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(66, 13);
            this.lblFed.TabIndex = 11;
            this.lblFed.Text = "Federal Tax:\r\n";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(303, 281);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(56, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State Tax:\r\n";
            // 
            // txtBxState
            // 
            this.txtBxState.Location = new System.Drawing.Point(389, 274);
            this.txtBxState.Name = "txtBxState";
            this.txtBxState.Size = new System.Drawing.Size(100, 20);
            this.txtBxState.TabIndex = 13;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(291, 313);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(66, 13);
            this.lblHealth.TabIndex = 14;
            this.lblHealth.Text = "Health Care ";
            // 
            // txtBxHealth
            // 
            this.txtBxHealth.Location = new System.Drawing.Point(389, 306);
            this.txtBxHealth.Name = "txtBxHealth";
            this.txtBxHealth.Size = new System.Drawing.Size(100, 20);
            this.txtBxHealth.TabIndex = 15;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(309, 348);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(48, 13);
            this.lblNetPay.TabIndex = 16;
            this.lblNetPay.Text = "Net Pay \r\n";
            // 
            // txtBxNetPay
            // 
            this.txtBxNetPay.Location = new System.Drawing.Point(389, 341);
            this.txtBxNetPay.Name = "txtBxNetPay";
            this.txtBxNetPay.Size = new System.Drawing.Size(100, 20);
            this.txtBxNetPay.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(588, 46);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(588, 87);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PayCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

