namespace BlockBreaker
{
    partial class MainScreen
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
            this.originalButton = new System.Windows.Forms.Button();
            this.powerUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalButton
            // 
            this.originalButton.Location = new System.Drawing.Point(229, 273);
            this.originalButton.Name = "originalButton";
            this.originalButton.Size = new System.Drawing.Size(200, 50);
            this.originalButton.TabIndex = 0;
            this.originalButton.Text = "original";
            this.originalButton.UseVisualStyleBackColor = true;
            // 
            // powerUpButton
            // 
            this.powerUpButton.Location = new System.Drawing.Point(229, 416);
            this.powerUpButton.Name = "powerUpButton";
            this.powerUpButton.Size = new System.Drawing.Size(200, 50);
            this.powerUpButton.TabIndex = 1;
            this.powerUpButton.Text = "power up";
            this.powerUpButton.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.powerUpButton);
            this.Controls.Add(this.originalButton);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(650, 750);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button originalButton;
        private System.Windows.Forms.Button powerUpButton;
    }
}
