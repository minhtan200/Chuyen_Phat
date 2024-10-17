namespace Chuyen_Phat
{
    partial class TraCuu
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox searchBar;
        private Button searchButton;
        private PictureBox pictureBox;

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
            this.Text = "TraCuu";
            this.BackColor = System.Drawing.Color.White;

            // Header
            Label headerLabel = new Label();
            headerLabel.Text = "Mã phiếu gửi hành trình đơn hàng";
            headerLabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            headerLabel.ForeColor = System.Drawing.Color.White;
            headerLabel.BackColor = System.Drawing.Color.Red;
            headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            headerLabel.Dock = DockStyle.Top;
            headerLabel.Height = 50;

            Label subHeaderLabel = new Label();
            subHeaderLabel.Text = "(Vd: nhập bill không cách thước đầu phẩy giữa các bill)";
            subHeaderLabel.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular);
            subHeaderLabel.ForeColor = System.Drawing.Color.White;
            subHeaderLabel.BackColor = System.Drawing.Color.Red;
            subHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            subHeaderLabel.Dock = DockStyle.Top;
            subHeaderLabel.Height = 20;

            this.Controls.Add(subHeaderLabel);
            this.Controls.Add(headerLabel);

            // Search bar
            searchBar = new TextBox();
            searchBar.PlaceholderText = "Tìm kiếm bằng cách nhập mã phiếu gửi";
            searchBar.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            searchBar.Top = 80;
            searchBar.Left = 20;
            searchBar.Width = 300;

            searchButton = new Button();
            searchButton.Text = "TRA CỨU";
            searchButton.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            searchButton.BackColor = System.Drawing.Color.Red;
            searchButton.ForeColor = System.Drawing.Color.White;
            searchButton.Top = 80;
            searchButton.Left = 330;
            searchButton.Width = 50;

            this.Controls.Add(searchBar);
            this.Controls.Add(searchButton);

            // Image
            pictureBox = new PictureBox();
            pictureBox.ImageLocation = "path_to_your_image.jpg"; // Đường dẫn đến hình ảnh của bạn
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Top = 150;
            pictureBox.Left = 50;
            pictureBox.Width = 300;
            pictureBox.Height = 200;

            this.Controls.Add(pictureBox);
        }

        #endregion
    }
}
