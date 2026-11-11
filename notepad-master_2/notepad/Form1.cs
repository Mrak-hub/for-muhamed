namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ôàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ñîõğîToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void ôîğìàòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void îòêğûòüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Âñå ôàéëû (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void ñîõğîíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void ïå÷ÿòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void ñîõğàíèòüÊàêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Âñå ôàéëû (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void îòìåíàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }

        private void âûğåçàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void êîïèğîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void âñòàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox1.Paste();
            }
        }



        private void âèäToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öâåòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void ìàøòàáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 0.3f;
        }

        private void øğèôòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionFont = fontDialog.Font;
                richTextBox1.DeselectAll();
            }
        }

        private void ïîñìîòğåòüÑïğàâêóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winver.exe");
        }

        private void âûğåçàòüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void âñòàâèòüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void îòìåíàToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }

}
