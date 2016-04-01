namespace viusal
{
    partial class MapControl
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
            this.mapClear = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.Button();
            this.addBlock = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.Panel();
            this.mapBtns = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.map.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapClear
            // 
            this.mapClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.mapClear.FlatAppearance.BorderSize = 0;
            this.mapClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.mapClear.Location = new System.Drawing.Point(538, 138);
            this.mapClear.Name = "mapClear";
            this.mapClear.Size = new System.Drawing.Size(90, 23);
            this.mapClear.TabIndex = 65;
            this.mapClear.Text = "Отчистить";
            this.mapClear.UseVisualStyleBackColor = false;
            // 
            // picColor
            // 
            this.picColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picColor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.picColor.Location = new System.Drawing.Point(538, 108);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(90, 27);
            this.picColor.TabIndex = 63;
            this.picColor.Text = "Цвет";
            this.picColor.UseVisualStyleBackColor = false;
            // 
            // addBlock
            // 
            this.addBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.addBlock.FlatAppearance.BorderSize = 0;
            this.addBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBlock.ForeColor = System.Drawing.Color.Gainsboro;
            this.addBlock.Location = new System.Drawing.Point(538, 166);
            this.addBlock.Name = "addBlock";
            this.addBlock.Size = new System.Drawing.Size(90, 23);
            this.addBlock.TabIndex = 62;
            this.addBlock.Text = "Добавить";
            this.addBlock.UseVisualStyleBackColor = false;
            // 
            // map
            // 
            this.map.Controls.Add(this.mapBtns);
            this.map.Controls.Add(this.label16);
            this.map.Controls.Add(this.label19);
            this.map.Controls.Add(this.label13);
            this.map.Controls.Add(this.label18);
            this.map.Controls.Add(this.label14);
            this.map.Controls.Add(this.label17);
            this.map.Controls.Add(this.label12);
            this.map.Controls.Add(this.label11);
            this.map.Controls.Add(this.label6);
            this.map.Controls.Add(this.label5);
            this.map.Controls.Add(this.label4);
            this.map.Controls.Add(this.label3);
            this.map.Controls.Add(this.label2);
            this.map.Controls.Add(this.label15);
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(535, 191);
            this.map.TabIndex = 61;
            // 
            // mapBtns
            // 
            this.mapBtns.Location = new System.Drawing.Point(72, 64);
            this.mapBtns.Name = "mapBtns";
            this.mapBtns.Size = new System.Drawing.Size(460, 120);
            this.mapBtns.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(422, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 24);
            this.label16.TabIndex = 48;
            this.label16.Tag = "CDE";
            this.label16.Text = "DE";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(298, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 24);
            this.label19.TabIndex = 45;
            this.label19.Tag = "Cde";
            this.label19.Text = "!D!E";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(20, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 24);
            this.label13.TabIndex = 43;
            this.label13.Tag = "Ab";
            this.label13.Text = "A!B";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(361, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 24);
            this.label18.TabIndex = 46;
            this.label18.Tag = "CdE";
            this.label18.Text = "!DE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(32, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 24);
            this.label14.TabIndex = 42;
            this.label14.Tag = "AB";
            this.label14.Text = "AB";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(474, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 24);
            this.label17.TabIndex = 47;
            this.label17.Tag = "CDe";
            this.label17.Text = "D!E";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(20, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 24);
            this.label12.TabIndex = 41;
            this.label12.Tag = "aB";
            this.label12.Text = "!AB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(8, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 40;
            this.label11.Tag = "ab";
            this.label11.Text = "!A!B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(192, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 39;
            this.label6.Tag = "cDE";
            this.label6.Text = "DE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(246, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 38;
            this.label5.Tag = "cDe";
            this.label5.Text = "D!E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(129, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 37;
            this.label4.Tag = "cdE";
            this.label4.Text = "!DE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(66, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 36;
            this.label3.Tag = "cde";
            this.label3.Text = "!D!E";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(397, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 35;
            this.label2.Tag = "C";
            this.label2.Text = "C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(174, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 24);
            this.label15.TabIndex = 34;
            this.label15.Tag = "c";
            this.label15.Text = "!C";
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.mapClear);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.addBlock);
            this.Controls.Add(this.map);
            this.Name = "MapControl";
            this.Size = new System.Drawing.Size(628, 192);
            this.map.ResumeLayout(false);
            this.map.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mapClear;
        private System.Windows.Forms.Button picColor;
        private System.Windows.Forms.Button addBlock;
        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.Panel mapBtns;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
    }
}
