namespace ballPhysics
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TrackBar();
            this.ballRadius = new System.Windows.Forms.TextBox();
            this.ballCount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startModeling = new System.Windows.Forms.Button();
            this.frameTimer = new System.Windows.Forms.Timer(this.components);
            this.gravityK = new System.Windows.Forms.TrackBar();
            this.systemFriction = new System.Windows.Forms.TrackBar();
            this.objGravCoeffTrackBar = new System.Windows.Forms.TrackBar();
            this.cubicKepulsionTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sequentialMovementСheckBox = new System.Windows.Forms.CheckBox();
            this.collisionsСheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemFriction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objGravCoeffTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubicKepulsionTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1103, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Скорость моделирования";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(826, 129);
            this.speed.Maximum = 50;
            this.speed.Minimum = 1;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(261, 45);
            this.speed.TabIndex = 15;
            this.speed.Value = 50;
            this.speed.Scroll += new System.EventHandler(this.speedScroll);
            // 
            // ballRadius
            // 
            this.ballRadius.Location = new System.Drawing.Point(280, 59);
            this.ballRadius.Name = "ballRadius";
            this.ballRadius.Size = new System.Drawing.Size(76, 20);
            this.ballRadius.TabIndex = 14;
            this.ballRadius.Text = "4";
            // 
            // ballCount
            // 
            this.ballCount.Location = new System.Drawing.Point(166, 59);
            this.ballCount.Name = "ballCount";
            this.ballCount.Size = new System.Drawing.Size(73, 20);
            this.ballCount.TabIndex = 13;
            this.ballCount.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(35, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 433);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Размер шаров";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Кол-во шаров";
            // 
            // startModeling
            // 
            this.startModeling.Location = new System.Drawing.Point(36, 33);
            this.startModeling.Name = "startModeling";
            this.startModeling.Size = new System.Drawing.Size(102, 53);
            this.startModeling.TabIndex = 9;
            this.startModeling.Text = "Начать моделирование";
            this.startModeling.UseVisualStyleBackColor = true;
            this.startModeling.Click += new System.EventHandler(this.startModelingClick);
            // 
            // frameTimer
            // 
            this.frameTimer.Interval = 5;
            this.frameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // gravityK
            // 
            this.gravityK.Location = new System.Drawing.Point(816, 199);
            this.gravityK.Maximum = 1000;
            this.gravityK.Name = "gravityK";
            this.gravityK.Size = new System.Drawing.Size(271, 45);
            this.gravityK.TabIndex = 18;
            // 
            // systemFriction
            // 
            this.systemFriction.Location = new System.Drawing.Point(816, 250);
            this.systemFriction.Maximum = 1000;
            this.systemFriction.Name = "systemFriction";
            this.systemFriction.Size = new System.Drawing.Size(271, 45);
            this.systemFriction.TabIndex = 19;
            // 
            // objGravCoeffTrackBar
            // 
            this.objGravCoeffTrackBar.Location = new System.Drawing.Point(816, 301);
            this.objGravCoeffTrackBar.Maximum = 1000;
            this.objGravCoeffTrackBar.Name = "objGravCoeffTrackBar";
            this.objGravCoeffTrackBar.Size = new System.Drawing.Size(271, 45);
            this.objGravCoeffTrackBar.TabIndex = 20;
            // 
            // cubicKepulsionTrackBar
            // 
            this.cubicKepulsionTrackBar.Location = new System.Drawing.Point(816, 352);
            this.cubicKepulsionTrackBar.Maximum = 1000;
            this.cubicKepulsionTrackBar.Name = "cubicKepulsionTrackBar";
            this.cubicKepulsionTrackBar.Size = new System.Drawing.Size(271, 45);
            this.cubicKepulsionTrackBar.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1103, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Гравитация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1103, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Трение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1103, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Притяжение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1103, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Отталкивание";
            // 
            // sequentialMovementСheckBox
            // 
            this.sequentialMovementСheckBox.AutoSize = true;
            this.sequentialMovementСheckBox.Location = new System.Drawing.Point(826, 403);
            this.sequentialMovementСheckBox.Name = "sequentialMovementСheckBox";
            this.sequentialMovementСheckBox.Size = new System.Drawing.Size(248, 17);
            this.sequentialMovementСheckBox.TabIndex = 26;
            this.sequentialMovementСheckBox.Text = "Последовательное перемещение объектов";
            this.sequentialMovementСheckBox.UseVisualStyleBackColor = true;
            // 
            // collisionsСheckBox
            // 
            this.collisionsСheckBox.AutoSize = true;
            this.collisionsСheckBox.Location = new System.Drawing.Point(826, 439);
            this.collisionsСheckBox.Name = "collisionsСheckBox";
            this.collisionsСheckBox.Size = new System.Drawing.Size(86, 17);
            this.collisionsСheckBox.TabIndex = 27;
            this.collisionsСheckBox.Text = "Соударения";
            this.collisionsСheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 553);
            this.Controls.Add(this.collisionsСheckBox);
            this.Controls.Add(this.sequentialMovementСheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cubicKepulsionTrackBar);
            this.Controls.Add(this.objGravCoeffTrackBar);
            this.Controls.Add(this.systemFriction);
            this.Controls.Add(this.gravityK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.ballRadius);
            this.Controls.Add(this.ballCount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startModeling);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemFriction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objGravCoeffTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubicKepulsionTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar speed;
        private System.Windows.Forms.TextBox ballRadius;
        private System.Windows.Forms.TextBox ballCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startModeling;
        private System.Windows.Forms.Timer frameTimer;
        private System.Windows.Forms.TrackBar gravityK;
        private System.Windows.Forms.TrackBar systemFriction;
        private System.Windows.Forms.TrackBar objGravCoeffTrackBar;
        private System.Windows.Forms.TrackBar cubicKepulsionTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox sequentialMovementСheckBox;
        private System.Windows.Forms.CheckBox collisionsСheckBox;
    }
}

