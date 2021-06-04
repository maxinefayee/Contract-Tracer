
namespace Contact_Tracer
{
    partial class Form2
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
            this.ShowData = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Header1 = new System.Windows.Forms.Label();
            this.PUPTitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(25, 155);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(646, 401);
            this.ShowData.TabIndex = 0;
            this.ShowData.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "we will be able to observe the people who have entered the facility if there are " +
    "any case occurs.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "us with your personal information to avoid further spread of the virus amongst ot" +
    "hers. With this,";
            // 
            // Header1
            // 
            this.Header1.AutoSize = true;
            this.Header1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Header1.Location = new System.Drawing.Point(31, 82);
            this.Header1.Name = "Header1";
            this.Header1.Size = new System.Drawing.Size(640, 20);
            this.Header1.TabIndex = 30;
            this.Header1.Text = "If you are either diagnosed with Coronavirus or experiencing Coronavirus symptoms" +
    ", please provide";
            // 
            // PUPTitle
            // 
            this.PUPTitle.AutoSize = true;
            this.PUPTitle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PUPTitle.ForeColor = System.Drawing.Color.Maroon;
            this.PUPTitle.Location = new System.Drawing.Point(239, 23);
            this.PUPTitle.Name = "PUPTitle";
            this.PUPTitle.Size = new System.Drawing.Size(249, 16);
            this.PUPTitle.TabIndex = 29;
            this.PUPTitle.Text = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(190, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(349, 37);
            this.Title.TabIndex = 28;
            this.Title.Text = "Contact Tracing Form";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.Brown;
            this.ShowButton.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowButton.Location = new System.Drawing.Point(498, 565);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(173, 35);
            this.ShowButton.TabIndex = 33;
            this.ShowButton.Text = "SHOW DATA";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(699, 609);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header1);
            this.Controls.Add(this.PUPTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ShowData);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ShowData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Header1;
        private System.Windows.Forms.Label PUPTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ShowButton;
    }
}