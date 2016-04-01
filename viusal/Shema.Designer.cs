namespace viusal
{
    partial class Shema
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
            this.label7 = new System.Windows.Forms.Label();
            this.color2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.color1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundColor = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeH = new System.Windows.Forms.NumericUpDown();
            this.sizeW = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewport = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.NumericUpDown();
            this.useInvert = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 88;
            this.label7.Text = "Текст:";
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Gainsboro;
            this.color2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color2.FlatAppearance.BorderSize = 0;
            this.color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color2.ForeColor = System.Drawing.Color.Gainsboro;
            this.color2.Location = new System.Drawing.Point(115, 262);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(59, 23);
            this.color2.TabIndex = 87;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.Click += new System.EventHandler(this.color_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 86;
            this.label6.Text = "Элементы:";
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Green;
            this.color1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color1.FlatAppearance.BorderSize = 0;
            this.color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color1.ForeColor = System.Drawing.Color.Gainsboro;
            this.color1.Location = new System.Drawing.Point(115, 233);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(59, 23);
            this.color1.TabIndex = 85;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "Фон:";
            // 
            // backgroundColor
            // 
            this.backgroundColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.backgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backgroundColor.FlatAppearance.BorderSize = 0;
            this.backgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundColor.ForeColor = System.Drawing.Color.Gainsboro;
            this.backgroundColor.Location = new System.Drawing.Point(115, 204);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(59, 23);
            this.backgroundColor.TabIndex = 83;
            this.backgroundColor.UseVisualStyleBackColor = false;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.Gainsboro;
            this.save.Location = new System.Drawing.Point(11, 499);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(163, 23);
            this.save.TabIndex = 82;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Высота:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Ширина:";
            // 
            // sizeH
            // 
            this.sizeH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sizeH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizeH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeH.ForeColor = System.Drawing.Color.Gainsboro;
            this.sizeH.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sizeH.Location = new System.Drawing.Point(115, 49);
            this.sizeH.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.sizeH.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.sizeH.Name = "sizeH";
            this.sizeH.Size = new System.Drawing.Size(59, 22);
            this.sizeH.TabIndex = 75;
            this.sizeH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeH.Value = new decimal(new int[] {
            1536,
            0,
            0,
            0});
            this.sizeH.ValueChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // sizeW
            // 
            this.sizeW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sizeW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizeW.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeW.ForeColor = System.Drawing.Color.Gainsboro;
            this.sizeW.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sizeW.Location = new System.Drawing.Point(115, 19);
            this.sizeW.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.sizeW.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.sizeW.Name = "sizeW";
            this.sizeW.Size = new System.Drawing.Size(59, 22);
            this.sizeW.TabIndex = 74;
            this.sizeW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeW.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.sizeW.ValueChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // saveDialog
            // 
            this.saveDialog.FileName = "shema.bmp";
            this.saveDialog.Filter = "Bitmap|*.bmp|Al file|*.*";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.viewport);
            this.panel1.Location = new System.Drawing.Point(180, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 517);
            this.panel1.TabIndex = 0;
            // 
            // viewport
            // 
            this.viewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.viewport.Location = new System.Drawing.Point(0, 0);
            this.viewport.Name = "viewport";
            this.viewport.Size = new System.Drawing.Size(1024, 1536);
            this.viewport.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 90;
            this.label3.Text = "Сетка:";
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grid.ForeColor = System.Drawing.Color.Gainsboro;
            this.grid.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.grid.Location = new System.Drawing.Point(115, 77);
            this.grid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(59, 22);
            this.grid.TabIndex = 89;
            this.grid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.grid.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.grid.ValueChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // useInvert
            // 
            this.useInvert.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.useInvert.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.useInvert.Location = new System.Drawing.Point(8, 108);
            this.useInvert.Name = "useInvert";
            this.useInvert.Size = new System.Drawing.Size(166, 17);
            this.useInvert.TabIndex = 91;
            this.useInvert.Text = "Шина с инверсией";
            this.useInvert.UseVisualStyleBackColor = true;
            this.useInvert.CheckedChanged += new System.EventHandler(this.Setting_ValueChanged);
            // 
            // Shema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1147, 534);
            this.Controls.Add(this.useInvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backgroundColor);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeH);
            this.Controls.Add(this.sizeW);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Shema";
            this.Text = "Shema";
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backgroundColor;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sizeH;
        private System.Windows.Forms.NumericUpDown sizeW;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel viewport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown grid;
        private System.Windows.Forms.CheckBox useInvert;
    }
}