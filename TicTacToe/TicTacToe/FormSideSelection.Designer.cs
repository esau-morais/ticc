namespace TicTacToe
{
    partial class FormSideSelection
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
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(336, 171);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(121, 23);
            this.buttonO.TabIndex = 3;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click_1);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(336, 129);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(121, 23);
            this.buttonX.TabIndex = 2;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click_1);
            // 
            // FormSideSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonX);
            this.Name = "FormSideSelection";
            this.Text = "FormSideSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonX;
    }
}