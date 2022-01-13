namespace round_roben_algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p3 = new System.Windows.Forms.TextBox();
            this.p4 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.waiting_queue = new System.Windows.Forms.CheckedListBox();
            this.cpu = new System.Windows.Forms.TextBox();
            this.sec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.anime1 = new System.Windows.Forms.TextBox();
            this.anime4 = new System.Windows.Forms.TextBox();
            this.anime3 = new System.Windows.Forms.TextBox();
            this.anime2 = new System.Windows.Forms.TextBox();
            this.animation_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.Info;
            this.p1.Location = new System.Drawing.Point(93, 56);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 24);
            this.p1.TabIndex = 1;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.SystemColors.Info;
            this.p3.Location = new System.Drawing.Point(93, 147);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(100, 24);
            this.p3.TabIndex = 3;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.SystemColors.Info;
            this.p4.Location = new System.Drawing.Point(93, 193);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(100, 24);
            this.p4.TabIndex = 4;
            this.p4.TextChanged += new System.EventHandler(this.p4_TextChanged);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.SystemColors.Info;
            this.p2.Location = new System.Drawing.Point(93, 101);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 24);
            this.p2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "P3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "P4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "P2";
            // 
            // q
            // 
            this.q.BackColor = System.Drawing.SystemColors.Info;
            this.q.Location = new System.Drawing.Point(93, 263);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(100, 24);
            this.q.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantum";
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.SystemColors.Info;
            this.results.ForeColor = System.Drawing.SystemColors.InfoText;
            this.results.HideSelection = false;
            this.results.Location = new System.Drawing.Point(35, 337);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(415, 213);
            this.results.TabIndex = 12;
            this.results.UseCompatibleStateImageBehavior = false;
            this.results.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Results";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(523, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 41);
            this.label8.TabIndex = 15;
            this.label8.Text = "CPU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Location = new System.Drawing.Point(463, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Round Robin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_timer
            // 
            this.main_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Waiting Queue";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // waiting_queue
            // 
            this.waiting_queue.BackColor = System.Drawing.SystemColors.Info;
            this.waiting_queue.Enabled = false;
            this.waiting_queue.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiting_queue.FormattingEnabled = true;
            this.waiting_queue.Location = new System.Drawing.Point(330, 56);
            this.waiting_queue.Name = "waiting_queue";
            this.waiting_queue.Size = new System.Drawing.Size(120, 184);
            this.waiting_queue.TabIndex = 20;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.SystemColors.Info;
            this.cpu.Enabled = false;
            this.cpu.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpu.Location = new System.Drawing.Point(530, 108);
            this.cpu.Multiline = true;
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(60, 64);
            this.cpu.TabIndex = 21;
            // 
            // sec
            // 
            this.sec.BackColor = System.Drawing.SystemColors.Info;
            this.sec.Enabled = false;
            this.sec.Location = new System.Drawing.Point(330, 263);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(33, 24);
            this.sec.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Seconds";
            // 
            // anime1
            // 
            this.anime1.BackColor = System.Drawing.Color.RoyalBlue;
            this.anime1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anime1.Enabled = false;
            this.anime1.Location = new System.Drawing.Point(199, 56);
            this.anime1.Name = "anime1";
            this.anime1.Size = new System.Drawing.Size(14, 24);
            this.anime1.TabIndex = 24;
            // 
            // anime4
            // 
            this.anime4.BackColor = System.Drawing.Color.RoyalBlue;
            this.anime4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anime4.Enabled = false;
            this.anime4.Location = new System.Drawing.Point(199, 193);
            this.anime4.Name = "anime4";
            this.anime4.Size = new System.Drawing.Size(14, 24);
            this.anime4.TabIndex = 25;
            // 
            // anime3
            // 
            this.anime3.BackColor = System.Drawing.Color.RoyalBlue;
            this.anime3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anime3.Enabled = false;
            this.anime3.Location = new System.Drawing.Point(199, 147);
            this.anime3.Name = "anime3";
            this.anime3.Size = new System.Drawing.Size(14, 24);
            this.anime3.TabIndex = 26;
            // 
            // anime2
            // 
            this.anime2.BackColor = System.Drawing.Color.RoyalBlue;
            this.anime2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anime2.Enabled = false;
            this.anime2.Location = new System.Drawing.Point(199, 101);
            this.anime2.Name = "anime2";
            this.anime2.Size = new System.Drawing.Size(14, 24);
            this.anime2.TabIndex = 27;
            // 
            // animation_timer
            // 
            this.animation_timer.Tick += new System.EventHandler(this.animation_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(671, 571);
            this.Controls.Add(this.anime2);
            this.Controls.Add(this.anime3);
            this.Controls.Add(this.anime4);
            this.Controls.Add(this.anime1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.waiting_queue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.q);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p1);
            this.Name = "Form1";
            this.Text = "Round Robin Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p3;
        private System.Windows.Forms.TextBox p4;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox q;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView results;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox waiting_queue;
        private System.Windows.Forms.TextBox cpu;
        private System.Windows.Forms.TextBox sec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox anime1;
        private System.Windows.Forms.TextBox anime4;
        private System.Windows.Forms.TextBox anime3;
        private System.Windows.Forms.TextBox anime2;
        private System.Windows.Forms.Timer animation_timer;
    }
}

