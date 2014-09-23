namespace Mouseio
{
    partial class choice
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
            this.buttonGreekBeaches = new System.Windows.Forms.Button();
            this.buttonForeignBeaches = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGreekBeaches
            // 
            this.buttonGreekBeaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonGreekBeaches.Location = new System.Drawing.Point(91, 101);
            this.buttonGreekBeaches.Name = "buttonGreekBeaches";
            this.buttonGreekBeaches.Size = new System.Drawing.Size(125, 54);
            this.buttonGreekBeaches.TabIndex = 1;
            this.buttonGreekBeaches.Text = "Ελληνικές Παραλίες";
            this.buttonGreekBeaches.UseVisualStyleBackColor = true;
            this.buttonGreekBeaches.Click += new System.EventHandler(this.buttonGreekBeaches_Click);
            // 
            // buttonForeignBeaches
            // 
            this.buttonForeignBeaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonForeignBeaches.Location = new System.Drawing.Point(267, 101);
            this.buttonForeignBeaches.Name = "buttonForeignBeaches";
            this.buttonForeignBeaches.Size = new System.Drawing.Size(125, 54);
            this.buttonForeignBeaches.TabIndex = 2;
            this.buttonForeignBeaches.Text = "Παραλίες Εξωτερικού";
            this.buttonForeignBeaches.UseVisualStyleBackColor = true;
            this.buttonForeignBeaches.Click += new System.EventHandler(this.buttonForeignBeaches_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLogOut.Location = new System.Drawing.Point(465, 361);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(125, 54);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "Αποσύνδεση";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonExit.Location = new System.Drawing.Point(596, 361);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 54);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Έξοδος";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Image = global::Mouseio.Properties.Resources.play;
            this.buttonPlay.Location = new System.Drawing.Point(12, 390);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(23, 25);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Image = global::Mouseio.Properties.Resources.stop;
            this.buttonStop.Location = new System.Drawing.Point(41, 390);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(23, 25);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mouseio.Properties.Resources.egremni_beach;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 427);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonForeignBeaches);
            this.Controls.Add(this.buttonGreekBeaches);
            this.Name = "choice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Παραλίες";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.choice_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGreekBeaches;
        private System.Windows.Forms.Button buttonForeignBeaches;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
    }
}