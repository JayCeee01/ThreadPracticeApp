using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ThreadPracticeApp
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }
        public void MyThread()
        {
            label1.Text = "-Thread Starts-";
            Console.WriteLine("-Thread Starts-");

            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));

            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));

            Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread1));

            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            threadB.Priority = ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            threadC.Priority = ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End of Thread-";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyThread();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
