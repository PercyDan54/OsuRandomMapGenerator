using System;
using System.Windows.Forms;

namespace RandomMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int seed);
            seed = string.IsNullOrWhiteSpace(textBox1.Text) ? -1 : seed;
            var total = (int)length.Value;
            length.Value = total = total / 4 * 4;
            RandomMapGen.Gen(seed, (int)bpm.Value, total, (int)xGridNumericUpDown.Value, saveToOszCheckBox.Checked);
            MessageBox.Show(@"生成完成", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
