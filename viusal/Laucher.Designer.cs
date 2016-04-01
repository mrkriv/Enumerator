namespace viusal
{
    partial class Laucher
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mod = new System.Windows.Forms.NumericUpDown();
            this.step = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anim = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mod
            // 
            this.mod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mod.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod.ForeColor = System.Drawing.Color.Gainsboro;
            this.mod.Location = new System.Drawing.Point(157, 60);
            this.mod.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.mod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(135, 23);
            this.mod.TabIndex = 0;
            this.mod.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // step
            // 
            this.step.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.step.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.step.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step.ForeColor = System.Drawing.Color.Gainsboro;
            this.step.Location = new System.Drawing.Point(157, 103);
            this.step.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(135, 23);
            this.step.TabIndex = 1;
            this.step.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(212, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.run);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(154, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Модуль";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(154, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шаг";
            // 
            // anim
            // 
            this.anim.Interval = 30;
            this.anim.Tick += new System.EventHandler(this.anim_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.author);
            this.panel1.Location = new System.Drawing.Point(369, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 46);
            this.panel1.TabIndex = 17;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(67)))));
            this.author.Location = new System.Drawing.Point(0, 14);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(100, 32);
            this.author.TabIndex = 17;
            this.author.Text = "MIREA IVB-3-14\r\nКривошея М.С.";
            this.author.MouseEnter += new System.EventHandler(this.author_MouseEnter);
            this.author.MouseLeave += new System.EventHandler(this.author_MouseLeave);
            // 
            // Laucher
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(468, 202);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.step);
            this.Controls.Add(this.mod);
            this.Name = "Laucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теория автоматов: Счетчик";
            ((System.ComponentModel.ISupportInitialize)(this.mod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown mod;
        private System.Windows.Forms.NumericUpDown step;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer anim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label author;
    }
}

