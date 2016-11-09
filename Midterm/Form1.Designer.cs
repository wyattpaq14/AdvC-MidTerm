namespace Midterm
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
            this.btnAutomobile = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnPlane = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblAverageSpeed = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtAverageSpeed = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAutomobile
            // 
            this.btnAutomobile.Location = new System.Drawing.Point(12, 35);
            this.btnAutomobile.Name = "btnAutomobile";
            this.btnAutomobile.Size = new System.Drawing.Size(146, 23);
            this.btnAutomobile.TabIndex = 0;
            this.btnAutomobile.Text = "Automobile";
            this.btnAutomobile.UseVisualStyleBackColor = true;
            this.btnAutomobile.Click += new System.EventHandler(this.btnAutomobile_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(188, 35);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(151, 23);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnPlane
            // 
            this.btnPlane.Location = new System.Drawing.Point(366, 35);
            this.btnPlane.Name = "btnPlane";
            this.btnPlane.Size = new System.Drawing.Size(143, 23);
            this.btnPlane.TabIndex = 2;
            this.btnPlane.Text = "Plane";
            this.btnPlane.UseVisualStyleBackColor = true;
            this.btnPlane.Click += new System.EventHandler(this.btnPlane_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(13, 106);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(85, 13);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "Distance (Miles):";
            // 
            // lblAverageSpeed
            // 
            this.lblAverageSpeed.AutoSize = true;
            this.lblAverageSpeed.Location = new System.Drawing.Point(16, 157);
            this.lblAverageSpeed.Name = "lblAverageSpeed";
            this.lblAverageSpeed.Size = new System.Drawing.Size(84, 13);
            this.lblAverageSpeed.TabIndex = 4;
            this.lblAverageSpeed.Text = "Average Speed:";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(155, 103);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(354, 20);
            this.txtDistance.TabIndex = 5;
            // 
            // txtAverageSpeed
            // 
            this.txtAverageSpeed.Location = new System.Drawing.Point(155, 154);
            this.txtAverageSpeed.Name = "txtAverageSpeed";
            this.txtAverageSpeed.Size = new System.Drawing.Size(354, 20);
            this.txtAverageSpeed.TabIndex = 6;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(19, 229);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(66, 13);
            this.lblDisplay.TabIndex = 7;
            this.lblDisplay.Text = "Final Display";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 354);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtAverageSpeed);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblAverageSpeed);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnPlane);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnAutomobile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutomobile;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnPlane;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblAverageSpeed;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtAverageSpeed;
        private System.Windows.Forms.Label lblDisplay;
    }
}

