namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private Game game = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = game.Click(2, labelStep, labelWin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = game.Click(3, labelStep, labelWin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = game.Click(5, labelStep, labelWin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = game.Click(7, labelStep, labelWin);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = game.Click(11, labelStep, labelWin);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = game.Click(13, labelStep, labelWin);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = game.Click(17, labelStep, labelWin);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = game.Click(19, labelStep, labelWin);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = game.Click(23, labelStep, labelWin);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            game.clear();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            labelStep.Text = "Step:";
            labelWin.Text = "Win: ";
        }
    }
}
