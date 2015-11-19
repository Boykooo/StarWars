namespace StarWars.EditorLevel
{
    partial class SaveMap
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.SafeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBox.Location = new System.Drawing.Point(12, 32);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(206, 26);
            this.InputBox.TabIndex = 0;
            // 
            // SafeButton
            // 
            this.SafeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SafeButton.Location = new System.Drawing.Point(224, 32);
            this.SafeButton.Name = "SafeButton";
            this.SafeButton.Size = new System.Drawing.Size(69, 28);
            this.SafeButton.TabIndex = 1;
            this.SafeButton.Text = "OK";
            this.SafeButton.UseVisualStyleBackColor = true;
            this.SafeButton.Click += new System.EventHandler(this.SafeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название карты";
            // 
            // SaveMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 66);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SafeButton);
            this.Controls.Add(this.InputBox);
            this.Name = "SaveMap";
            this.Text = "SafeMap";
            this.Load += new System.EventHandler(this.SaveMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button SafeButton;
        private System.Windows.Forms.Label label1;
    }
}