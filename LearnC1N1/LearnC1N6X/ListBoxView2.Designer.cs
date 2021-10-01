
namespace LearnC1N6X
{
    partial class ListBoxView2
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
            this.ButtonAddShoppingList = new System.Windows.Forms.Button();
            this.ListBoxShoppingList = new System.Windows.Forms.ListBox();
            this.ButtonDeleteShoppingList = new System.Windows.Forms.Button();
            this.TextBoxShoppingItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonAddShoppingList
            // 
            this.ButtonAddShoppingList.Location = new System.Drawing.Point(14, 78);
            this.ButtonAddShoppingList.Name = "ButtonAddShoppingList";
            this.ButtonAddShoppingList.Size = new System.Drawing.Size(138, 24);
            this.ButtonAddShoppingList.TabIndex = 5;
            this.ButtonAddShoppingList.Text = "買い物リストに追加";
            this.ButtonAddShoppingList.UseVisualStyleBackColor = true;
            this.ButtonAddShoppingList.Click += new System.EventHandler(this.ButtonAddShoppingList_Click);
            // 
            // ListBoxShoppingList
            // 
            this.ListBoxShoppingList.FormattingEnabled = true;
            this.ListBoxShoppingList.ItemHeight = 15;
            this.ListBoxShoppingList.Location = new System.Drawing.Point(158, 32);
            this.ListBoxShoppingList.Name = "ListBoxShoppingList";
            this.ListBoxShoppingList.Size = new System.Drawing.Size(284, 124);
            this.ListBoxShoppingList.TabIndex = 3;
            // 
            // ButtonDeleteShoppingList
            // 
            this.ButtonDeleteShoppingList.Location = new System.Drawing.Point(14, 129);
            this.ButtonDeleteShoppingList.Name = "ButtonDeleteShoppingList";
            this.ButtonDeleteShoppingList.Size = new System.Drawing.Size(138, 24);
            this.ButtonDeleteShoppingList.TabIndex = 6;
            this.ButtonDeleteShoppingList.Text = "買い物リストから削除";
            this.ButtonDeleteShoppingList.UseVisualStyleBackColor = true;
            this.ButtonDeleteShoppingList.Click += new System.EventHandler(this.ButtonDeleteShoppingList_Click);
            // 
            // TextBoxShoppingItem
            // 
            this.TextBoxShoppingItem.Location = new System.Drawing.Point(14, 32);
            this.TextBoxShoppingItem.Name = "TextBoxShoppingItem";
            this.TextBoxShoppingItem.Size = new System.Drawing.Size(138, 23);
            this.TextBoxShoppingItem.TabIndex = 7;
            // 
            // ListBoxView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 161);
            this.Controls.Add(this.TextBoxShoppingItem);
            this.Controls.Add(this.ButtonDeleteShoppingList);
            this.Controls.Add(this.ButtonAddShoppingList);
            this.Controls.Add(this.ListBoxShoppingList);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(461, 200);
            this.Name = "ListBoxView2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "リストボックス２";
            this.Load += new System.EventHandler(this.ListBoxView2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddShoppingList;
        private System.Windows.Forms.ListBox ListBoxShoppingList;
        private System.Windows.Forms.Button ButtonDeleteShoppingList;
        private System.Windows.Forms.TextBox TextBoxShoppingItem;
    }
}