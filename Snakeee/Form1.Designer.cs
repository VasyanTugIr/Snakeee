namespace Snakeee
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.schet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wall2 = new System.Windows.Forms.PictureBox();
            this.wall1 = new System.Windows.Forms.PictureBox();
            this.wall4 = new System.Windows.Forms.PictureBox();
            this.wall3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.PaleGreen;
            this.pbCanvas.Location = new System.Drawing.Point(12, 12);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(557, 503);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(175, 119);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(44, 16);
            this.lblGameOver.TabIndex = 1;
            this.lblGameOver.Text = "label2";
            // 
            // schet
            // 
            this.schet.AutoSize = true;
            this.schet.Location = new System.Drawing.Point(652, 96);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(44, 16);
            this.schet.TabIndex = 2;
            this.schet.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Purple;
            this.wall2.Location = new System.Drawing.Point(78, 178);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(20, 198);
            this.wall2.TabIndex = 3;
            this.wall2.TabStop = false;
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Purple;
            this.wall1.Location = new System.Drawing.Point(462, 178);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(20, 198);
            this.wall1.TabIndex = 3;
            this.wall1.TabStop = false;
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.Purple;
            this.wall4.Location = new System.Drawing.Point(95, 260);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(100, 26);
            this.wall4.TabIndex = 4;
            this.wall4.TabStop = false;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Purple;
            this.wall3.Location = new System.Drawing.Point(366, 260);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(100, 26);
            this.wall3.TabIndex = 4;
            this.wall3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 547);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label schet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox wall2;
        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.PictureBox wall4;
        private System.Windows.Forms.PictureBox wall3;
    }
}

