using System;
using System.Windows.Forms;
using static RandomMap.RandomMapGenerator;

namespace RandomMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateDifficulty();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int seed);
            seed = string.IsNullOrWhiteSpace(textBox1.Text) ? -1 : seed;
            var total = (int)length.Value;
            length.Value = total = total / 4 * 4;
            Generate(seed, (int)bpm.Value, total, (int)xGridNumericUpDown.Value);
            MessageBox.Show(@"生成完成", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateDifficulty()
        {
            var beatLength = (double)(90000 / bpm.Value / 4);
            Ar = Math.Clamp(Math.Round((1200f - beatLength / 85 * 600) / 750 * 5 + 5, 2), 0, 10);
            Od = Math.Clamp(Math.Round((1200f - beatLength / 85 * 600) / 750 * 5 + 5, 2), 0, 10);
            arNumericUpDown.Value = (decimal)Ar;
            odNumericUpDown.Value = (decimal)Od;
        }

        private void bpm_ValueChanged(object sender, EventArgs e) => updateDifficulty();
    }
}
