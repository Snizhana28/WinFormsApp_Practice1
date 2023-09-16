namespace WinFormsApp_Practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btYes_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ми не сумнівались, що ви так думаєте!");
        }

        private void btNo_Click_MouseMove(object sender, MouseEventArgs e)
        {
            btNo_Click.Top -= e.Y;
            btNo_Click.Left += e.X;
            if (btNo_Click.Top < -10 || btNo_Click.Top > 100)
                btNo_Click.Top = 60;
            if (btNo_Click.Left < -80 || btNo_Click.Left > 250)
                btNo_Click.Left = 120;
        }

        private void dateTimePicker1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = "Вибрана дата: " + dateTimePicker1.Value.ToString("dd.MM.yyyy");
        }
    }
}