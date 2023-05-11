using System.Threading;

namespace ThreadFormTime {
    partial class Control_Panel2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDontShow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(30, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(151, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Zobrazuj";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDontShow
            // 
            this.btnDontShow.Location = new System.Drawing.Point(30, 58);
            this.btnDontShow.Name = "btnDontShow";
            this.btnDontShow.Size = new System.Drawing.Size(151, 23);
            this.btnDontShow.TabIndex = 1;
            this.btnDontShow.Text = "Nezobrazuj";
            this.btnDontShow.UseVisualStyleBackColor = true;
            this.btnDontShow.Click += new System.EventHandler(this.btnDontShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(30, 87);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zavrit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Control_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 138);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDontShow);
            this.Controls.Add(this.btnShow);
            this.Name = "Control_Panel";
            this.Text = "Control_Panel";
            this.ResumeLayout(false);
            //
            // Clock
            //
            //this.clock = new implementation.Clock();
            //Thread threadClock = new Thread(this.clock.loop);
            //threadClock.Start();
            //this.clock.loop();
        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDontShow;
        private System.Windows.Forms.Button btnClose;
    }
}

