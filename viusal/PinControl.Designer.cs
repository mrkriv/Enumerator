namespace viusal
{
    partial class PinControl
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Mxnf = new System.Windows.Forms.FlowLayoutPanel();
            this.label228 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showMdnf = new System.Windows.Forms.Button();
            this.finalOpName = new System.Windows.Forms.Label();
            this.finalOp = new System.Windows.Forms.TextBox();
            this.addBlock = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.Button();
            this.mapClear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mapBtns = new System.Windows.Forms.Panel();
            this.map = new System.Windows.Forms.Panel();
            this.modeTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.map.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // Mxnf
            // 
            this.Mxnf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mxnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.Mxnf.Location = new System.Drawing.Point(3, 250);
            this.Mxnf.Name = "Mxnf";
            this.Mxnf.Size = new System.Drawing.Size(702, 57);
            this.Mxnf.TabIndex = 53;
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.ForeColor = System.Drawing.Color.Gainsboro;
            this.label228.Location = new System.Drawing.Point(1, 234);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(118, 13);
            this.label228.TabIndex = 54;
            this.label228.Text = "Минимальная форма:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(625, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "ПКМ для удаления";
            // 
            // showMdnf
            // 
            this.showMdnf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showMdnf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMdnf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.showMdnf.Location = new System.Drawing.Point(692, 250);
            this.showMdnf.Name = "showMdnf";
            this.showMdnf.Size = new System.Drawing.Size(47, 57);
            this.showMdnf.TabIndex = 57;
            this.showMdnf.Text = "all";
            this.showMdnf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showMdnf.UseVisualStyleBackColor = true;
            this.showMdnf.MouseEnter += new System.EventHandler(this.showMxnf_MouseEnter);
            this.showMdnf.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // finalOpName
            // 
            this.finalOpName.AutoSize = true;
            this.finalOpName.ForeColor = System.Drawing.Color.Gainsboro;
            this.finalOpName.Location = new System.Drawing.Point(1, 311);
            this.finalOpName.Name = "finalOpName";
            this.finalOpName.Size = new System.Drawing.Size(23, 13);
            this.finalOpName.TabIndex = 56;
            this.finalOpName.Text = "-//-";
            // 
            // finalOp
            // 
            this.finalOp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.finalOp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalOp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finalOp.ForeColor = System.Drawing.Color.Gainsboro;
            this.finalOp.Location = new System.Drawing.Point(3, 327);
            this.finalOp.Multiline = true;
            this.finalOp.Name = "finalOp";
            this.finalOp.ReadOnly = true;
            this.finalOp.Size = new System.Drawing.Size(736, 48);
            this.finalOp.TabIndex = 61;
            this.finalOp.Text = "1\r\n2\r\n3";
            // 
            // addBlock
            // 
            this.addBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.addBlock.FlatAppearance.BorderSize = 0;
            this.addBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBlock.ForeColor = System.Drawing.Color.Gainsboro;
            this.addBlock.Location = new System.Drawing.Point(597, 187);
            this.addBlock.Name = "addBlock";
            this.addBlock.Size = new System.Drawing.Size(77, 23);
            this.addBlock.TabIndex = 51;
            this.addBlock.Text = "Добавить";
            this.addBlock.UseVisualStyleBackColor = false;
            this.addBlock.Click += new System.EventHandler(this.addBlock_Click);
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picColor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.picColor.Location = new System.Drawing.Point(669, 187);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(23, 23);
            this.picColor.TabIndex = 52;
            this.picColor.UseVisualStyleBackColor = false;
            this.picColor.Click += new System.EventHandler(this.picColor_Click);
            // 
            // mapClear
            // 
            this.mapClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.mapClear.FlatAppearance.BorderSize = 0;
            this.mapClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.mapClear.Location = new System.Drawing.Point(597, 159);
            this.mapClear.Name = "mapClear";
            this.mapClear.Size = new System.Drawing.Size(95, 23);
            this.mapClear.TabIndex = 59;
            this.mapClear.Text = "Отчистить";
            this.mapClear.UseVisualStyleBackColor = false;
            this.mapClear.Click += new System.EventHandler(this.mapClear_Click);
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
            // mapBtns
            // 
            this.mapBtns.Location = new System.Drawing.Point(72, 64);
            this.mapBtns.Name = "mapBtns";
            this.mapBtns.Size = new System.Drawing.Size(460, 120);
            this.mapBtns.TabIndex = 49;
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
            this.map.Location = new System.Drawing.Point(56, 26);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(535, 196);
            this.map.TabIndex = 34;
            // 
            // modeTitle
            // 
            this.modeTitle.AutoSize = true;
            this.modeTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.modeTitle.Location = new System.Drawing.Point(26, 13);
            this.modeTitle.Name = "modeTitle";
            this.modeTitle.Size = new System.Drawing.Size(58, 24);
            this.modeTitle.TabIndex = 63;
            this.modeTitle.Tag = "";
            this.modeTitle.Text = "-//-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(597, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 64;
            this.button1.Text = "Авто";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modeTitle);
            this.Controls.Add(this.finalOp);
            this.Controls.Add(this.finalOpName);
            this.Controls.Add(this.mapClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label228);
            this.Controls.Add(this.Mxnf);
            this.Controls.Add(this.addBlock);
            this.Controls.Add(this.map);
            this.Controls.Add(this.showMdnf);
            this.Controls.Add(this.picColor);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "PinControl";
            this.Size = new System.Drawing.Size(744, 383);
            this.map.ResumeLayout(false);
            this.map.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FlowLayoutPanel Mxnf;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showMdnf;
        private System.Windows.Forms.Label finalOpName;
        private System.Windows.Forms.TextBox finalOp;
        private System.Windows.Forms.Button addBlock;
        private System.Windows.Forms.Button picColor;
        private System.Windows.Forms.Button mapClear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel mapBtns;
        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.Label modeTitle;
        private System.Windows.Forms.Button button1;
    }
}
