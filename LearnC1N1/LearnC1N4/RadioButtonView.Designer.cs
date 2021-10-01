
namespace LearnC1N4
{
    partial class RadioButtonView
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonSetBackColor = new System.Windows.Forms.Button();
            this.RadioButtonColorGreen = new System.Windows.Forms.RadioButton();
            this.RadioButtonColorBlue = new System.Windows.Forms.RadioButton();
            this.RadioButtonColorRed = new System.Windows.Forms.RadioButton();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.ButtonSetBackColor);
            this.GroupBox.Controls.Add(this.RadioButtonColorGreen);
            this.GroupBox.Controls.Add(this.RadioButtonColorBlue);
            this.GroupBox.Controls.Add(this.RadioButtonColorRed);
            this.GroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(282, 141);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "背景色を選択";
            // 
            // ButtonSetBackColor
            // 
            this.ButtonSetBackColor.Location = new System.Drawing.Point(188, 22);
            this.ButtonSetBackColor.Name = "ButtonSetBackColor";
            this.ButtonSetBackColor.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetBackColor.TabIndex = 3;
            this.ButtonSetBackColor.Text = "設定";
            this.ButtonSetBackColor.UseVisualStyleBackColor = true;
            this.ButtonSetBackColor.Click += new System.EventHandler(this.ButtonSetBackColor_Click);
            // 
            // RadioButtonColorGreen
            // 
            this.RadioButtonColorGreen.AutoSize = true;
            this.RadioButtonColorGreen.Location = new System.Drawing.Point(16, 84);
            this.RadioButtonColorGreen.Name = "RadioButtonColorGreen";
            this.RadioButtonColorGreen.Size = new System.Drawing.Size(110, 19);
            this.RadioButtonColorGreen.TabIndex = 2;
            this.RadioButtonColorGreen.TabStop = true;
            this.RadioButtonColorGreen.Text = "背景色を緑にする";
            this.RadioButtonColorGreen.UseVisualStyleBackColor = true;
            // 
            // RadioButtonColorBlue
            // 
            this.RadioButtonColorBlue.AutoSize = true;
            this.RadioButtonColorBlue.Location = new System.Drawing.Point(16, 59);
            this.RadioButtonColorBlue.Name = "RadioButtonColorBlue";
            this.RadioButtonColorBlue.Size = new System.Drawing.Size(110, 19);
            this.RadioButtonColorBlue.TabIndex = 1;
            this.RadioButtonColorBlue.TabStop = true;
            this.RadioButtonColorBlue.Text = "背景色を青にする";
            this.RadioButtonColorBlue.UseVisualStyleBackColor = true;
            // 
            // RadioButtonColorRed
            // 
            this.RadioButtonColorRed.AutoSize = true;
            this.RadioButtonColorRed.Location = new System.Drawing.Point(16, 34);
            this.RadioButtonColorRed.Name = "RadioButtonColorRed";
            this.RadioButtonColorRed.Size = new System.Drawing.Size(110, 19);
            this.RadioButtonColorRed.TabIndex = 0;
            this.RadioButtonColorRed.TabStop = true;
            this.RadioButtonColorRed.Text = "背景色を赤にする";
            this.RadioButtonColorRed.UseVisualStyleBackColor = true;
            // 
            // RadioButtonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 165);
            this.Controls.Add(this.GroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(322, 204);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(322, 204);
            this.Name = "RadioButtonView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ラジオボタン";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.RadioButton RadioButtonColorGreen;
        private System.Windows.Forms.RadioButton RadioButtonColorBlue;
        private System.Windows.Forms.RadioButton RadioButtonColorRed;
        private System.Windows.Forms.Button ButtonSetBackColor;
    }
}