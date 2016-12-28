using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThreadingExamples
{
    public partial class FIFOExample : Form
    {
        private Fifo QueueManager;
        public FIFOExample()
        {
            InitializeComponent();
        }
      

        private void Btn_FIFO_Click(object sender, EventArgs e)
        {
            //Instantiate object an run dequeue Task
            QueueManager = new Fifo();
        }

        private void Btn_AddItems_Click(object sender, EventArgs e)
        {
            QueueManager.ErrorGenerator = 1;
               var numList=new List<int>();
            for (var i = 0; i < 10; i++)
            {
                numList.Add(i);
            }
            QueueManager.AddItems(numList);
        }

        private void Btn_GenException_Click(object sender, EventArgs e)
        {
            QueueManager.ErrorGenerator = 0;
            var numList = new List<int>();
            for (var i = 0; i < 10; i++)
            {
                numList.Add(i);
            }
            QueueManager.AddItems(numList);
        }
    }
}
