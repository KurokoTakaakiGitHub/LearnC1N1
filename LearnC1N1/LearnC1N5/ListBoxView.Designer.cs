
namespace LearnC1N5
{
    partial class ListBoxView
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
            this.ListBoxBelongings = new System.Windows.Forms.ListBox();
            this.Label = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxBelongings
            // 
            this.ListBoxBelongings.FormattingEnabled = true;
            this.ListBoxBelongings.ItemHeight = 15;
            this.ListBoxBelongings.Location = new System.Drawing.Point(12, 50);
            this.ListBoxBelongings.Name = "ListBoxBelongings";
            this.ListBoxBelongings.Size = new System.Drawing.Size(284, 154);
            this.ListBoxBelongings.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 21);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(74, 15);
            this.Label.TabIndex = 1;
            this.Label.Text = "明日の持ち物";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(303, 50);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(63, 35);
            this.ButtonOk.TabIndex = 2;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ListBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 227);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.ListBoxBelongings);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 266);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 266);
            this.Name = "ListBoxView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "リストボックス";
            this.Load += new System.EventHandler(this.ListBoxView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxBelongings;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button ButtonOk;
    }
}