namespace labVA4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[][][] rz;
        SLAY nw;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowSLAY_Click(object sender, EventArgs e)
        {
            dataGridViewRezult.Rows.Clear();
            dataGridViewRezult.Columns.Clear();
            listBoxRezult.Items.Clear();
            groupBoxPrew.Enabled = true;
            groupBoxPrew.Visible = true;
            if (radioButtonRandom.Checked && numericUpDownrandomMax.Value < numericUpDownRandomMin.Value)
            {
                MessageBox.Show("Максимум больше минимума", "Warning");
                return;
            }

            dataGridViewSLAYpreview.Rows.Clear();
            dataGridViewSLAYpreview.Columns.Clear();

            int sizeColumn = Convert.ToInt32(numericUpDownColumns.Value);
            for (int i = 0; i < sizeColumn; i++)
            {
                dataGridViewSLAYpreview.Columns.Add("ColumnX" + Convert.ToInt32(i + 1), "x" + Convert.ToInt32(i + 1));
                dataGridViewSLAYpreview.Columns[i].Width = 30;
            }
            dataGridViewSLAYpreview.Columns.Add("ColumnRezult", "Свободдные члены");

            int sizeRows = Convert.ToInt32(numericUpDownRows.Value);
            for (int i = 0; i < sizeRows; i++)
                dataGridViewSLAYpreview.Rows.Add();

            if (radioButtonRandom.Checked)
            {
                int max = Convert.ToInt32(numericUpDownrandomMax.Value);
                int min = Convert.ToInt32(numericUpDownRandomMin.Value);
                Random rnd = new Random();
                for (int i = 0; i < sizeRows; i++)
                    for (int j = 0; j < sizeColumn + 1; j++)
                        dataGridViewSLAYpreview.Rows[i].Cells[j].Value = rnd.Next(min, max);
                nw = new SLAY(dataGridViewSLAYpreview);
            }
            else
            {
                int max = Convert.ToInt32(numericUpDownrandomMax.Value);
                int min = Convert.ToInt32(numericUpDownRandomMin.Value);
                Random rnd = new Random();
                for (int i = 0; i < sizeRows; i++)
                    for (int j = 0; j < sizeColumn + 1; j++)
                        dataGridViewSLAYpreview.Rows[i].Cells[j].Value = 0;
                nw = new SLAY(dataGridViewSLAYpreview);
            }
            buttonFind.Enabled = true;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            listBoxRezult.Items.Clear();
            rz = nw.Find();
            if (rz == null) { return; }
            groupBoxPrew.Enabled = false;
            groupBoxPrew.Visible = false;
            if (rz[1][1][0] == double.NaN)
            {
                MessageBox.Show("Решение не найдено", "Warning");
                return;
            }
            for (int i = 0; i < rz.Length - 1; i++)
                listBoxRezult.Items.Add(i + 1);
            listBoxRezult.Items.Add("Результат");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewRezult.Rows.Clear();
            dataGridViewRezult.Columns.Clear();
            int sizeRows = rz.Length-1;
            for (int i = 0; i < sizeRows; i++)
            {
                dataGridViewRezult.Columns.Add("ColumnX" + Convert.ToInt32(i + 1), "x" + Convert.ToInt32(i + 1));
                dataGridViewRezult.Columns[i].Width = 40;
            }
            if (listBoxRezult.SelectedIndex== listBoxRezult.Items.Count - 1)
            {
                dataGridViewRezult.Rows.Add();
                for (int i = 0; i < rz[listBoxRezult.SelectedIndex][0].Length;i++)
                    dataGridViewRezult.Rows[0].Cells[i].Value = rz[listBoxRezult.SelectedIndex][0][i];

            }
            else
            {
                dataGridViewRezult.Columns.Add("ColumnRezult", "Свободдные члены");
                for (int i = 0; i < rz[0].Length; i++)
                    dataGridViewRezult.Rows.Add();
                for (int i = 0; i < rz[0].Length; i++)
                    for (int j = 0; j < rz[0][0].Length; j++)
                        dataGridViewRezult.Rows[i].Cells[j].Value = rz[listBoxRezult.SelectedIndex][i][j];
            }
        }
    }
}
