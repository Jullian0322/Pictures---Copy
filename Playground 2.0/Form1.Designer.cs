namespace Playground_2._0
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
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.BTN1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(164, 70);
            this.RTB1.Name = "RTB1";
            this.RTB1.ReadOnly = true;
            this.RTB1.Size = new System.Drawing.Size(471, 215);
            this.RTB1.TabIndex = 0;
            this.RTB1.Text = "";
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(328, 338);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(144, 49);
            this.BTN1.TabIndex = 1;
            this.BTN1.Text = "Grade";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.RTB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Button BTN1;
    }
}

