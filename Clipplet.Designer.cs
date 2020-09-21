namespace Clipplet
{
    partial class frmClippletMain
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
            this.lblViewer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblViewer
            // 
            this.lblViewer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblViewer.Location = new System.Drawing.Point(12, 9);
            this.lblViewer.Name = "lblViewer";
            this.lblViewer.Size = new System.Drawing.Size(239, 169);
            this.lblViewer.TabIndex = 0;
            // 
            // frmClippletMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 189);
            this.Controls.Add(this.lblViewer);
            this.Name = "frmClippletMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipplet";
            this.Load += new System.EventHandler(this.frmClippletMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblViewer;
    }
}

