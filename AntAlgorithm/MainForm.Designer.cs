namespace AntAlgorithm
{
	partial class MainForm
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
			if(disposing && (components != null))
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._lblMinLengthValue = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._lblTime = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._tboxP = new System.Windows.Forms.TextBox();
			this._tboxIterationsCount = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this._tboxQ = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this._tboxBeta = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this._tboxAlpha = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(244, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 47);
			this.button1.TabIndex = 0;
			this.button1.Text = "Запуск алгоритма";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnButtonCalculateClick);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(244, 82);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 47);
			this.button2.TabIndex = 1;
			this.button2.Text = "Изменить граф";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.OnEditGraphButtonClick);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Муравьиный алгоритм",
            "Полный перебор"});
			this.comboBox1.Location = new System.Drawing.Point(12, 29);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(226, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.OnComboboxSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Выбор алгоритма:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 229);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Длина кратчайшего пути:";
			// 
			// _lblMinLengthValue
			// 
			this._lblMinLengthValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._lblMinLengthValue.Location = new System.Drawing.Point(229, 223);
			this._lblMinLengthValue.Name = "_lblMinLengthValue";
			this._lblMinLengthValue.Size = new System.Drawing.Size(119, 25);
			this._lblMinLengthValue.TabIndex = 5;
			this._lblMinLengthValue.Text = "0";
			this._lblMinLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 251);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Кратчайший путь:";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(112, 248);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox1.Size = new System.Drawing.Size(236, 20);
			this.textBox1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Время работы алгоритма:";
			// 
			// _lblTime
			// 
			this._lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._lblTime.Location = new System.Drawing.Point(229, 200);
			this._lblTime.Name = "_lblTime";
			this._lblTime.Size = new System.Drawing.Size(119, 25);
			this._lblTime.TabIndex = 5;
			this._lblTime.Text = "0";
			this._lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this._tboxP);
			this.groupBox1.Controls.Add(this._tboxIterationsCount);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this._tboxQ);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this._tboxBeta);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this._tboxAlpha);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(13, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(225, 147);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры";
			// 
			// _tboxP
			// 
			this._tboxP.Location = new System.Drawing.Point(107, 95);
			this._tboxP.Name = "_tboxP";
			this._tboxP.Size = new System.Drawing.Size(112, 20);
			this._tboxP.TabIndex = 1;
			// 
			// _tboxIterationsCount
			// 
			this._tboxIterationsCount.Location = new System.Drawing.Point(107, 121);
			this._tboxIterationsCount.Name = "_tboxIterationsCount";
			this._tboxIterationsCount.Size = new System.Drawing.Size(112, 20);
			this._tboxIterationsCount.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(17, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "P:";
			// 
			// _tboxQ
			// 
			this._tboxQ.Location = new System.Drawing.Point(107, 69);
			this._tboxQ.Name = "_tboxQ";
			this._tboxQ.Size = new System.Drawing.Size(112, 20);
			this._tboxQ.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 124);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Кол-во итераций:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Q:";
			// 
			// _tboxBeta
			// 
			this._tboxBeta.Location = new System.Drawing.Point(107, 43);
			this._tboxBeta.Name = "_tboxBeta";
			this._tboxBeta.Size = new System.Drawing.Size(112, 20);
			this._tboxBeta.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "β:";
			// 
			// _tboxAlpha
			// 
			this._tboxAlpha.Location = new System.Drawing.Point(107, 17);
			this._tboxAlpha.Name = "_tboxAlpha";
			this._tboxAlpha.Size = new System.Drawing.Size(112, 20);
			this._tboxAlpha.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "α:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 278);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this._lblTime);
			this.Controls.Add(this._lblMinLengthValue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Муравьиный алгоритм";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label _lblMinLengthValue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label _lblTime;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox _tboxIterationsCount;
		private System.Windows.Forms.TextBox _tboxQ;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox _tboxBeta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _tboxAlpha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox _tboxP;
		private System.Windows.Forms.Label label9;
	}
}

