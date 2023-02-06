namespace 威力彩4
{
    partial class Form4
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
            this.txt包牌號碼 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt包牌號碼
            // 
            this.txt包牌號碼.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt包牌號碼.Location = new System.Drawing.Point(32, 111);
            this.txt包牌號碼.Multiline = true;
            this.txt包牌號碼.Name = "txt包牌號碼";
            this.txt包牌號碼.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt包牌號碼.Size = new System.Drawing.Size(725, 230);
            this.txt包牌號碼.TabIndex = 54;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt包牌號碼);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt包牌號碼;
    }
}