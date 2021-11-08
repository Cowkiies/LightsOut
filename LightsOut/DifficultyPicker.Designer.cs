
namespace LightsOut
{
    partial class DifficultyPicker
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
            this.submitButton = new System.Windows.Forms.Button();
            this.difficultyGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.difficultyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submitButton.Location = new System.Drawing.Point(0, 150);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(163, 29);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // difficultyGroupBox
            // 
            this.difficultyGroupBox.Controls.Add(this.radioButtonHard);
            this.difficultyGroupBox.Controls.Add(this.radioButtonNormal);
            this.difficultyGroupBox.Controls.Add(this.radioButtonEasy);
            this.difficultyGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficultyGroupBox.Location = new System.Drawing.Point(0, 0);
            this.difficultyGroupBox.Name = "difficultyGroupBox";
            this.difficultyGroupBox.Size = new System.Drawing.Size(163, 125);
            this.difficultyGroupBox.TabIndex = 2;
            this.difficultyGroupBox.TabStop = false;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(10, 86);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(63, 24);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Tag = "3";
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(10, 56);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(80, 24);
            this.radioButtonNormal.TabIndex = 1;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Tag = "2";
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(10, 26);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(59, 24);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Tag = "1";
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // DifficultyPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 179);
            this.Controls.Add(this.difficultyGroupBox);
            this.Controls.Add(this.submitButton);
            this.Name = "DifficultyPicker";
            this.Text = "Choose difficulty";
            this.difficultyGroupBox.ResumeLayout(false);
            this.difficultyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox difficultyGroupBox;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonEasy;
    }
}