
namespace Microservices_UI
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
            this.exitButton = new System.Windows.Forms.Button();
            this.getImageButton = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getImageButton
            // 
            this.getImageButton.Location = new System.Drawing.Point(12, 12);
            this.getImageButton.Name = "getImageButton";
            this.getImageButton.Size = new System.Drawing.Size(75, 23);
            this.getImageButton.TabIndex = 1;
            this.getImageButton.Text = "Get Image";
            this.getImageButton.UseVisualStyleBackColor = true;
            this.getImageButton.Click += new System.EventHandler(this.getImageButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(93, 46);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(614, 392);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.getImageButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Microservices UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getImageButton;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label label1;
    }
}

