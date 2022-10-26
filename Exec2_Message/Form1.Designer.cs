namespace Exec2_Message
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.timeButton = new System.Windows.Forms.Button();
			this.timeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timeButton
			// 
			this.timeButton.Location = new System.Drawing.Point(71, 50);
			this.timeButton.Name = "timeButton";
			this.timeButton.Size = new System.Drawing.Size(75, 23);
			this.timeButton.TabIndex = 0;
			this.timeButton.Text = "顯示時間";
			this.timeButton.UseVisualStyleBackColor = true;
			this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(191, 55);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(25, 12);
			this.timeLabel.TabIndex = 1;
			this.timeLabel.Text = "time";
			this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.timeButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button timeButton;
		private System.Windows.Forms.Label timeLabel;
	}
}

