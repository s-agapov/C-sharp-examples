namespace Flappy_Bird_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pipeTop = new PictureBox();
            flappyBird = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(595, 12);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(100, 142);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            pipeTop.Click += pipeTop_Click;
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.bird;
            flappyBird.Location = new Point(237, 236);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(73, 64);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(516, 367);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(100, 150);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Location = new Point(12, 523);
            ground.Name = "ground";
            ground.Size = new Size(776, 50);
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            scoreText.Location = new Point(30, 13);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(133, 47);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score:0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 585);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(flappyBird);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = "Flappy Bird Game";
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox flappyBird;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
    }
}