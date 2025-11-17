using System;
using System.Globalization;
using System.Windows.Forms;

namespace DiemDanhTool
{
    public partial class MainForm : Form
    {
        private const int COL_DAY1 = 3;
        private const int ROW_VAO = 4;
        private const int ROW_RA = 5;
        private const int ROW_GIO = 6;

        private GoogleSheetHelper helper;

        // ⚠️ THAY LINK NÀY = LINK EXEC CỦA BẠN
        private string webAppUrl = ""https://script.google.com/macros/s/AKfycby1am3jIyPi09zln63YkyWDlYITu4Tg8BKTYR76Q9b811Fyx4G1rf3X1BxY7SCbTXtOIg/exec"";

        public MainForm()
        {
            InitializeComponent();
            helper = new GoogleSheetHelper(webAppUrl);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var list = await helper.GetEmployeesAsync();
            comboName.Items.AddRange(list);
        }

        private int TodayCol() => COL_DAY1 + (DateTime.Now.Day - 1);

        private async void btnCheckIn_Click(object sender, EventArgs e)
        {
            await helper.PostCellAsync(ROW_VAO, TodayCol(), DateTime.Now.ToString(""HH:mm:ss""));
            MessageBox.Show(""Đã ghi giờ vào"");
        }

        private async void btnCheckOut_Click(object sender, EventArgs e)
        {
            await helper.PostCellAsync(ROW_RA, TodayCol(), DateTime.Now.ToString(""HH:mm:ss""));
            MessageBox.Show(""Đã ghi giờ ra"");
        }

        private async void btnMarkProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""Sắp hoàn thiện module đánh dấu dự án"");
        }
    }
}
