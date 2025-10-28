namespace Jiggy
{
    using System.Runtime.InteropServices;
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);

        private bool isActive = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numPixels.Value = 1;
        }
        private void ToggleMouseMovement()
        {
            isActive = !isActive;
            //MessageBox.Show($"isActive: {isActive}"); //debug

            if (isActive)
            {
                button1.BackColor = Color.LightGray;
                mouseTimer.Start();
            }
            else
            {
                button1.BackColor = SystemColors.Control;
                mouseTimer.Stop();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ToggleMouseMovement();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                ToggleMouseMovement();
                e.Handled = true;
            }
        }

        //Move the mouse n px and go back to the original position
        private void mouseTimer_Tick(object sender, EventArgs e)
        {
            Point currentPos;
            GetCursorPos(out currentPos);

            int movePx = (int)(numPixels?.Value ?? 1);

            SetCursorPos(currentPos.X + movePx, currentPos.Y);
            System.Threading.Thread.Sleep(10);
            SetCursorPos(currentPos.X, currentPos.Y);
        }
    }
}
