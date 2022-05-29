
namespace Graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcomeText = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.copy = new System.Windows.Forms.Label();
            this.picRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Bahnschrift Light", 40F);
            this.welcomeText.Location = new System.Drawing.Point(196, 48);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(569, 195);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Добро пожаловать в\r\n учебное приложение\r\n \"Графоман\"";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startBtn.Location = new System.Drawing.Point(225, 315);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(238, 84);
            this.startBtn.TabIndex = 1;
            this.startBtn.TabStop = false;
            this.startBtn.Text = "Начать";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Location = new System.Drawing.Point(505, 315);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(238, 84);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // picLeft
            // 
            this.picLeft.Image = ((System.Drawing.Image)(resources.GetObject("picLeft.Image")));
            this.picLeft.Location = new System.Drawing.Point(30, 501);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(128, 123);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeft.TabIndex = 3;
            this.picLeft.TabStop = false;
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copy.Location = new System.Drawing.Point(487, 627);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(459, 21);
            this.copy.TabIndex = 4;
            this.copy.Text = "©Кравченко Г.А. Садков М.А. Осташов Н.С. Аристова Д.К. 2022";
            // 
            // picRight
            // 
            this.picRight.Image = ((System.Drawing.Image)(resources.GetObject("picRight.Image")));
            this.picRight.Location = new System.Drawing.Point(787, 495);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(121, 111);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRight.TabIndex = 5;
            this.picRight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(958, 657);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.welcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(974, 696);
            this.MinimumSize = new System.Drawing.Size(974, 696);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приветственное окно - Графоман";
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.Label copy;
        private System.Windows.Forms.PictureBox picRight;
    }
}

