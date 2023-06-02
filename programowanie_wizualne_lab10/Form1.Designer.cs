namespace programowanie_wizualne_lab10
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            buttonPlay = new Button();
            buttonPause = new Button();
            buttonStop = new Button();
            labelTime = new Label();
            buttonMinus = new Button();
            buttonPlus = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 25);
            listView1.Name = "listView1";
            listView1.Size = new Size(171, 377);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonPlay
            // 
            buttonPlay.BackgroundImage = (Image)resources.GetObject("buttonPlay.BackgroundImage");
            buttonPlay.BackgroundImageLayout = ImageLayout.Center;
            buttonPlay.Location = new Point(321, 219);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(74, 54);
            buttonPlay.TabIndex = 1;
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonPause
            // 
            buttonPause.BackgroundImage = (Image)resources.GetObject("buttonPause.BackgroundImage");
            buttonPause.BackgroundImageLayout = ImageLayout.Center;
            buttonPause.Location = new Point(438, 219);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(74, 54);
            buttonPause.TabIndex = 2;
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonStop
            // 
            buttonStop.BackgroundImage = (Image)resources.GetObject("buttonStop.BackgroundImage");
            buttonStop.BackgroundImageLayout = ImageLayout.Center;
            buttonStop.Location = new Point(551, 219);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(74, 54);
            buttonStop.TabIndex = 3;
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.Location = new Point(392, 129);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(71, 30);
            labelTime.TabIndex = 4;
            labelTime.Text = "00:00";
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinus.Location = new Point(129, 409);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(33, 29);
            buttonMinus.TabIndex = 5;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlus.Location = new Point(52, 409);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(33, 29);
            buttonPlus.TabIndex = 6;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(321, 295);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(304, 29);
            progressBar1.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(498, 129);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 8;
            label1.Text = "00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(469, 129);
            label2.Name = "label2";
            label2.Size = new Size(23, 30);
            label2.TabIndex = 9;
            label2.Text = "/";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(labelTime);
            Controls.Add(buttonStop);
            Controls.Add(buttonPause);
            Controls.Add(buttonPlay);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button buttonPlay;
        private Button buttonPause;
        private Button buttonStop;
        private Label labelTime;
        private Button buttonMinus;
        private Button buttonPlus;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}