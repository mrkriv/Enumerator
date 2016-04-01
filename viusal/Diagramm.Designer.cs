namespace viusal
{
    partial class Diagramm
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
            this.viewport = new System.Windows.Forms.Panel();
            this.stepW = new System.Windows.Forms.NumericUpDown();
            this.stepH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.loopCount = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.color1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.color2 = new System.Windows.Forms.Button();
            this.enableText = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.stepW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopCount)).BeginInit();
            this.SuspendLayout();
            // 
            // viewport
            // 
            this.viewport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.viewport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewport.Location = new System.Drawing.Point(184, 12);
            this.viewport.Name = "viewport";
            this.viewport.Size = new System.Drawing.Size(840, 270);
            this.viewport.TabIndex = 0;
            // 
            // stepW
            // 
            this.stepW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.stepW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stepW.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepW.ForeColor = System.Drawing.Color.Gainsboro;
            this.stepW.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.stepW.Location = new System.Drawing.Point(119, 15);
            this.stepW.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepW.Name = "stepW";
            this.stepW.Size = new System.Drawing.Size(59, 22);
            this.stepW.TabIndex = 2;
            this.stepW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.stepW.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.stepW.ValueChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // stepH
            // 
            this.stepH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.stepH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stepH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepH.ForeColor = System.Drawing.Color.Gainsboro;
            this.stepH.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.stepH.Location = new System.Drawing.Point(119, 45);
            this.stepH.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepH.Name = "stepH";
            this.stepH.Size = new System.Drawing.Size(59, 22);
            this.stepH.TabIndex = 3;
            this.stepH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.stepH.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.stepH.ValueChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Маштаб X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Маштаб Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Растояние:";
            // 
            // delta
            // 
            this.delta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.delta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delta.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delta.ForeColor = System.Drawing.Color.Gainsboro;
            this.delta.Location = new System.Drawing.Point(119, 75);
            this.delta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(59, 22);
            this.delta.TabIndex = 6;
            this.delta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.delta.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.delta.ValueChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Циклы:";
            // 
            // loopCount
            // 
            this.loopCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.loopCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loopCount.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loopCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.loopCount.Location = new System.Drawing.Point(119, 103);
            this.loopCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.loopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loopCount.Name = "loopCount";
            this.loopCount.Size = new System.Drawing.Size(59, 22);
            this.loopCount.TabIndex = 8;
            this.loopCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loopCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loopCount.ValueChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.Gainsboro;
            this.save.Location = new System.Drawing.Point(12, 259);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(166, 23);
            this.save.TabIndex = 64;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.FileName = "diagramm.bmp";
            this.saveDialog.Filter = "Bitmap|*.bmp|Al file|*.*";
            // 
            // backgroundColor
            // 
            this.backgroundColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.backgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backgroundColor.FlatAppearance.BorderSize = 0;
            this.backgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundColor.ForeColor = System.Drawing.Color.Gainsboro;
            this.backgroundColor.Location = new System.Drawing.Point(119, 159);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(59, 23);
            this.backgroundColor.TabIndex = 67;
            this.backgroundColor.UseVisualStyleBackColor = false;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 68;
            this.label5.Text = "Фон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Цвет 1:";
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Green;
            this.color1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color1.FlatAppearance.BorderSize = 0;
            this.color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color1.ForeColor = System.Drawing.Color.Gainsboro;
            this.color1.Location = new System.Drawing.Point(119, 188);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(59, 23);
            this.color1.TabIndex = 69;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 72;
            this.label7.Text = "Цвет 2:";
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Ivory;
            this.color2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color2.FlatAppearance.BorderSize = 0;
            this.color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color2.ForeColor = System.Drawing.Color.Gainsboro;
            this.color2.Location = new System.Drawing.Point(119, 217);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(59, 23);
            this.color2.TabIndex = 71;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.Click += new System.EventHandler(this.color_Click);
            // 
            // enableText
            // 
            this.enableText.AutoSize = true;
            this.enableText.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableText.Location = new System.Drawing.Point(119, 139);
            this.enableText.Name = "enableText";
            this.enableText.Size = new System.Drawing.Size(15, 14);
            this.enableText.TabIndex = 73;
            this.enableText.UseVisualStyleBackColor = true;
            this.enableText.CheckedChanged += new System.EventHandler(this.Setting_ValueChanged);
            this.enableText.VisibleChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "Подробно:";
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.table.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.table.ForeColor = System.Drawing.Color.Gainsboro;
            this.table.FormattingEnabled = true;
            this.table.ItemHeight = 15;
            this.table.Location = new System.Drawing.Point(1030, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(124, 272);
            this.table.TabIndex = 75;
            // 
            // Diagramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1166, 294);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.enableText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backgroundColor);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loopCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stepH);
            this.Controls.Add(this.stepW);
            this.Controls.Add(this.viewport);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Diagramm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagramm";
            ((System.ComponentModel.ISupportInitialize)(this.stepW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel viewport;
        private System.Windows.Forms.NumericUpDown stepW;
        private System.Windows.Forms.NumericUpDown stepH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown delta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown loopCount;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button backgroundColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.CheckBox enableText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox table;
    }
}