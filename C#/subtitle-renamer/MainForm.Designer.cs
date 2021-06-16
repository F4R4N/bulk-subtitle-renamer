/*
 * Created by SharpDevelop.
 * User: Parsa rayaneh
 * Date: 2021-06-12
 * Time: 9:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace subtitle_renamer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label errorsubtitleIndex;
		private System.Windows.Forms.Label errorsubtitleFormat;
		private System.Windows.Forms.Label errorvideoIndex;
		private System.Windows.Forms.Label errorvideoFormat;
		private System.Windows.Forms.Label errorseason;
		private System.Windows.Forms.Label errorquality;
		private System.Windows.Forms.Label errorname;
		private System.Windows.Forms.Label errorpath;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.button2 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.errorsubtitleIndex = new System.Windows.Forms.Label();
			this.errorsubtitleFormat = new System.Windows.Forms.Label();
			this.errorvideoIndex = new System.Windows.Forms.Label();
			this.errorvideoFormat = new System.Windows.Forms.Label();
			this.errorseason = new System.Windows.Forms.Label();
			this.errorquality = new System.Windows.Forms.Label();
			this.errorname = new System.Windows.Forms.Label();
			this.errorpath = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label13 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label14 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(453, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 29);
			this.button1.TabIndex = 0;
			this.button1.Text = "Choose path";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"mkv",
			"avi",
			"flv",
			"mpeg",
			"mp2",
			"mov",
			"mp4",
			"m4a",
			"vob",
			"webm"});
			this.comboBox1.Location = new System.Drawing.Point(157, 246);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(163, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Series folder path:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.Location = new System.Drawing.Point(6, 245);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Series video format:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(223, 81);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(293, 21);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(223, 132);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(293, 21);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(223, 181);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(293, 21);
			this.textBox3.TabIndex = 7;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown1.Location = new System.Drawing.Point(343, 290);
			this.numericUpDown1.Maximum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(163, 21);
			this.numericUpDown1.TabIndex = 8;
			this.numericUpDown1.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label4.Location = new System.Drawing.Point(6, 288);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(328, 36);
			this.label4.TabIndex = 9;
			this.label4.Text = "which number is episode number in video name?\r\n(if you dont know see Help)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label5.Location = new System.Drawing.Point(6, 358);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Series subtitle format:";
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"srt",
			"ass",
			"ssa",
			"ttml",
			"sbv",
			"dfxp",
			"vtt",
			"txt"});
			this.comboBox2.Location = new System.Drawing.Point(157, 358);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(163, 21);
			this.comboBox2.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label6.Location = new System.Drawing.Point(0, 337);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(595, 2);
			this.label6.TabIndex = 12;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label7.Location = new System.Drawing.Point(0, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(595, 2);
			this.label7.TabIndex = 13;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label8.Location = new System.Drawing.Point(6, 403);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(339, 36);
			this.label8.TabIndex = 14;
			this.label8.Text = "which number is episode number in subtitle name?\r\n(if you dont know see Help)\r\n";
			this.label8.Click += new System.EventHandler(this.Label8Click);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown2.Location = new System.Drawing.Point(343, 405);
			this.numericUpDown2.Maximum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(160, 21);
			this.numericUpDown2.TabIndex = 15;
			this.numericUpDown2.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(428, 485);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 37);
			this.button2.TabIndex = 17;
			this.button2.Text = "Rename";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(107, 18);
			this.label10.TabIndex = 18;
			this.label10.Text = "Series name:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label11.Location = new System.Drawing.Point(6, 130);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(211, 18);
			this.label11.TabIndex = 19;
			this.label11.Text = "Movie quality e.g. (480p, 720p):";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label12.Location = new System.Drawing.Point(6, 180);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 18);
			this.label12.TabIndex = 20;
			this.label12.Text = "Season No.:";
			// 
			// errorsubtitleIndex
			// 
			this.errorsubtitleIndex.AutoSize = true;
			this.errorsubtitleIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.errorsubtitleIndex.ForeColor = System.Drawing.Color.Red;
			this.errorsubtitleIndex.Location = new System.Drawing.Point(16, 442);
			this.errorsubtitleIndex.Name = "errorsubtitleIndex";
			this.errorsubtitleIndex.Size = new System.Drawing.Size(0, 18);
			this.errorsubtitleIndex.TabIndex = 21;
			// 
			// errorsubtitleFormat
			// 
			this.errorsubtitleFormat.AutoSize = true;
			this.errorsubtitleFormat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorsubtitleFormat.ForeColor = System.Drawing.Color.Red;
			this.errorsubtitleFormat.Location = new System.Drawing.Point(337, 360);
			this.errorsubtitleFormat.Name = "errorsubtitleFormat";
			this.errorsubtitleFormat.Size = new System.Drawing.Size(0, 14);
			this.errorsubtitleFormat.TabIndex = 22;
			// 
			// errorvideoIndex
			// 
			this.errorvideoIndex.AutoSize = true;
			this.errorvideoIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.errorvideoIndex.ForeColor = System.Drawing.Color.Red;
			this.errorvideoIndex.Location = new System.Drawing.Point(217, 306);
			this.errorvideoIndex.Name = "errorvideoIndex";
			this.errorvideoIndex.Size = new System.Drawing.Size(0, 18);
			this.errorvideoIndex.TabIndex = 23;
			// 
			// errorvideoFormat
			// 
			this.errorvideoFormat.AutoSize = true;
			this.errorvideoFormat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorvideoFormat.ForeColor = System.Drawing.Color.Red;
			this.errorvideoFormat.Location = new System.Drawing.Point(337, 248);
			this.errorvideoFormat.Name = "errorvideoFormat";
			this.errorvideoFormat.Size = new System.Drawing.Size(0, 14);
			this.errorvideoFormat.TabIndex = 24;
			// 
			// errorseason
			// 
			this.errorseason.AutoSize = true;
			this.errorseason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorseason.ForeColor = System.Drawing.Color.Red;
			this.errorseason.Location = new System.Drawing.Point(17, 201);
			this.errorseason.Name = "errorseason";
			this.errorseason.Size = new System.Drawing.Size(0, 14);
			this.errorseason.TabIndex = 25;
			// 
			// errorquality
			// 
			this.errorquality.AutoSize = true;
			this.errorquality.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorquality.ForeColor = System.Drawing.Color.Red;
			this.errorquality.Location = new System.Drawing.Point(17, 151);
			this.errorquality.Name = "errorquality";
			this.errorquality.Size = new System.Drawing.Size(0, 14);
			this.errorquality.TabIndex = 26;
			// 
			// errorname
			// 
			this.errorname.AutoSize = true;
			this.errorname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorname.ForeColor = System.Drawing.Color.Red;
			this.errorname.Location = new System.Drawing.Point(17, 100);
			this.errorname.Name = "errorname";
			this.errorname.Size = new System.Drawing.Size(0, 14);
			this.errorname.TabIndex = 27;
			// 
			// errorpath
			// 
			this.errorpath.AutoSize = true;
			this.errorpath.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorpath.ForeColor = System.Drawing.Color.Red;
			this.errorpath.Location = new System.Drawing.Point(19, 48);
			this.errorpath.Name = "errorpath";
			this.errorpath.Size = new System.Drawing.Size(0, 14);
			this.errorpath.TabIndex = 28;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(157, 28);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(290, 21);
			this.textBox4.TabIndex = 29;
			this.textBox4.Click += new System.EventHandler(this.TextBox4OnClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 508);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 16);
			this.label1.TabIndex = 30;
			this.label1.Text = "Created by ";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(83, 508);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(45, 16);
			this.linkLabel1.TabIndex = 31;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Faran";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(125, 508);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(99, 16);
			this.label13.TabIndex = 32;
			this.label13.Text = "License under";
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel2.Location = new System.Drawing.Point(220, 508);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(39, 16);
			this.linkLabel2.TabIndex = 33;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "LGPL";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
			// 
			// label14
			// 
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label14.Location = new System.Drawing.Point(0, 454);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(595, 2);
			this.label14.TabIndex = 34;
			this.label14.Text = "label14";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(310, 485);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(108, 37);
			this.button3.TabIndex = 35;
			this.button3.Text = "Help!";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 534);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.errorpath);
			this.Controls.Add(this.errorname);
			this.Controls.Add(this.errorquality);
			this.Controls.Add(this.errorseason);
			this.Controls.Add(this.errorvideoFormat);
			this.Controls.Add(this.errorvideoIndex);
			this.Controls.Add(this.errorsubtitleFormat);
			this.Controls.Add(this.errorsubtitleIndex);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Subtitle Matcher";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
