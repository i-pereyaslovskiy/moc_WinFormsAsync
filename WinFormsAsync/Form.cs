namespace WinFormsAsync
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
        }
        private void Clear()
        {
            textBoxAsync.Text = "";
            lblStart.Text = "Start";
            lblEnd.Text = "End";
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            textBox1.Text = $"{DateTime.Now}\r\n";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void timerButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
            else
                timer.Start();
        }
        private string AppSleeping(int sleepingTime)
        {
            string str = "";
            str += $"Start: Thread ID: {Environment.CurrentManagedThreadId}   ";
            str += $"{DateTime.Now} waiting for {sleepingTime} ms\r\n";
            Thread.Sleep(sleepingTime);
            str += $"END: Thread ID: {Environment.CurrentManagedThreadId}   ";
            str += $"{DateTime.Now} waiting for {sleepingTime} ms\r\n";

            return str;
        }
        private void sleepButton_Click(object sender, EventArgs e)
        {
            lblStart.Text = DateTime.Now.ToLongTimeString();
            textBoxAsync.Text = $"Synchronously\r\nThread ID<{Environment.CurrentManagedThreadId}>\r\n{AppSleeping(5_000)}Thread ID<{Environment.CurrentManagedThreadId}>\r\n";
            lblEnd.Text = DateTime.Now.ToLongTimeString();
        }
        private async void SleepAsync_Click(object sender, EventArgs e)
        {
            Clear();
            lblStart.Text = DateTime.Now.ToLongTimeString();
            textBoxAsync.Text += $"Asynchronously\r\nThread ID<{Environment.CurrentManagedThreadId}>\r\n{await Task.Run(() => AppSleeping(5_000))}Thread ID<{Environment.CurrentManagedThreadId}>\r\n";
            lblEnd.Text = DateTime.Now.ToLongTimeString();

        }
        private async void SleepListAsync_Click(object sender, EventArgs e)
        {
            Clear();
            List<Task<string>> tasks = new List<Task<string>>() 
            { 
                Task.Run(() => AppSleeping(3_000)),
                Task.Run(() => AppSleeping(5_000)), 
                Task.Run(() => AppSleeping(9_000)), 
            };

            lblStart.Text = DateTime.Now.ToLongTimeString();
            var taskResults = await Task.WhenAll(tasks);
            lblEnd.Text = DateTime.Now.ToLongTimeString();

            foreach (var task in taskResults)
                textBoxAsync.Text += $"Asynchronously\r\nThread ID<{Environment.CurrentManagedThreadId}>\r\n{task}Thread ID<{Environment.CurrentManagedThreadId}>\r\n";
        }
    }
}
