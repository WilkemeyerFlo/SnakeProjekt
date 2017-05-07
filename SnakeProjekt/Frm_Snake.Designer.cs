namespace SnakeProjekt
{
    partial class FrmSnake
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_main = new System.Windows.Forms.PictureBox();
            this.tim_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_main
            // 
            this.pb_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_main.Location = new System.Drawing.Point(0, 0);
            this.pb_main.Name = "pb_main";
            this.pb_main.Size = new System.Drawing.Size(384, 362);
            this.pb_main.TabIndex = 0;
            this.pb_main.TabStop = false;
            this.pb_main.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pb_main_PreviewKeyDown);
            // 
            // tim_timer
            // 
            this.tim_timer.Enabled = true;
            this.tim_timer.Interval = 150;
            this.tim_timer.Tick += new System.EventHandler(this.tim_timer_Tick);
            // 
            // FrmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.pb_main);
            this.Name = "FrmSnake";
            this.Text = "FrmSnake";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pb_main_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_main;
        private System.Windows.Forms.Timer tim_timer;
    }
}

