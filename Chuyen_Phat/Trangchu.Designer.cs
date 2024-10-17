namespace Chuyen_Phat
{
    partial class Trangchu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trangchu));
            btnTraCuu = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            btnTaoDon = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            toolTip1 = new ToolTip(components);
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.White;
            btnTraCuu.ContextMenuStrip = contextMenuStrip1;
            btnTraCuu.FlatStyle = FlatStyle.Flat;
            btnTraCuu.Location = new Point(59, 213);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(167, 62);
            btnTraCuu.TabIndex = 2;
            btnTraCuu.Text = "Tra Cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += button2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(223, 68);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(222, 32);
            toolStripMenuItem1.Text = "Tra cứu đơn hàng";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(222, 32);
            toolStripMenuItem2.Text = "Tra cứu cước phí";
            // 
            // btnTaoDon
            // 
            btnTaoDon.BackColor = Color.White;
            btnTaoDon.FlatStyle = FlatStyle.Flat;
            btnTaoDon.Location = new Point(62, 121);
            btnTaoDon.Name = "btnTaoDon";
            btnTaoDon.Size = new Size(164, 62);
            btnTaoDon.TabIndex = 1;
            btnTaoDon.Text = "Tạo Đơn";
            btnTaoDon.UseVisualStyleBackColor = false;
            btnTaoDon.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 34);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 34);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ContextMenuStrip = contextMenuStrip1;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(59, 35);
            button2.Name = "button2";
            button2.Size = new Size(167, 62);
            button2.TabIndex = 5;
            button2.Text = "  Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(69, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 34);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Trangchu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1755, 600);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(btnTraCuu);
            Controls.Add(pictureBox1);
            Controls.Add(btnTaoDon);
            DoubleBuffered = true;
            Name = "Trangchu";
            Text = "Trangchu";
            Load += Trangchu_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTraCuu;
        private Button btnTaoDon;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Button button2;
        private PictureBox pictureBox3;
        private ToolTip toolTip1;
    }
}