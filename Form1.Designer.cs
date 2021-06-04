
namespace Contact_Tracer
{
    partial class ContactTracingForm
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
            this.Title = new System.Windows.Forms.Label();
            this.PUPTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(186, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(320, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Contact Tracing Form";
            // 
            // PUPTitle
            // 
            this.PUPTitle.AutoSize = true;
            this.PUPTitle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PUPTitle.ForeColor = System.Drawing.Color.Maroon;
            this.PUPTitle.Location = new System.Drawing.Point(222, 9);
            this.PUPTitle.Name = "PUPTitle";
            this.PUPTitle.Size = new System.Drawing.Size(249, 16);
            this.PUPTitle.TabIndex = 1;
            this.PUPTitle.Text = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES";
            // 
            // ContactTracingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.PUPTitle);
            this.Controls.Add(this.Title);
            this.Name = "ContactTracingForm";
            this.Text = "Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PUPTitle;
    }
}

