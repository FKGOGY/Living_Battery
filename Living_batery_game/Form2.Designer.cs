namespace Living_batery_game
{
    partial class Level1
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
            this.components = new System.ComponentModel.Container();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.txtLevel = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.pickupBattery = new System.Windows.Forms.PictureBox();
            this.nabijecka = new System.Windows.Forms.PictureBox();
            this.charBattery = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickupBattery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabijecka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charBattery)).BeginInit();
            this.SuspendLayout();
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLevel.Location = new System.Drawing.Point(12, 9);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(101, 31);
            this.txtLevel.TabIndex = 1;
            this.txtLevel.Text = "Level 1";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTime.Location = new System.Drawing.Point(665, 9);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(82, 31);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "Time:";
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(753, 12);
            this.timeBar.Maximum = 30;
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(219, 28);
            this.timeBar.TabIndex = 3;
            this.timeBar.Value = 30;
            // 
            // pickupBattery
            // 
            this.pickupBattery.Image = global::Living_batery_game.Properties.Resources.pickup_baterky;
            this.pickupBattery.Location = new System.Drawing.Point(449, 302);
            this.pickupBattery.Name = "pickupBattery";
            this.pickupBattery.Size = new System.Drawing.Size(50, 20);
            this.pickupBattery.TabIndex = 5;
            this.pickupBattery.TabStop = false;
            // 
            // nabijecka
            // 
            this.nabijecka.Image = global::Living_batery_game.Properties.Resources.nabijecka;
            this.nabijecka.Location = new System.Drawing.Point(932, 289);
            this.nabijecka.Name = "nabijecka";
            this.nabijecka.Size = new System.Drawing.Size(40, 70);
            this.nabijecka.TabIndex = 4;
            this.nabijecka.TabStop = false;
            // 
            // charBattery
            // 
            this.charBattery.Image = global::Living_batery_game.Properties.Resources.living_battery;
            this.charBattery.Location = new System.Drawing.Point(18, 62);
            this.charBattery.Name = "charBattery";
            this.charBattery.Size = new System.Drawing.Size(50, 50);
            this.charBattery.TabIndex = 0;
            this.charBattery.TabStop = false;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pickupBattery);
            this.Controls.Add(this.nabijecka);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.charBattery);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Level1";
            this.Text = "Level 1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pickupBattery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabijecka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charBattery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox charBattery;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label txtLevel;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.PictureBox nabijecka;
        private System.Windows.Forms.PictureBox pickupBattery;
    }
}