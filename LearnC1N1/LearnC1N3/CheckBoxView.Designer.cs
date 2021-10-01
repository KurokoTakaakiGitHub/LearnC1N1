
namespace LearnC1N3
{
    partial class CheckBoxView
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
            this.CheckBoxA = new System.Windows.Forms.CheckBox();
            this.CheckBoxB = new System.Windows.Forms.CheckBox();
            this.CheckBoxC = new System.Windows.Forms.CheckBox();
            this.ButtonDecision = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBoxA
            // 
            this.CheckBoxA.AutoSize = true;
            this.CheckBoxA.Location = new System.Drawing.Point(84, 50);
            this.CheckBoxA.Name = "CheckBoxA";
            this.CheckBoxA.Size = new System.Drawing.Size(96, 19);
            this.CheckBoxA.TabIndex = 1;
            this.CheckBoxA.Text = "商品A(500円)";
            this.CheckBoxA.UseVisualStyleBackColor = true;
            // 
            // CheckBoxB
            // 
            this.CheckBoxB.AutoSize = true;
            this.CheckBoxB.Location = new System.Drawing.Point(84, 92);
            this.CheckBoxB.Name = "CheckBoxB";
            this.CheckBoxB.Size = new System.Drawing.Size(96, 19);
            this.CheckBoxB.TabIndex = 2;
            this.CheckBoxB.Text = "商品A(600円)";
            this.CheckBoxB.UseVisualStyleBackColor = true;
            // 
            // CheckBoxC
            // 
            this.CheckBoxC.AutoSize = true;
            this.CheckBoxC.Location = new System.Drawing.Point(84, 133);
            this.CheckBoxC.Name = "CheckBoxC";
            this.CheckBoxC.Size = new System.Drawing.Size(95, 19);
            this.CheckBoxC.TabIndex = 3;
            this.CheckBoxC.Text = "商品C(700円)";
            this.CheckBoxC.UseVisualStyleBackColor = true;
            // 
            // ButtonDecision
            // 
            this.ButtonDecision.Location = new System.Drawing.Point(84, 182);
            this.ButtonDecision.Name = "ButtonDecision";
            this.ButtonDecision.Size = new System.Drawing.Size(115, 39);
            this.ButtonDecision.TabIndex = 4;
            this.ButtonDecision.Text = "決定";
            this.ButtonDecision.UseVisualStyleBackColor = true;
            this.ButtonDecision.Click += new System.EventHandler(this.ButtonDecision_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(84, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 15);
            this.label.TabIndex = 5;
            this.label.Text = "商品を選択してください";
            // 
            // CheckBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 254);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ButtonDecision);
            this.Controls.Add(this.CheckBoxC);
            this.Controls.Add(this.CheckBoxB);
            this.Controls.Add(this.CheckBoxA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(302, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(302, 293);
            this.Name = "CheckBoxView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "チェックボックス";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxA;
        private System.Windows.Forms.CheckBox CheckBoxB;
        private System.Windows.Forms.CheckBox CheckBoxC;
        private System.Windows.Forms.Button ButtonDecision;
        private System.Windows.Forms.Label label;
    }
}