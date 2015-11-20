namespace StarWars.EditorLevel
{
    partial class Editor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AsteroidRadioButton = new System.Windows.Forms.RadioButton();
            this.PlanetRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RubishRadioButton = new System.Windows.Forms.RadioButton();
            this.GridCheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКартуToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьКартуToolStripMenuItem
            // 
            this.сохранитьКартуToolStripMenuItem.Name = "сохранитьКартуToolStripMenuItem";
            this.сохранитьКартуToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.сохранитьКартуToolStripMenuItem.Text = "Сохранить карту";
            this.сохранитьКартуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКартуToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1309F));
            this.tableLayoutPanel1.Controls.Add(this.AsteroidRadioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlanetRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.RubishRadioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GridCheck, 0, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 592);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AsteroidRadioButton
            // 
            this.AsteroidRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AsteroidRadioButton.AutoSize = true;
            this.AsteroidRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsteroidRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AsteroidRadioButton.Location = new System.Drawing.Point(3, 103);
            this.AsteroidRadioButton.Name = "AsteroidRadioButton";
            this.AsteroidRadioButton.Size = new System.Drawing.Size(94, 44);
            this.AsteroidRadioButton.TabIndex = 5;
            this.AsteroidRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlanetRadioButton
            // 
            this.PlanetRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.PlanetRadioButton.AutoSize = true;
            this.PlanetRadioButton.Checked = true;
            this.PlanetRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanetRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlanetRadioButton.Location = new System.Drawing.Point(3, 3);
            this.PlanetRadioButton.Name = "PlanetRadioButton";
            this.PlanetRadioButton.Size = new System.Drawing.Size(94, 44);
            this.PlanetRadioButton.TabIndex = 2;
            this.PlanetRadioButton.TabStop = true;
            this.PlanetRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(103, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 12);
            this.pictureBox1.Size = new System.Drawing.Size(848, 577);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // RubishRadioButton
            // 
            this.RubishRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.RubishRadioButton.AutoSize = true;
            this.RubishRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RubishRadioButton.Location = new System.Drawing.Point(3, 53);
            this.RubishRadioButton.Name = "RubishRadioButton";
            this.RubishRadioButton.Size = new System.Drawing.Size(94, 44);
            this.RubishRadioButton.TabIndex = 1;
            this.RubishRadioButton.UseVisualStyleBackColor = true;
            // 
            // GridCheck
            // 
            this.GridCheck.Checked = true;
            this.GridCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridCheck.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GridCheck.Location = new System.Drawing.Point(3, 553);
            this.GridCheck.Name = "GridCheck";
            this.GridCheck.Size = new System.Drawing.Size(94, 44);
            this.GridCheck.TabIndex = 4;
            this.GridCheck.Text = "Show Grid";
            this.GridCheck.UseVisualStyleBackColor = true;
            this.GridCheck.CheckStateChanged += new System.EventHandler(this.GridCheck_CheckStateChanged);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 616);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.Text = "EditorLevelForm";
            this.Load += new System.EventHandler(this.EditorLevelForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКартуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton AsteroidRadioButton;
        private System.Windows.Forms.RadioButton PlanetRadioButton;
        private System.Windows.Forms.RadioButton RubishRadioButton;
        private System.Windows.Forms.CheckBox GridCheck;

    }
}