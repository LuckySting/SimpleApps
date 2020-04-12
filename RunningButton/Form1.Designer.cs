namespace SimpleApps
{
    partial class MainForm
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
            this.RunningButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunningButton
            // 
            this.RunningButton.Location = new System.Drawing.Point(299, 169);
            this.RunningButton.Name = "RunningButton";
            this.RunningButton.Size = new System.Drawing.Size(133, 100);
            this.RunningButton.TabIndex = 0;
            this.RunningButton.Text = "Push me";
            this.RunningButton.UseVisualStyleBackColor = true;
            this.RunningButton.Click += new System.EventHandler(this.RunningButton_click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 438);
            this.Controls.Add(this.RunningButton);
            this.Name = "MainForm";
            this.Text = "Running Button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunningButton;
    }
}

