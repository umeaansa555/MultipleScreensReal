namespace MultipleScreensReal
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.returnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(48, 53);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(107, 68);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            this.returnButton.Enter += new System.EventHandler(this.returnButton_Enter);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(48, 127);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 68);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // playsLabel
            // 
            this.playsLabel.AutoSize = true;
            this.playsLabel.Location = new System.Drawing.Point(79, 220);
            this.playsLabel.Name = "playsLabel";
            this.playsLabel.Size = new System.Drawing.Size(44, 16);
            this.playsLabel.TabIndex = 2;
            this.playsLabel.Text = "label1";
            this.playsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.playsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(212, 277);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label playsLabel;
    }
}
