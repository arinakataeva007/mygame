namespace Shooter3
{
    partial class Shooter
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
            this.components = new System.ComponentModel.Container();
            this.Right = new System.Windows.Forms.Timer(this.components);
            this.Left = new System.Windows.Forms.Timer(this.components);
            this.Up = new System.Windows.Forms.Timer(this.components);
            this.Down = new System.Windows.Forms.Timer(this.components);
            this.MoveBulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.Enemies = new System.Windows.Forms.Timer(this.components);
            this.MeteorMove = new System.Windows.Forms.Timer(this.components);
            this.HardMove = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.LevelsNumber = new System.Windows.Forms.Label();
            this.PointsScore = new System.Windows.Forms.Label();
            this.staticPers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.staticPers)).BeginInit();
            this.SuspendLayout();
            // 
            // Right
            // 
            this.Right.Enabled = true;
            this.Right.Interval = 10;
            this.Right.Tick += new System.EventHandler(this.Right_Tick);
            // 
            // Left
            // 
            this.Left.Enabled = true;
            this.Left.Interval = 10;
            this.Left.Tick += new System.EventHandler(this.Left_Tick);
            // 
            // Up
            // 
            this.Up.Enabled = true;
            this.Up.Interval = 10;
            this.Up.Tick += new System.EventHandler(this.Up_Tick);
            // 
            // Down
            // 
            this.Down.Enabled = true;
            this.Down.Interval = 10;
            this.Down.Tick += new System.EventHandler(this.Down_Tick);
            // 
            // MoveBulletsTimer
            // 
            this.MoveBulletsTimer.Enabled = true;
            this.MoveBulletsTimer.Interval = 10;
            this.MoveBulletsTimer.Tick += new System.EventHandler(this.MoveBulletsTimer_Tick);
            // 
            // Enemies
            // 
            this.Enemies.Enabled = true;
            this.Enemies.Interval = 10;
            this.Enemies.Tick += new System.EventHandler(this.Enemies_Tick);
            // 
            // MeteorMove
            // 
            this.MeteorMove.Enabled = true;
            this.MeteorMove.Interval = 10;
            this.MeteorMove.Tick += new System.EventHandler(this.KnifMove_Tick);
            // 
            // HardMove
            // 
            this.HardMove.Enabled = true;
            this.HardMove.Interval = 10;
            this.HardMove.Tick += new System.EventHandler(this.HardMove_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.BackColor = System.Drawing.Color.Transparent;
            this.lable3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lable3.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lable3.Location = new System.Drawing.Point(10, 58);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(106, 37);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "Level";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.BackColor = System.Drawing.Color.Transparent;
            this.lable2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lable2.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable2.Location = new System.Drawing.Point(10, 9);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(109, 37);
            this.lable2.TabIndex = 3;
            this.lable2.Text = "Score";
            // 
            // LevelsNumber
            // 
            this.LevelsNumber.AutoSize = true;
            this.LevelsNumber.BackColor = System.Drawing.Color.Transparent;
            this.LevelsNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LevelsNumber.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelsNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LevelsNumber.Location = new System.Drawing.Point(133, 58);
            this.LevelsNumber.Name = "LevelsNumber";
            this.LevelsNumber.Size = new System.Drawing.Size(31, 37);
            this.LevelsNumber.TabIndex = 4;
            this.LevelsNumber.Text = "1";
            // 
            // PointsScore
            // 
            this.PointsScore.AutoSize = true;
            this.PointsScore.BackColor = System.Drawing.Color.Transparent;
            this.PointsScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PointsScore.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PointsScore.Location = new System.Drawing.Point(133, 9);
            this.PointsScore.Name = "PointsScore";
            this.PointsScore.Size = new System.Drawing.Size(65, 37);
            this.PointsScore.TabIndex = 5;
            this.PointsScore.Text = "00";
            // 
            // staticPers
            // 
            this.staticPers.BackColor = System.Drawing.Color.Transparent;
            this.staticPers.BackgroundImage = global::Shooter3.Properties.Resources.kosmicheskii;
            this.staticPers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.staticPers.Enabled = false;
            this.staticPers.InitialImage = null;
            this.staticPers.Location = new System.Drawing.Point(123, 261);
            this.staticPers.Name = "staticPers";
            this.staticPers.Size = new System.Drawing.Size(100, 100);
            this.staticPers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staticPers.TabIndex = 6;
            this.staticPers.TabStop = false;
            // 
            // Shooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shooter3.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.staticPers);
            this.Controls.Add(this.PointsScore);
            this.Controls.Add(this.LevelsNumber);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Shooter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Shooter";
            this.Load += new System.EventHandler(this.Shooter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Shooter_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Shooter_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.staticPers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Right;
        private System.Windows.Forms.Timer Left;
        private System.Windows.Forms.Timer Up;
        private System.Windows.Forms.Timer Down;
        private System.Windows.Forms.Timer MoveBulletsTimer;
        private System.Windows.Forms.Timer Enemies;
        private System.Windows.Forms.Timer MeteorMove;
        private System.Windows.Forms.Timer HardMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label LevelsNumber;
        private System.Windows.Forms.Label PointsScore;
        private System.Windows.Forms.PictureBox staticPers;
    }
}