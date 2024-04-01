namespace WinFormsAsync
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timerButton = new Button();
            sleepButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            SleepAsync = new Button();
            textBoxAsync = new TextBox();
            buttonClear = new Button();
            lblStart = new Label();
            lblEnd = new Label();
            SleepListAsync = new Button();
            SuspendLayout();
            // 
            // timerButton
            // 
            timerButton.BackColor = Color.LightCoral;
            timerButton.Location = new Point(27, 440);
            timerButton.Name = "timerButton";
            timerButton.Size = new Size(163, 84);
            timerButton.TabIndex = 0;
            timerButton.Text = "Timer (Stop/Start)";
            timerButton.UseVisualStyleBackColor = false;
            timerButton.Click += timerButton_Click;
            // 
            // sleepButton
            // 
            sleepButton.BackColor = Color.LightGray;
            sleepButton.Location = new Point(492, 440);
            sleepButton.Name = "sleepButton";
            sleepButton.Size = new Size(141, 84);
            sleepButton.TabIndex = 1;
            sleepButton.Text = "Sleep";
            sleepButton.UseVisualStyleBackColor = false;
            sleepButton.Click += sleepButton_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(431, 232);
            textBox1.TabIndex = 2;
            // 
            // SleepAsync
            // 
            SleepAsync.BackColor = Color.Silver;
            SleepAsync.Location = new Point(658, 440);
            SleepAsync.Name = "SleepAsync";
            SleepAsync.Size = new Size(139, 84);
            SleepAsync.TabIndex = 3;
            SleepAsync.Text = "SleepAsync";
            SleepAsync.UseVisualStyleBackColor = false;
            SleepAsync.Click += SleepAsync_Click;
            // 
            // textBoxAsync
            // 
            textBoxAsync.Location = new Point(492, 31);
            textBoxAsync.Multiline = true;
            textBoxAsync.Name = "textBoxAsync";
            textBoxAsync.ScrollBars = ScrollBars.Vertical;
            textBoxAsync.Size = new Size(461, 232);
            textBoxAsync.TabIndex = 4;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(27, 283);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(926, 23);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(489, 5);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(31, 15);
            lblStart.TabIndex = 6;
            lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(723, 5);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(27, 15);
            lblEnd.TabIndex = 7;
            lblEnd.Text = "End";
            // 
            // SleepListAsync
            // 
            SleepListAsync.BackColor = Color.DarkGray;
            SleepListAsync.Location = new Point(816, 440);
            SleepListAsync.Name = "SleepListAsync";
            SleepListAsync.Size = new Size(137, 84);
            SleepListAsync.TabIndex = 8;
            SleepListAsync.Text = "SleepListAsync";
            SleepListAsync.UseVisualStyleBackColor = false;
            SleepListAsync.Click += SleepListAsync_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 556);
            Controls.Add(SleepListAsync);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(buttonClear);
            Controls.Add(textBoxAsync);
            Controls.Add(SleepAsync);
            Controls.Add(textBox1);
            Controls.Add(sleepButton);
            Controls.Add(timerButton);
            Name = "Form";
            Text = "AsyncInWinForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button timerButton;
        private Button sleepButton;
        private System.Windows.Forms.Timer timer;
        private TextBox textBox1;
        private Button SleepAsync;
        private TextBox textBoxAsync;
        private Button buttonClear;
        private Label lblStart;
        private Label lblEnd;
        private Button SleepListAsync;
    }
}
