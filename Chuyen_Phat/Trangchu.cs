using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chuyen_Phat
{
    public partial class Trangchu : Form
    {
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        public Trangchu()
        {

            InitializeComponent();

            // Cấu hình các thuộc tính cho Tooltip
            toolTip.AutoPopDelay = 5000;  // Tooltip sẽ biến mất sau 5 giây
            toolTip.InitialDelay = 500;   // Tooltip xuất hiện sau 0.5 giây khi hover
            toolTip.ReshowDelay = 500;    // Thời gian hiển thị lại Tooltip
            toolTip.BackColor = Color.LightYellow;  // Màu nền Tooltip
            toolTip.ForeColor = Color.Black;        // Màu chữ Tooltip
            toolTip.ShowAlways = true;   // Tooltip sẽ luôn hiển thị ngay cả khi form không được focus
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            // Đặt Tooltip cho các nút khi Form được tải
            toolTip.SetToolTip(button2, "Đăng nhập để quản lý tài khoản của bạn");
            toolTip.SetToolTip(btnTaoDon, "Tạo đơn hàng mới nhanh chóng");
            toolTip.SetToolTip(btnTraCuu, "Tra cứu trạng thái của các đơn hàng đã tạo");

            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đổi màu nút sang màu xanh nhạt
            btnTaoDon.BackColor = Color.LightBlue;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnTraCuu.BackColor = Color.LightBlue;
            btnTraCuu.Font = new Font(btnTraCuu.Font.FontFamily, btnTraCuu.Font.Size * 1.05f, FontStyle.Bold);
            contextMenuStrip1.Show(btnTraCuu, new Point(0, btnTraCuu.Height));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }
    }
}
