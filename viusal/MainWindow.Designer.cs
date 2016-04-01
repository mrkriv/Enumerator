namespace viusal
{
    partial class Calculator
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
            this.trunTableDA = new System.Windows.Forms.ListBox();
            this.trunTableA = new System.Windows.Forms.ListBox();
            this.trunTableDB = new System.Windows.Forms.ListBox();
            this.trunTableB = new System.Windows.Forms.ListBox();
            this.handel = new System.Windows.Forms.Label();
            this.tabs = new viusal.STabControl();
            this.maleSkhema = new System.Windows.Forms.Button();
            this.makeDiagram = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trunTableDA
            // 
            this.trunTableDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trunTableDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.trunTableDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trunTableDA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trunTableDA.ForeColor = System.Drawing.Color.Gainsboro;
            this.trunTableDA.ItemHeight = 15;
            this.trunTableDA.Location = new System.Drawing.Point(12, 41);
            this.trunTableDA.Name = "trunTableDA";
            this.trunTableDA.Size = new System.Drawing.Size(33, 572);
            this.trunTableDA.TabIndex = 0;
            this.trunTableDA.TabStop = false;
            this.trunTableDA.SelectedIndexChanged += new System.EventHandler(this.trunTable_SelectedIndexChanged);
            // 
            // trunTableA
            // 
            this.trunTableA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trunTableA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.trunTableA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trunTableA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trunTableA.ForeColor = System.Drawing.Color.Gainsboro;
            this.trunTableA.ItemHeight = 15;
            this.trunTableA.Location = new System.Drawing.Point(83, 41);
            this.trunTableA.Name = "trunTableA";
            this.trunTableA.Size = new System.Drawing.Size(64, 572);
            this.trunTableA.TabIndex = 1;
            this.trunTableA.TabStop = false;
            this.trunTableA.SelectedIndexChanged += new System.EventHandler(this.trunTable_SelectedIndexChanged);
            // 
            // trunTableDB
            // 
            this.trunTableDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trunTableDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.trunTableDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trunTableDB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trunTableDB.ForeColor = System.Drawing.Color.Gainsboro;
            this.trunTableDB.ItemHeight = 15;
            this.trunTableDB.Location = new System.Drawing.Point(44, 41);
            this.trunTableDB.Name = "trunTableDB";
            this.trunTableDB.Size = new System.Drawing.Size(33, 572);
            this.trunTableDB.TabIndex = 2;
            this.trunTableDB.TabStop = false;
            this.trunTableDB.SelectedIndexChanged += new System.EventHandler(this.trunTable_SelectedIndexChanged);
            // 
            // trunTableB
            // 
            this.trunTableB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trunTableB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.trunTableB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trunTableB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trunTableB.ForeColor = System.Drawing.Color.Gainsboro;
            this.trunTableB.ItemHeight = 15;
            this.trunTableB.Location = new System.Drawing.Point(146, 41);
            this.trunTableB.Name = "trunTableB";
            this.trunTableB.Size = new System.Drawing.Size(64, 572);
            this.trunTableB.TabIndex = 3;
            this.trunTableB.TabStop = false;
            this.trunTableB.SelectedIndexChanged += new System.EventHandler(this.trunTable_SelectedIndexChanged);
            // 
            // handel
            // 
            this.handel.AutoSize = true;
            this.handel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.handel.ForeColor = System.Drawing.Color.Gainsboro;
            this.handel.Location = new System.Drawing.Point(10, 9);
            this.handel.Name = "handel";
            this.handel.Size = new System.Drawing.Size(94, 24);
            this.handel.TabIndex = 4;
            this.handel.Text = "{0}/{1}";
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabs.Location = new System.Drawing.Point(216, 9);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(772, 583);
            this.tabs.TabIndex = 11;
            // 
            // maleSkhema
            // 
            this.maleSkhema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maleSkhema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.maleSkhema.FlatAppearance.BorderSize = 0;
            this.maleSkhema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maleSkhema.ForeColor = System.Drawing.Color.Gainsboro;
            this.maleSkhema.Location = new System.Drawing.Point(608, 599);
            this.maleSkhema.Name = "maleSkhema";
            this.maleSkhema.Size = new System.Drawing.Size(236, 23);
            this.maleSkhema.TabIndex = 66;
            this.maleSkhema.Text = "Построить схему на D-TR в базисе NAND";
            this.maleSkhema.UseVisualStyleBackColor = false;
            this.maleSkhema.Click += new System.EventHandler(this.maleSkhema_Click);
            // 
            // makeDiagram
            // 
            this.makeDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.makeDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.makeDiagram.FlatAppearance.BorderSize = 0;
            this.makeDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeDiagram.ForeColor = System.Drawing.Color.Gainsboro;
            this.makeDiagram.Location = new System.Drawing.Point(850, 599);
            this.makeDiagram.Name = "makeDiagram";
            this.makeDiagram.Size = new System.Drawing.Size(139, 23);
            this.makeDiagram.TabIndex = 65;
            this.makeDiagram.Text = "Построить диаграмму";
            this.makeDiagram.UseVisualStyleBackColor = false;
            this.makeDiagram.Click += new System.EventHandler(this.makeDiagram_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNew.Image = global::viusal.Properties.Resources._new;
            this.btnNew.Location = new System.Drawing.Point(180, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(20, 20);
            this.btnNew.TabIndex = 12;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(422, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "Минимизировать все карты";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1000, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.maleSkhema);
            this.Controls.Add(this.makeDiagram);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.handel);
            this.Controls.Add(this.trunTableB);
            this.Controls.Add(this.trunTableDB);
            this.Controls.Add(this.trunTableA);
            this.Controls.Add(this.trunTableDA);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счетчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox trunTableDA;
        private System.Windows.Forms.ListBox trunTableA;
        private System.Windows.Forms.ListBox trunTableDB;
        private System.Windows.Forms.ListBox trunTableB;
        private System.Windows.Forms.Label handel;
        private STabControl tabs;
        private System.Windows.Forms.Button maleSkhema;
        private System.Windows.Forms.Button makeDiagram;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button1;
    }
}