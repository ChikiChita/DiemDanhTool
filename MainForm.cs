using System;
using System.Windows.Forms;
using System.Globalization;

namespace DiemDanhTool
{
    public partial class MainForm : Form
    {
        private const int COL_DAY1 = 3;
        private const int ROW_VAO = 4;
        private const int ROW_RA = 5;
        private const int ROW_GIO = 6;

        // 🔥 Link Web App của bạn
        private string webAppUrl = "https://script.google.com/macros/s/AKfycby1am3jIyPi09zln63YkyWDlYITu4Tg8BKTYR76Q9b811Fyx4G1rf3X1BxY7SCbTXtOIg/exec";

        private GoogleSheetHelper helper;

        public MainForm()
        {
            InitializeComponent();
            helper = new GoogleSheetHelper(webAppUrl);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var list = await helper.GetEmployeesAsync();
                comboName.Items.Clear();
                comboName.Items.AddRange(list);
                if (comboName.Items.Count > 0)
                    comboName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên:\n" + ex.Message);
            }
        }

        private int TodayCol()
        {
            return COL_DAY1 + (DateTime.Now.Day - 1);
        }

        private async void btnCheckIn_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            await helper.PostCellAsync(ROW_VAO, TodayCol(), time);
            MessageBox.Show("Đã ghi giờ vào");
        }

        private async void btnCheckOut_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            await helper.PostCellAsync(ROW_RA, TodayCol(), time);
            MessageBox.Show("Đã ghi giờ ra");
        }

        private void btnMarkProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đánh dấu dự án đang chuẩn bị hoàn thiện.");
        }
    }
}
