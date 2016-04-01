namespace viusal
{
    partial class ElementControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label50 = new System.Windows.Forms.Label();
            this.Sknf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sdnf = new System.Windows.Forms.TextBox();
            this.pages = new viusal.STabControl();
            this.SuspendLayout();
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.Color.Gainsboro;
            this.label50.Location = new System.Drawing.Point(1, 73);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(37, 13);
            this.label50.TabIndex = 15;
            this.label50.Text = "СКНФ:";
            // 
            // Sknf
            // 
            this.Sknf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sknf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.Sknf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sknf.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sknf.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sknf.Location = new System.Drawing.Point(3, 89);
            this.Sknf.Multiline = true;
            this.Sknf.Name = "Sknf";
            this.Sknf.ReadOnly = true;
            this.Sknf.Size = new System.Drawing.Size(735, 35);
            this.Sknf.TabIndex = 14;
            this.Sknf.Text = "1\r\n2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "СДНФ:";
            // 
            // Sdnf
            // 
            this.Sdnf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sdnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.Sdnf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sdnf.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sdnf.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sdnf.Location = new System.Drawing.Point(3, 21);
            this.Sdnf.Multiline = true;
            this.Sdnf.Name = "Sdnf";
            this.Sdnf.ReadOnly = true;
            this.Sdnf.Size = new System.Drawing.Size(735, 33);
            this.Sdnf.TabIndex = 12;
            this.Sdnf.Text = "1\r\n2";
            // 
            // pages
            // 
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.pages.Location = new System.Drawing.Point(4, 141);
            this.pages.Name = "pages";
            this.pages.Padding = new System.Drawing.Point(0, 0);
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(734, 259);
            this.pages.TabIndex = 16;
            // 
            // ElementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.pages);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.Sknf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sdnf);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ElementControl";
            this.Size = new System.Drawing.Size(741, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox Sknf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sdnf;
        public STabControl pages;
    }
}
