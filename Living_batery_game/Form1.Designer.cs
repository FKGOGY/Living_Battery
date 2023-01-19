namespace Living_batery_game
{
    partial class startmenu
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
            this.nazev = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.controlsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazev
            // 
            this.nazev.AutoSize = true;
            this.nazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 74.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazev.Location = new System.Drawing.Point(12, 41);
            this.nazev.Name = "nazev";
            this.nazev.Size = new System.Drawing.Size(964, 113);
            this.nazev.TabIndex = 0;
            this.nazev.Text = "Living Battery Game";
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(350, 288);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(300, 100);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(350, 500);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(300, 100);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Konec";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlsButton
            // 
            this.controlsButton.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsButton.Location = new System.Drawing.Point(350, 394);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(300, 100);
            this.controlsButton.TabIndex = 3;
            this.controlsButton.Text = "Ovládání";
            this.controlsButton.UseVisualStyleBackColor = true;
            this.controlsButton.Click += new System.EventHandler(this.controlsButton_Click);
            // 
            // startmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.nazev);
            this.Name = "startmenu";
            this.Text = "StartMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazev;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button controlsButton;
    }
}

