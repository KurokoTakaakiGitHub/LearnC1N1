
namespace LearnC1N2
{
    partial class TextBoxLabelView
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
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.LabelText = new System.Windows.Forms.Label();
            this.ButtonInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(12, 12);
            this.TextBoxInput.Multiline = true;
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxInput.Size = new System.Drawing.Size(422, 64);
            this.TextBoxInput.TabIndex = 0;
            // 
            // LabelText
            // 
            this.LabelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelText.Location = new System.Drawing.Point(12, 89);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(422, 82);
            this.LabelText.TabIndex = 1;
            // 
            // ButtonInput
            // 
            this.ButtonInput.Location = new System.Drawing.Point(440, 12);
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.Size = new System.Drawing.Size(75, 23);
            this.ButtonInput.TabIndex = 2;
            this.ButtonInput.Text = "入力";
            this.ButtonInput.UseVisualStyleBackColor = true;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // TextBoxLabelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 186);
            this.Controls.Add(this.ButtonInput);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.TextBoxInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 225);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 225);
            this.Name = "TextBoxLabelView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "テキストボックス";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Button ButtonInput;
    }
}