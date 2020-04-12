namespace ColorPicker
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RedTrack = new System.Windows.Forms.TrackBar();
            this.GreenTrack = new System.Windows.Forms.TrackBar();
            this.BlueTrack = new System.Windows.Forms.TrackBar();
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.07504F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.92496F));
            this.tableLayoutPanel1.Controls.Add(this.ColorBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 584F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 297);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ColorBox
            // 
            this.ColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColorBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ColorBox.Location = new System.Drawing.Point(10, 10);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(10);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(263, 277);
            this.ColorBox.TabIndex = 0;
            this.ColorBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.Controls.Add(this.RedTrack, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.GreenTrack, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.BlueTrack, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.RedLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.GreenLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BlueLabel, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(303, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(526, 291);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // RedTrack
            // 
            this.RedTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RedTrack.BackColor = System.Drawing.SystemColors.Control;
            this.RedTrack.LargeChange = 1;
            this.RedTrack.Location = new System.Drawing.Point(244, 33);
            this.RedTrack.Margin = new System.Windows.Forms.Padding(10);
            this.RedTrack.Maximum = 255;
            this.RedTrack.Name = "RedTrack";
            this.RedTrack.Size = new System.Drawing.Size(251, 56);
            this.RedTrack.TabIndex = 0;
            this.RedTrack.TickFrequency = 20;
            // 
            // GreenTrack
            // 
            this.GreenTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GreenTrack.BackColor = System.Drawing.SystemColors.Control;
            this.GreenTrack.LargeChange = 1;
            this.GreenTrack.Location = new System.Drawing.Point(244, 116);
            this.GreenTrack.Margin = new System.Windows.Forms.Padding(10);
            this.GreenTrack.Maximum = 255;
            this.GreenTrack.Name = "GreenTrack";
            this.GreenTrack.Size = new System.Drawing.Size(251, 56);
            this.GreenTrack.TabIndex = 1;
            this.GreenTrack.TickFrequency = 20;
            // 
            // BlueTrack
            // 
            this.BlueTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BlueTrack.BackColor = System.Drawing.SystemColors.Control;
            this.BlueTrack.LargeChange = 1;
            this.BlueTrack.Location = new System.Drawing.Point(244, 199);
            this.BlueTrack.Margin = new System.Windows.Forms.Padding(10);
            this.BlueTrack.Maximum = 255;
            this.BlueTrack.Name = "BlueTrack";
            this.BlueTrack.Size = new System.Drawing.Size(251, 56);
            this.BlueTrack.TabIndex = 2;
            this.BlueTrack.TickFrequency = 20;
            // 
            // RedLabel
            // 
            this.RedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedLabel.Location = new System.Drawing.Point(92, 52);
            this.RedLabel.Margin = new System.Windows.Forms.Padding(10);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RedLabel.Size = new System.Drawing.Size(39, 18);
            this.RedLabel.TabIndex = 3;
            this.RedLabel.Text = "Red:";
            // 
            // GreenLabel
            // 
            this.GreenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenLabel.Location = new System.Drawing.Point(78, 135);
            this.GreenLabel.Margin = new System.Windows.Forms.Padding(10);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GreenLabel.Size = new System.Drawing.Size(53, 18);
            this.GreenLabel.TabIndex = 4;
            this.GreenLabel.Text = "Green:";
            // 
            // BlueLabel
            // 
            this.BlueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlueLabel.Location = new System.Drawing.Point(90, 218);
            this.BlueLabel.Margin = new System.Windows.Forms.Padding(10);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BlueLabel.Size = new System.Drawing.Size(41, 18);
            this.BlueLabel.TabIndex = 5;
            this.BlueLabel.Text = "Blue:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 297);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Color Picker";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox ColorBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar RedTrack;
        private System.Windows.Forms.TrackBar GreenTrack;
        private System.Windows.Forms.TrackBar BlueTrack;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
    }
}

