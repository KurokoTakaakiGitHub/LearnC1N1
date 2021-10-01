
namespace LearnC1N7
{
    partial class BirthDateCalc
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
            this.ButtonOk = new System.Windows.Forms.Button();
            this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.Labelc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(228, 67);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 7;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // DateTimePickerBirthDate
            // 
            this.DateTimePickerBirthDate.Location = new System.Drawing.Point(12, 67);
            this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
            this.DateTimePickerBirthDate.Size = new System.Drawing.Size(200, 23);
            this.DateTimePickerBirthDate.TabIndex = 6;
            // 
            // Labelc
            // 
            this.Labelc.AutoSize = true;
            this.Labelc.Location = new System.Drawing.Point(12, 20);
            this.Labelc.Name = "Labelc";
            this.Labelc.Size = new System.Drawing.Size(223, 15);
            this.Labelc.TabIndex = 5;
            this.Labelc.Text = "生年月日を入力してＯＫボタンをクリックすると";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "次の誕生日までの日数が計算されます。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 9;
            // 
            // BirthDateCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 154);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.DateTimePickerBirthDate);
            this.Controls.Add(this.Labelc);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 193);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 193);
            this.Name = "BirthDateCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BirthDateCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.DateTimePicker DateTimePickerBirthDate;
        private System.Windows.Forms.Label Labelc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}