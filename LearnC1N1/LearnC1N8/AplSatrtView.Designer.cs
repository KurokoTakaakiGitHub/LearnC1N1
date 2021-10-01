
namespace LearnC1N8
{
    partial class AplStartView
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
            this.ButtonStartMemo = new System.Windows.Forms.Button();
            this.ButtonStartPaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStartMemo
            // 
            this.ButtonStartMemo.Location = new System.Drawing.Point(71, 37);
            this.ButtonStartMemo.Name = "ButtonStartMemo";
            this.ButtonStartMemo.Size = new System.Drawing.Size(95, 23);
            this.ButtonStartMemo.TabIndex = 0;
            this.ButtonStartMemo.Text = "メモ帳の起動";
            this.ButtonStartMemo.UseVisualStyleBackColor = true;
            this.ButtonStartMemo.Click += new System.EventHandler(this.ButtonStartMemo_Click);
            // 
            // ButtonStartPaint
            // 
            this.ButtonStartPaint.Location = new System.Drawing.Point(71, 105);
            this.ButtonStartPaint.Name = "ButtonStartPaint";
            this.ButtonStartPaint.Size = new System.Drawing.Size(95, 23);
            this.ButtonStartPaint.TabIndex = 1;
            this.ButtonStartPaint.Text = "ペイントの起動";
            this.ButtonStartPaint.UseVisualStyleBackColor = true;
            this.ButtonStartPaint.Click += new System.EventHandler(this.ButtonStartPaint_Click);
            // 
            // AplStartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 186);
            this.Controls.Add(this.ButtonStartPaint);
            this.Controls.Add(this.ButtonStartMemo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 225);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(266, 225);
            this.Name = "AplStartView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "他アプリ起動";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStartMemo;
        private System.Windows.Forms.Button ButtonStartPaint;
    }
}