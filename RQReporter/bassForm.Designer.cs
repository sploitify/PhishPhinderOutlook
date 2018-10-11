namespace RQReporter
{
    partial class bassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bassForm));
            this.bassBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bassBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bassBox
            // 
            this.bassBox.Image = ((System.Drawing.Image)(resources.GetObject("bassBox.Image")));
            this.bassBox.Location = new System.Drawing.Point(2, 2);
            this.bassBox.Name = "bassBox";
            this.bassBox.Size = new System.Drawing.Size(357, 201);
            this.bassBox.TabIndex = 0;
            this.bassBox.TabStop = false;
            // 
            // bassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 203);
            this.Controls.Add(this.bassBox);
            this.Name = "bassForm";
            this.ShowIcon = false;
            this.Text = "YO SKRILL DROP IT HARD!";
            ((System.ComponentModel.ISupportInitialize)(this.bassBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bassBox;
    }
}