namespace Chuyen_Phat
{
    partial class DiaChi
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTiepTuc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Text = "DiaChi";
            this.BackColor = System.Drawing.Color.White;

            // Tabs
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Top;
            tabControl.Height = 50;
            tabControl.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            TabPage tabPage1 = new TabPage("Đi chợ hộ");
            TabPage tabPage2 = new TabPage("Hàng hóa");
            TabPage tabPage3 = new TabPage("Cước tự tính");

            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);
            tabControl.TabPages.Add(tabPage3);

            this.Controls.Add(tabControl);

            // Sender section
            GroupBox senderGroup = new GroupBox();
            senderGroup.Text = "Người gửi";
            senderGroup.Dock = DockStyle.Top;
            senderGroup.Height = 200;
            senderGroup.Padding = new Padding(10);
            senderGroup.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);

            Label senderPhoneLabel = new Label() { Text = "Số điện thoại", Top = 30, Left = 10, Width = 100 };
            TextBox senderPhoneTextBox = new TextBox() { Top = 50, Left = 10, Width = 300 };

            Label senderNameLabel = new Label() { Text = "Họ và tên", Top = 80, Left = 10, Width = 100 };
            TextBox senderNameTextBox = new TextBox() { Top = 100, Left = 10, Width = 300 };

            Label senderAddressLabel = new Label() { Text = "Địa chỉ", Top = 130, Left = 10, Width = 100 };
            TextBox senderAddressTextBox = new TextBox() { Top = 150, Left = 10, Width = 300 };

            senderGroup.Controls.Add(senderPhoneLabel);
            senderGroup.Controls.Add(senderPhoneTextBox);
            senderGroup.Controls.Add(senderNameLabel);
            senderGroup.Controls.Add(senderNameTextBox);
            senderGroup.Controls.Add(senderAddressLabel);
            senderGroup.Controls.Add(senderAddressTextBox);

            this.Controls.Add(senderGroup);

            // Receiver section
            GroupBox receiverGroup = new GroupBox();
            receiverGroup.Text = "Người nhận";
            receiverGroup.Dock = DockStyle.Top;
            receiverGroup.Height = 200;
            receiverGroup.Padding = new Padding(10);
            receiverGroup.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);

            Label receiverPhoneLabel = new Label() { Text = "Số điện thoại", Top = 30, Left = 10, Width = 100 };
            TextBox receiverPhoneTextBox = new TextBox() { Top = 50, Left = 10, Width = 300 };

            Label receiverNameLabel = new Label() { Text = "Họ và tên", Top = 80, Left = 10, Width = 100 };
            TextBox receiverNameTextBox = new TextBox() { Top = 100, Left = 10, Width = 300 };

            Label receiverAddressLabel = new Label() { Text = "Địa chỉ", Top = 130, Left = 10, Width = 100 };
            TextBox receiverAddressTextBox = new TextBox() { Top = 150, Left = 10, Width = 300 };

            receiverGroup.Controls.Add(receiverPhoneLabel);
            receiverGroup.Controls.Add(receiverPhoneTextBox);
            receiverGroup.Controls.Add(receiverNameLabel);
            receiverGroup.Controls.Add(receiverNameTextBox);
            receiverGroup.Controls.Add(receiverAddressLabel);
            receiverGroup.Controls.Add(receiverAddressTextBox);

            this.Controls.Add(receiverGroup);

            // Continue button
            btnTiepTuc = new Button();
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.Top = 500;
            btnTiepTuc.Left = 150;
            btnTiepTuc.Width = 100;
            btnTiepTuc.Height = 40;
            btnTiepTuc.BackColor = System.Drawing.Color.Red;
            btnTiepTuc.ForeColor = System.Drawing.Color.White;
            btnTiepTuc.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            btnTiepTuc.Click += new EventHandler(this.BtnTiepTuc_Click);

            this.Controls.Add(btnTiepTuc);
        }

        private void BtnTiepTuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tiếp tục được nhấn!");
        }

        #endregion
    }
}
