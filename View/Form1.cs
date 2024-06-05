using AbstractOverrideSample.Model;
using System.Windows.Forms;

namespace AbstractOverrideSample
{
    public partial class Form1 : Form
    {
        // ��l�� ToolTip ���
        private System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
        //private Abstract_SQL_Model SQL_Model = new Abstract_SQL_Model();
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(ButtonAbstract, "�غc Abstract Model");
            toolTip1.SetToolTip(ButtonDebug, "�غc Debug Model");
            toolTip1.SetToolTip(ButtonRelease, "�غc Release Model");
        }

        private void ButtonAbstract_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            MessageBox.Show("��ȤW���|�����갵 Abstract Model\r\n�]���H�~�ӧ����k�� Release Model ����", "�غc Abstract Model");
            var SQL_Model = new SQL_String_Release();
            richTextBox1.AppendText("Shipout condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_SHIPOUT_ShipoutList());
            richTextBox1.AppendText("\r\nExport condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_Export_List());
        }

        private void ButtonDebug_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            MessageBox.Show("override ���ձ���\r\n�]���P Abstract Model ���P", "�غc Debug Model");
            var SQL_Model = new SQL_String_Debug();
            richTextBox1.AppendText("Shipout condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_SHIPOUT_ShipoutList());
            richTextBox1.AppendText("\r\nExport condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_Export_List());
        }

        private void ButtonRelease_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            MessageBox.Show("�� override ����s��k\r\n�]���P Abstract Model �ۦP����", "�غc Release Model");
            var SQL_Model = new SQL_String_Release();
            richTextBox1.AppendText("Shipout condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_SHIPOUT_ShipoutList());
            richTextBox1.AppendText("\r\nExport condition:\r\n");
            richTextBox1.AppendText(SQL_Model.Get_Export_List());
        }
    }
}