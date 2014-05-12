namespace WindowsProjectBlackJack
{
    partial class InstructionPopup
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
            this.Ruleslbl = new System.Windows.Forms.Label();
            this.Rule1lbl = new System.Windows.Forms.Label();
            this.Rule2lbl = new System.Windows.Forms.Label();
            this.Rule3lbl = new System.Windows.Forms.Label();
            this.Rule4lbl = new System.Windows.Forms.Label();
            this.Rule5lbl = new System.Windows.Forms.Label();
            this.Rule6lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ruleslbl
            // 
            this.Ruleslbl.AutoSize = true;
            this.Ruleslbl.Location = new System.Drawing.Point(90, 7);
            this.Ruleslbl.Name = "Ruleslbl";
            this.Ruleslbl.Size = new System.Drawing.Size(35, 13);
            this.Ruleslbl.TabIndex = 1;
            this.Ruleslbl.Text = "label1";
            // 
            // Rule1lbl
            // 
            this.Rule1lbl.AutoSize = true;
            this.Rule1lbl.Location = new System.Drawing.Point(13, 54);
            this.Rule1lbl.Name = "Rule1lbl";
            this.Rule1lbl.Size = new System.Drawing.Size(35, 13);
            this.Rule1lbl.TabIndex = 7;
            this.Rule1lbl.Text = "label1";
            // 
            // Rule2lbl
            // 
            this.Rule2lbl.AutoSize = true;
            this.Rule2lbl.Location = new System.Drawing.Point(13, 83);
            this.Rule2lbl.Name = "Rule2lbl";
            this.Rule2lbl.Size = new System.Drawing.Size(35, 13);
            this.Rule2lbl.TabIndex = 8;
            this.Rule2lbl.Text = "label1";
            // 
            // Rule3lbl
            // 
            this.Rule3lbl.AutoSize = true;
            this.Rule3lbl.Location = new System.Drawing.Point(13, 110);
            this.Rule3lbl.Name = "Rule3lbl";
            this.Rule3lbl.Size = new System.Drawing.Size(35, 13);
            this.Rule3lbl.TabIndex = 9;
            this.Rule3lbl.Text = "label1";
            // 
            // Rule4lbl
            // 
            this.Rule4lbl.AutoSize = true;
            this.Rule4lbl.Location = new System.Drawing.Point(12, 136);
            this.Rule4lbl.Name = "Rule4lbl";
            this.Rule4lbl.Size = new System.Drawing.Size(35, 13);
            this.Rule4lbl.TabIndex = 10;
            this.Rule4lbl.Text = "label1";
            // 
            // Rule5lbl
            // 
            this.Rule5lbl.AutoSize = true;
            this.Rule5lbl.Location = new System.Drawing.Point(12, 160);
            this.Rule5lbl.Name = "Rule5lbl";
            this.Rule5lbl.Size = new System.Drawing.Size(35, 13);
            this.Rule5lbl.TabIndex = 11;
            this.Rule5lbl.Text = "label1";
            // 
            // Rule6lbl
            // 
            this.Rule6lbl.AutoSize = true;
            this.Rule6lbl.Location = new System.Drawing.Point(12, 208);
            this.Rule6lbl.Name = "Rule6lbl";
            this.Rule6lbl.Size = new System.Drawing.Size(35, 13);
            this.Rule6lbl.TabIndex = 12;
            this.Rule6lbl.Text = "label1";
            // 
            // InstructionPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 266);
            this.Controls.Add(this.Rule6lbl);
            this.Controls.Add(this.Rule5lbl);
            this.Controls.Add(this.Rule4lbl);
            this.Controls.Add(this.Rule3lbl);
            this.Controls.Add(this.Rule2lbl);
            this.Controls.Add(this.Rule1lbl);
            this.Controls.Add(this.Ruleslbl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 300);
            this.MinimumSize = new System.Drawing.Size(497, 300);
            this.Name = "InstructionPopup";
            this.Text = "How to play";
            this.Load += new System.EventHandler(this.InstructionPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ruleslbl;
        private System.Windows.Forms.Label Rule1lbl;
        private System.Windows.Forms.Label Rule2lbl;
        private System.Windows.Forms.Label Rule3lbl;
        private System.Windows.Forms.Label Rule4lbl;
        private System.Windows.Forms.Label Rule5lbl;
        private System.Windows.Forms.Label Rule6lbl;
    }
}