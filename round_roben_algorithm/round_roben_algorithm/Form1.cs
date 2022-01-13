using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

//بسم الله الرحمن الرحيم 

namespace round_roben_algorithm
{
    public partial class Form1 : Form
    {
        // A simple class to make a process as an object that have name and burst time-------------------------
        class Process
        {
            public int burst_time;
            public string process_name;
            public Process(int time, string name)
            {
                burst_time = time;
                process_name = name;
            }
        }
        // Initialize the main variables,queue and arrays of the algorithm------------------------------------- 
        static int n = 4;
        public int[] burst_time = new int[n];        //burst time array
        Queue <Process> waiting = new Queue<Process> { };    //the main queue of the processes
        public int[] exit_time = new int[n];       //exit time array
        int[] wt = new int[n];
        int[] tat = new int[n];
        public float unit;
        int total_wt = 0, total_tat = 0;
        Process [] processes = new Process[n];

        public Form1()
        {
            InitializeComponent();
        }

        // The button code to fill the queue and the array of the burst time that we will take from the 4 text boxes------------
        private void button1_Click(object sender, EventArgs e)
        {


            processes[0] = new Process(Convert.ToInt32(p1.Text),"P1");
            processes[1] = new Process(Convert.ToInt32(p2.Text),"P2");
            processes[2] = new Process(Convert.ToInt32(p3.Text),"P3");
            processes[3] = new Process(Convert.ToInt32(p4.Text),"P4");


            for (int i = 0; i < n; i++)
            { 
                waiting_queue.Items.Add($"{processes[i].process_name} = {processes[i].burst_time}");
                burst_time[i] = processes[i].burst_time;
                waiting.Enqueue(processes[i]);
            }

            unit = 185/burst_time.Sum();    

            ctr = Convert.ToInt32(q.Text);

            animation_timer.Start();
            main_timer.Start();
        }

        // This code is for drawing rows and coulmns in the list view of the results----------------------------------
        private void Form1_Load(object sender, EventArgs )
        {
            results.View = View.Details;
            results.GridLines = true;
            results.Columns.Add("Processes", 70);
            results.Columns.Add("Burst Time", 70);
            results.Columns.Add("Waiting Time", 70);
            results.Columns.Add("Turn Around Time", 70);
        }
        private void cpu_TextChanged(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}

        Process current = null; // The pointer to help us in the loop that controls the main queue
        int seconds = 0;
        int ctr;  

        // This timer is the main timer of the program that we excuted the Round Robin algorithm on it----------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            main_timer.Interval = 1000;
            sec.Text = seconds.ToString();
            if (ctr == Convert.ToInt32(q.Text)  || (current!=null && current.burst_time == 0))
            {
                if(current != null)
                {
                    if (current.burst_time == 0)
                    {
                        exit_time[Convert.ToInt32(current.process_name[1].ToString())-1] = seconds;
                    }
                    else
                    {
                        waiting_queue.Items.Add(current.process_name + " = " + current.burst_time);
                        waiting.Enqueue(current);
                    }
                }
                if (waiting.Count > 0)
                {

                    current = waiting.Dequeue();
                    while (current.burst_time == 0)
                    {
                        exit_time[Convert.ToInt32(current.process_name[1].ToString()) - 1] = seconds;
                        current = waiting.Dequeue();
                        waiting_queue.Items.RemoveAt(0);
                    }
                    waiting_queue.Items.RemoveAt(0);
                    cpu.Text = current.process_name;
                }
                ctr = 0;
            }

            // The code that fill the loading bar
            Graphics load = this.CreateGraphics();
            load.FillRectangle(new SolidBrush(Color.Green), start_point_x, start_point_y, unit, chart_height);

            // Some counters
            seconds++;
            ctr++;
            check();
            current.burst_time--;

            unit += (185 / (burst_time[0] + burst_time[1] + burst_time[2] + burst_time[3])); //Loading bar counter
        }

        // A method that checks if processes = 0 or not to dequeue it from the queue
        void check()
        {
            bool flag = true;


            for (int i = 0; i < n; i++)
            {
                if (processes[i].burst_time != 0) flag = false;
            }

            if (flag)
            {
                main_timer.Stop();
                int[] processes = { 1, 2, 3, 4 };
                int n = processes.Length;

                int quantum = Convert.ToInt32(q.Text);
                findavgTime(processes, n, burst_time, quantum);
                MessageBox.Show("The CPU is idle"+"\n"+"Average waiting time = "+total_wt+"\n"+"Average Turn around time = "+total_tat);
            }
        }

        // A method to calculate the waiting time for each process--------------------------------------------
        public void findWaitingTime()
        {
            for (int i = 0; i < n; i++)
            {
                wt[i] = tat[i] - burst_time[i];
            }
        }
        // A method to calculate the turn around time -------------------------------------------------------
        public void findTurnAroundTime()
        {
            for (int i = 0; i < n; i++)
                tat[i] = exit_time[i];
        }
        private void label6_Click(object sender, EventArgs e) {}
        
         // The coordinates and the dimensions of the rectangle of loading bar--------------------------------- 

        int start_point_x = 388; int start_point_y = 275;
        int chart_width = 185; int chart_height = 29;

        // This method is for graphics and painting------------------------------------------------------------
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = this.CreateGraphics();
            Rectangle rectangle = new Rectangle(start_point_x, start_point_y, chart_width, chart_height);
            gfx.DrawRectangle(Pens.Black, rectangle);
        }

        // A method to calculate the average time,total waiting time and total turn around time--------------------
        public void findavgTime(int[] processes, int n,int[] bt, int quantum)
        {
            findTurnAroundTime();
            findWaitingTime();

            for (int i = 0; i < n; i++)
            {
                total_wt = total_wt + wt[i];
                total_tat = total_tat + tat[i];
                string [] row = {(i+1).ToString(),bt[i].ToString(),wt[i].ToString(),tat[i].ToString()}; 
                var ListViewItem = new ListViewItem(row);
                results.Items.Add(ListViewItem);
            }
        }
        private void p4_TextChanged(object sender, EventArgs e){}

        // This timer is for animation in the project (the four blue blocks)----------------------------------------
        private void animation_timer_Tick(object sender, EventArgs e)
        {
            animation_timer.Interval = 5;

            int new_x1 = anime1.Location.X;
            int new_x2 = anime2.Location.X;
            int new_x3 = anime3.Location.X;
            int new_x4 = anime4.Location.X;

            if (anime1.Location.X < 270) new_x1++;
            if (anime2.Location.X < 270) new_x2++;
            if (anime3.Location.X < 270) new_x3++;
            if (anime4.Location.X < 270) new_x4++;

            anime1.Location = new Point(new_x1,anime1.Location.Y);
            anime2.Location = new Point(new_x2,anime2.Location.Y);
            anime3.Location = new Point(new_x3,anime3.Location.Y);
            anime4.Location = new Point(new_x4,anime4.Location.Y); 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {}

    }
}
