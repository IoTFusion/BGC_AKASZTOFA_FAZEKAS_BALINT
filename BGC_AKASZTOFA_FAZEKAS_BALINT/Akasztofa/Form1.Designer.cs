namespace Akasztofa
{
    partial class Form1
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
            this.mainCanvas = new System.Windows.Forms.PictureBox();
            this.inBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.White;
            this.mainCanvas.Location = new System.Drawing.Point(0, 0);
            this.mainCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(1639, 646);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
            this.mainCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // inBox
            // 
            this.inBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inBox.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold);
            this.inBox.Location = new System.Drawing.Point(415, 47);
            this.inBox.MaxLength = 1;
            this.inBox.Multiline = true;
            this.inBox.Name = "inBox";
            this.inBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inBox.Size = new System.Drawing.Size(44, 44);
            this.inBox.TabIndex = 1;
            this.inBox.Tag = "";
            this.inBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.boxPressed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 644);
            this.Controls.Add(this.inBox);
            this.Controls.Add(this.mainCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.screenSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.TextBox inBox;
    }
}

