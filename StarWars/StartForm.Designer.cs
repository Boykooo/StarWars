namespace StarWars
{
    partial class StartForm
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
            this.NewGameButton = new System.Windows.Forms.Button();
            this.EditorLevelButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewGameButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewGameButton.Location = new System.Drawing.Point(806, 506);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(288, 48);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "Новая игра";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // EditorLevelButton
            // 
            this.EditorLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorLevelButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.EditorLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditorLevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditorLevelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditorLevelButton.Location = new System.Drawing.Point(806, 560);
            this.EditorLevelButton.Name = "EditorLevelButton";
            this.EditorLevelButton.Size = new System.Drawing.Size(288, 48);
            this.EditorLevelButton.TabIndex = 1;
            this.EditorLevelButton.Text = "Редактор уровней";
            this.EditorLevelButton.UseVisualStyleBackColor = false;
            this.EditorLevelButton.Click += new System.EventHandler(this.EditorLevelButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(806, 614);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(288, 48);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Выйти";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 683);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditorLevelButton);
            this.Controls.Add(this.NewGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button EditorLevelButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

