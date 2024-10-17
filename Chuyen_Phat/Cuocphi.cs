namespace Chuyen_Phat
{
    public partial class Cuocphi : Form
    {
        public Cuocphi()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            btnXacNhan.BackColor = Color.LightGreen;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(chkBaoHiem, "Bảo hiểm và khai giá: Đảm bảo hàng hóa được bảo hiểm trong quá trình vận chuyển.");
            toolTip1.SetToolTip(chkDongKiem, "Đồng kiểm: Kiểm tra nội dung hàng hóa khi giao nhận.");
        }
    }
}
