using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThreadingExamples
{
    public partial class FifoExample : Form
    {
        private Fifo _queueManager;
        public FifoExample()
        {
            InitializeComponent();
        }
      

        private void Btn_FIFO_Click(object sender, EventArgs e)
        {
            //Instantiate object an run dequeue Task
            _queueManager = new Fifo();
        }

        private void Btn_AddItems_Click(object sender, EventArgs e)
        {
            _queueManager.ErrorGenerator = 1;
               var numList=new List<int>();
            for (var i = 0; i < 10; i++)
            {
                numList.Add(i);
            }
            _queueManager.AddItems(numList);
        }

        private void Btn_GenException_Click(object sender, EventArgs e)
        {
            _queueManager.ErrorGenerator = 0;
            var numList = new List<int>();
            for (var i = 0; i < 10; i++)
            {
                numList.Add(i);
            }
            _queueManager.AddItems(numList);
        }

        private void Btn_StopLoop_Click(object sender, EventArgs e)
        {
            _queueManager.StopLoop();
        }
    }
}
