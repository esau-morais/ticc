namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAgainstComputer = new System.Windows.Forms.Button();
            this.buttonAgainstFriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgainstComputer
            // 
            this.buttonAgainstComputer.Location = new System.Drawing.Point(333, 104);
            this.buttonAgainstComputer.Name = "buttonAgainstComputer";
            this.buttonAgainstComputer.Size = new System.Drawing.Size(121, 23);
            this.buttonAgainstComputer.TabIndex = 0;
            this.buttonAgainstComputer.Text = "Computer";
            this.buttonAgainstComputer.UseVisualStyleBackColor = true;
            this.buttonAgainstComputer.Click += new System.EventHandler(this.buttonAgainstComputer_Click_1);
            // 
            // buttonAgainstFriend
            // 
            this.buttonAgainstFriend.Location = new System.Drawing.Point(333, 146);
            this.buttonAgainstFriend.Name = "buttonAgainstFriend";
            this.buttonAgainstFriend.Size = new System.Drawing.Size(121, 23);
            this.buttonAgainstFriend.TabIndex = 1;
            this.buttonAgainstFriend.Text = "Friend";
            this.buttonAgainstFriend.UseVisualStyleBackColor = true;
            this.buttonAgainstFriend.Click += new System.EventHandler(this.buttonAgainstFriend_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAgainstFriend);
            this.Controls.Add(this.buttonAgainstComputer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgainstComputer;
        private System.Windows.Forms.Button buttonAgainstFriend;
    }
}

