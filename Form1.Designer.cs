namespace MusicPlayer
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_description = new TextBox();
            txt_ImageURL = new TextBox();
            txt_albumYear = new TextBox();
            txt_albumArtist = new TextBox();
            txt_albumName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(395, 40);
            button1.Name = "button1";
            button1.Size = new Size(180, 34);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(395, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(868, 264);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(1151, 37);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(744, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 31);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1312, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_ImageURL);
            groupBox1.Controls.Add(txt_albumYear);
            groupBox1.Controls.Add(txt_albumArtist);
            groupBox1.Controls.Add(txt_albumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(49, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 313);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // button3
            // 
            button3.Location = new Point(126, 255);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 10;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(127, 204);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(154, 31);
            txt_description.TabIndex = 9;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(126, 164);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(154, 31);
            txt_ImageURL.TabIndex = 8;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(126, 124);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(154, 31);
            txt_albumYear.TabIndex = 7;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(126, 84);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(154, 31);
            txt_albumArtist.TabIndex = 6;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(126, 44);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(154, 31);
            txt_albumName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 204);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 164);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 124);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 395);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(395, 435);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(731, 233);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(395, 678);
            button4.Name = "button4";
            button4.Size = new Size(202, 34);
            button4.TabIndex = 8;
            button4.Text = "Delete selected track";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(1151, 435);
            webView21.Name = "webView21";
            webView21.Size = new Size(531, 343);
            webView21.Source = new Uri("https://www.youtube.com/", UriKind.Absolute);
            webView21.TabIndex = 11;
            webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 790);
            Controls.Add(webView21);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private TextBox txt_description;
        private TextBox txt_ImageURL;
        private TextBox txt_albumYear;
        private TextBox txt_albumArtist;
        private TextBox txt_albumName;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button4;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}