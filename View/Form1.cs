using AbstractOverrideSample.Model;
using System.Windows.Forms;

namespace AbstractOverrideSample
{
    public partial class Form1 : Form
    {
        // 初始化 ToolTip 控制項
        private System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
        //private Abstract_SQL_Model SQL_Model = new Abstract_SQL_Model();
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(ButtonAbstract, "建構 Abstract Model");
            toolTip1.SetToolTip(ButtonDebug, "建構 Debug Model");
            toolTip1.SetToolTip(ButtonRelease, "建構 Release Model");
        }

        private void ButtonAbstract_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            MessageBox.Show("實務上不會直接實做 Abstract Model\r\n因此以繼承完整方法的 Release Model 為例", "建構 Abstract Model");
            var SQL_Model = new SQL_String_Release();
            richTextBox1.AppendText("Shipout condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_SHIPOUT_ShipoutList());
            richTextBox1.AppendText("\r\nExport condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_Export_List());
        }

        private void ButtonDebug_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            MessageBox.Show("override 測試條件\r\n因此與 Abstract Model 不同", "建構 Debug Model");
            var SQL_Model = new SQL_String_Debug();
            richTextBox1.AppendText("Shipout condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_SHIPOUT_ShipoutList());
            richTextBox1.AppendText("\r\nExport condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_Export_List());
        }

        private void ButtonRelease_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            MessageBox.Show("未 override 任何新方法\r\n因此與 Abstract Model 相同條件", "建構 Release Model");
            var SQL_Model = new SQL_String_Release();
            richTextBox1.AppendText("Shipout condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_SHIPOUT_ShipoutList());
            richTextBox1.AppendText("\r\nExport condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_Export_List());
        }
    }
}