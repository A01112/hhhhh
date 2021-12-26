
namespace WindowsFormsApp2
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
            this.btnBMR = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBMR
            // 
            this.btnBMR.BackColor = System.Drawing.Color.White;
            this.btnBMR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBMR.BackgroundImage")));
            this.btnBMR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBMR.Location = new System.Drawing.Point(290, 291);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(90, 47);
            this.btnBMR.TabIndex = 0;
            this.btnBMR.UseVisualStyleBackColor = false;
            this.btnBMR.Click += new System.EventHandler(this.btnBMR_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBMI.BackColor = System.Drawing.Color.White;
            this.btnBMI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBMI.BackgroundImage")));
            this.btnBMI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBMI.Location = new System.Drawing.Point(431, 291);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(90, 47);
            this.btnBMI.TabIndex = 1;
            this.btnBMI.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.btnBMR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Health";
         
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBMR;
        private System.Windows.Forms.Button btnBMI;
    }
}