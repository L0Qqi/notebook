namespace notebook
{
    partial class formAboutProgram
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
            this.pictureWindows = new System.Windows.Forms.PictureBox();
            this.buttonCloseFormAbout = new System.Windows.Forms.Button();
            this.labelTextAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWindows)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureWindows
            // 
            this.pictureWindows.Image = global::notebook.Properties.Resources.winIcon;
            this.pictureWindows.Location = new System.Drawing.Point(125, 51);
            this.pictureWindows.Name = "pictureWindows";
            this.pictureWindows.Size = new System.Drawing.Size(137, 121);
            this.pictureWindows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWindows.TabIndex = 0;
            this.pictureWindows.TabStop = false;
            // 
            // buttonCloseFormAbout
            // 
            this.buttonCloseFormAbout.BackColor = System.Drawing.Color.Salmon;
            this.buttonCloseFormAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseFormAbout.Location = new System.Drawing.Point(282, 394);
            this.buttonCloseFormAbout.Name = "buttonCloseFormAbout";
            this.buttonCloseFormAbout.Size = new System.Drawing.Size(98, 32);
            this.buttonCloseFormAbout.TabIndex = 1;
            this.buttonCloseFormAbout.Text = "Закрыть";
            this.buttonCloseFormAbout.UseVisualStyleBackColor = false;
            this.buttonCloseFormAbout.Click += new System.EventHandler(this.buttonCloseFormAbout_Click);
            // 
            // labelTextAbout
            // 
            this.labelTextAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextAbout.Location = new System.Drawing.Point(56, 199);
            this.labelTextAbout.Name = "labelTextAbout";
            this.labelTextAbout.Size = new System.Drawing.Size(287, 48);
            this.labelTextAbout.TabIndex = 2;
            this.labelTextAbout.Text = "Тут был Радмир";
            this.labelTextAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formAboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.labelTextAbout);
            this.Controls.Add(this.buttonCloseFormAbout);
            this.Controls.Add(this.pictureWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAboutProgram";
            this.Text = "Блокнот: сведения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureWindows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureWindows;
        private System.Windows.Forms.Button buttonCloseFormAbout;
        private System.Windows.Forms.Label labelTextAbout;
    }
}