namespace StarWars.Game
{
    partial class GameForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoldBox = new System.Windows.Forms.PictureBox();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.TitaniumBox = new System.Windows.Forms.PictureBox();
            this.IridiumBox = new System.Windows.Forms.PictureBox();
            this.FoodBox = new System.Windows.Forms.PictureBox();
            this.EndTurn = new System.Windows.Forms.Button();
            this.StatusGame = new System.Windows.Forms.Label();
            this.TitaniumLabel = new System.Windows.Forms.Label();
            this.IridiumLabel = new System.Windows.Forms.Label();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoldBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitaniumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IridiumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.GoldBox);
            this.panel1.Controls.Add(this.GoldLabel);
            this.panel1.Controls.Add(this.TitaniumBox);
            this.panel1.Controls.Add(this.IridiumBox);
            this.panel1.Controls.Add(this.FoodBox);
            this.panel1.Controls.Add(this.EndTurn);
            this.panel1.Controls.Add(this.StatusGame);
            this.panel1.Controls.Add(this.TitaniumLabel);
            this.panel1.Controls.Add(this.IridiumLabel);
            this.panel1.Controls.Add(this.FoodLabel);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 30);
            this.panel1.TabIndex = 0;
            // 
            // GoldBox
            // 
            this.GoldBox.Location = new System.Drawing.Point(354, 3);
            this.GoldBox.Name = "GoldBox";
            this.GoldBox.Size = new System.Drawing.Size(71, 27);
            this.GoldBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoldBox.TabIndex = 11;
            this.GoldBox.TabStop = false;
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoldLabel.Location = new System.Drawing.Point(425, 9);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(15, 16);
            this.GoldLabel.TabIndex = 5;
            this.GoldLabel.Text = "0";
            // 
            // TitaniumBox
            // 
            this.TitaniumBox.Location = new System.Drawing.Point(236, 1);
            this.TitaniumBox.Name = "TitaniumBox";
            this.TitaniumBox.Size = new System.Drawing.Size(71, 27);
            this.TitaniumBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitaniumBox.TabIndex = 12;
            this.TitaniumBox.TabStop = false;
            // 
            // IridiumBox
            // 
            this.IridiumBox.Location = new System.Drawing.Point(118, 1);
            this.IridiumBox.Name = "IridiumBox";
            this.IridiumBox.Size = new System.Drawing.Size(71, 27);
            this.IridiumBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IridiumBox.TabIndex = 11;
            this.IridiumBox.TabStop = false;
            // 
            // FoodBox
            // 
            this.FoodBox.Location = new System.Drawing.Point(1, 1);
            this.FoodBox.Name = "FoodBox";
            this.FoodBox.Size = new System.Drawing.Size(71, 27);
            this.FoodBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodBox.TabIndex = 10;
            this.FoodBox.TabStop = false;
            // 
            // EndTurn
            // 
            this.EndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndTurn.Location = new System.Drawing.Point(742, 0);
            this.EndTurn.Name = "EndTurn";
            this.EndTurn.Size = new System.Drawing.Size(99, 30);
            this.EndTurn.TabIndex = 9;
            this.EndTurn.Text = "Turn(enter)";
            this.EndTurn.UseVisualStyleBackColor = true;
            this.EndTurn.Click += new System.EventHandler(this.EndTurn_Click);
            // 
            // StatusGame
            // 
            this.StatusGame.AutoSize = true;
            this.StatusGame.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusGame.ForeColor = System.Drawing.Color.Blue;
            this.StatusGame.Location = new System.Drawing.Point(508, 4);
            this.StatusGame.Name = "StatusGame";
            this.StatusGame.Size = new System.Drawing.Size(228, 18);
            this.StatusGame.TabIndex = 8;
            this.StatusGame.Text = "Выберете стартовую планету";
            // 
            // TitaniumLabel
            // 
            this.TitaniumLabel.AutoSize = true;
            this.TitaniumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitaniumLabel.Location = new System.Drawing.Point(306, 8);
            this.TitaniumLabel.Name = "TitaniumLabel";
            this.TitaniumLabel.Size = new System.Drawing.Size(15, 16);
            this.TitaniumLabel.TabIndex = 5;
            this.TitaniumLabel.Text = "0";
            // 
            // IridiumLabel
            // 
            this.IridiumLabel.AutoSize = true;
            this.IridiumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IridiumLabel.Location = new System.Drawing.Point(188, 7);
            this.IridiumLabel.Name = "IridiumLabel";
            this.IridiumLabel.Size = new System.Drawing.Size(15, 16);
            this.IridiumLabel.TabIndex = 3;
            this.IridiumLabel.Text = "0";
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodLabel.Location = new System.Drawing.Point(71, 7);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(15, 16);
            this.FoodLabel.TabIndex = 1;
            this.FoodLabel.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 604);
            this.Controls.Add(this.panel1);
            this.Name = "GameForm";
            this.Text = "NewGameForm";
            this.Load += new System.EventHandler(this.NewGameForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoldBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitaniumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IridiumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EndTurn;
        private System.Windows.Forms.Label StatusGame;
        private System.Windows.Forms.Label TitaniumLabel;
        private System.Windows.Forms.Label IridiumLabel;
        private System.Windows.Forms.Label FoodLabel;
        private System.Windows.Forms.PictureBox GoldBox;
        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.PictureBox TitaniumBox;
        private System.Windows.Forms.PictureBox IridiumBox;
        private System.Windows.Forms.PictureBox FoodBox;

    }
}