namespace SPZ_Lab7.View
{
    partial class GroupEditor
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
            this.addGroup_button = new System.Windows.Forms.Button();
            this.rename_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteGroup_button = new System.Windows.Forms.Button();
            this.newGroup_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addGroup_button
            // 
            this.addGroup_button.BackColor = System.Drawing.Color.Yellow;
            this.addGroup_button.Location = new System.Drawing.Point(319, 186);
            this.addGroup_button.Name = "addGroup_button";
            this.addGroup_button.Size = new System.Drawing.Size(144, 39);
            this.addGroup_button.TabIndex = 13;
            this.addGroup_button.Text = "Добавить";
            this.addGroup_button.UseVisualStyleBackColor = false;
            this.addGroup_button.Click += new System.EventHandler(this.addGroup_button_Click);
            // 
            // rename_button
            // 
            this.rename_button.BackColor = System.Drawing.Color.Yellow;
            this.rename_button.Location = new System.Drawing.Point(31, 186);
            this.rename_button.Name = "rename_button";
            this.rename_button.Size = new System.Drawing.Size(144, 39);
            this.rename_button.TabIndex = 12;
            this.rename_button.Text = "Переименовать";
            this.rename_button.UseVisualStyleBackColor = false;
            this.rename_button.Click += new System.EventHandler(this.rename_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название группы:";
            // 
            // deleteGroup_button
            // 
            this.deleteGroup_button.BackColor = System.Drawing.Color.Yellow;
            this.deleteGroup_button.Location = new System.Drawing.Point(207, 79);
            this.deleteGroup_button.Name = "deleteGroup_button";
            this.deleteGroup_button.Size = new System.Drawing.Size(91, 39);
            this.deleteGroup_button.TabIndex = 10;
            this.deleteGroup_button.Text = "Удалить";
            this.deleteGroup_button.UseVisualStyleBackColor = false;
            this.deleteGroup_button.Click += new System.EventHandler(this.deleteGroup_button_Click);
            // 
            // newGroup_textBox
            // 
            this.newGroup_textBox.Location = new System.Drawing.Point(180, 133);
            this.newGroup_textBox.Name = "newGroup_textBox";
            this.newGroup_textBox.Size = new System.Drawing.Size(149, 26);
            this.newGroup_textBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название группы";
            // 
            // group_textBox
            // 
            this.group_textBox.Location = new System.Drawing.Point(180, 36);
            this.group_textBox.Name = "group_textBox";
            this.group_textBox.ReadOnly = true;
            this.group_textBox.Size = new System.Drawing.Size(149, 26);
            this.group_textBox.TabIndex = 14;
            // 
            // GroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(487, 249);
            this.Controls.Add(this.group_textBox);
            this.Controls.Add(this.addGroup_button);
            this.Controls.Add(this.rename_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteGroup_button);
            this.Controls.Add(this.newGroup_textBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GroupEditor";
            this.Text = "GroupEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGroup_button;
        private System.Windows.Forms.Button rename_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteGroup_button;
        private System.Windows.Forms.TextBox newGroup_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox group_textBox;
    }
}