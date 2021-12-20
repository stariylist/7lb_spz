namespace SPZ_Lab7.View
{
    partial class StudentEditor
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
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.group_comboBox = new System.Windows.Forms.ComboBox();
            this.firstname_textBox = new System.Windows.Forms.TextBox();
            this.lastname_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.add_button.Location = new System.Drawing.Point(323, 241);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(115, 49);
            this.add_button.TabIndex = 17;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edit_button.Location = new System.Drawing.Point(175, 241);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(114, 49);
            this.edit_button.TabIndex = 16;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delete_button.Location = new System.Drawing.Point(24, 241);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(107, 49);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Группа:";
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstname_label.Location = new System.Drawing.Point(68, 92);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(48, 20);
            this.firstname_label.TabIndex = 13;
            this.firstname_label.Text = "Имя:";
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastname_label.Location = new System.Drawing.Point(68, 36);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(93, 20);
            this.lastname_label.TabIndex = 12;
            this.lastname_label.Text = "Фамилия:";
            // 
            // group_comboBox
            // 
            this.group_comboBox.FormattingEnabled = true;
            this.group_comboBox.Location = new System.Drawing.Point(175, 150);
            this.group_comboBox.Name = "group_comboBox";
            this.group_comboBox.Size = new System.Drawing.Size(166, 28);
            this.group_comboBox.TabIndex = 11;
            // 
            // firstname_textBox
            // 
            this.firstname_textBox.Location = new System.Drawing.Point(175, 92);
            this.firstname_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstname_textBox.Name = "firstname_textBox";
            this.firstname_textBox.Size = new System.Drawing.Size(201, 26);
            this.firstname_textBox.TabIndex = 10;
            // 
            // lastname_textBox
            // 
            this.lastname_textBox.Location = new System.Drawing.Point(175, 36);
            this.lastname_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastname_textBox.Name = "lastname_textBox";
            this.lastname_textBox.Size = new System.Drawing.Size(201, 26);
            this.lastname_textBox.TabIndex = 9;
            // 
            // StudentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 312);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstname_label);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.group_comboBox);
            this.Controls.Add(this.firstname_textBox);
            this.Controls.Add(this.lastname_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentEditor";
            this.Text = "StudentEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.ComboBox group_comboBox;
        private System.Windows.Forms.TextBox firstname_textBox;
        private System.Windows.Forms.TextBox lastname_textBox;
    }
}