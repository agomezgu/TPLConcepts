using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        /// <summary>
        /// Instantiate the FIFO object and Start the Deque Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_FIFO_Click(object sender, EventArgs e)
        {
            //Instantiate object an run dequeue Task
            _queueManager = new Fifo(true);
        }

        /// <summary>
        /// Add 10 items to Deque 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method Add 10 Items to queue , and set to 0  the ErrorGenerator propertie.
        /// Here you can check that Task continue executing when an exception occurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Here StopLoop method is called, the infinite task is stopped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_StopLoop_Click(object sender, EventArgs e)
        {
            _queueManager.StopLoop();
        }

        private void LinkLbl_SeeDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start("http://agomezgu.wixsite.com/soeasy");

        }

        /// <summary>
        /// Here you can click too much times and it will generate an asincronous action for each one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Btn_DequeWithAsincTask_Click(object sender, EventArgs e)
        {
            if(_queueManager==null)
                _queueManager= new Fifo(false);

            // This Number will generate a 10 seconds delay
            _queueManager.ProcessItem(10000);
        }
    }
}
