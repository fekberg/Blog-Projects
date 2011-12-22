namespace InversionOfControl
{
    partial class OrderForm
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
            this.ProcessOrder = new System.Windows.Forms.Button();
            this.orderInformationLabel = new System.Windows.Forms.Label();
            this.orderInformation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProcessOrder
            // 
            this.ProcessOrder.Location = new System.Drawing.Point(108, 51);
            this.ProcessOrder.Name = "ProcessOrder";
            this.ProcessOrder.Size = new System.Drawing.Size(75, 23);
            this.ProcessOrder.TabIndex = 0;
            this.ProcessOrder.Text = "Process Order";
            this.ProcessOrder.UseVisualStyleBackColor = true;
            this.ProcessOrder.Click += new System.EventHandler(this.ProcessOrderClick);
            // 
            // orderInformationLabel
            // 
            this.orderInformationLabel.AutoSize = true;
            this.orderInformationLabel.Location = new System.Drawing.Point(12, 9);
            this.orderInformationLabel.Name = "orderInformationLabel";
            this.orderInformationLabel.Size = new System.Drawing.Size(171, 13);
            this.orderInformationLabel.TabIndex = 1;
            this.orderInformationLabel.Text = "Please write your order information:";
            // 
            // orderInformation
            // 
            this.orderInformation.Location = new System.Drawing.Point(15, 25);
            this.orderInformation.Name = "orderInformation";
            this.orderInformation.Size = new System.Drawing.Size(168, 20);
            this.orderInformation.TabIndex = 2;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 80);
            this.Controls.Add(this.orderInformation);
            this.Controls.Add(this.orderInformationLabel);
            this.Controls.Add(this.ProcessOrder);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessOrder;
        private System.Windows.Forms.Label orderInformationLabel;
        private System.Windows.Forms.TextBox orderInformation;
    }
}

