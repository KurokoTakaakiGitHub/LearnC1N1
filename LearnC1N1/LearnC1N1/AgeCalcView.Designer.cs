
namespace LearnC1N1
{
    partial class AgeCalcView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.Labelc = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 27);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(123, 15);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "名前を入力してください。";
            // 
            // Labelc
            // 
            this.Labelc.AutoSize = true;
            this.Labelc.Location = new System.Drawing.Point(12, 64);
            this.Labelc.Name = "Labelc";
            this.Labelc.Size = new System.Drawing.Size(147, 15);
            this.Labelc.TabIndex = 1;
            this.Labelc.Text = "生年月日を入力してください。";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(187, 19);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(199, 23);
            this.TextBoxName.TabIndex = 2;
            // 
            // DateTimePickerBirthDate
            // 
            this.DateTimePickerBirthDate.Location = new System.Drawing.Point(187, 58);
            this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
            this.DateTimePickerBirthDate.Size = new System.Drawing.Size(200, 23);
            this.DateTimePickerBirthDate.TabIndex = 3;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(311, 98);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 4;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // AgeCalcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 135);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.DateTimePickerBirthDate);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.Labelc);
            this.Controls.Add(this.LabelName);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 174);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 174);
            this.Name = "AgeCalcView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "年齢計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label Labelc;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DateTimePicker DateTimePickerBirthDate;
        private System.Windows.Forms.Button ButtonOk;
    }
}

