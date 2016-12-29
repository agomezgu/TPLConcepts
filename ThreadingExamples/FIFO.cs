﻿#region Header

// /*------------------------------------------------------------
//   <copyright file ="FIFO.cs" company="DATA IFX">
//   </copyright>
//   <Summary>
//   Escriba una breve descripción
//   </Summary>
// ------------------------------------------------------------*/

#endregion

#region Dependencies

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

#endregion

namespace ThreadingExamples
{
    public class Fifo
    {
        private const int Delay = 500;
        private Task _infiniteTask;
        public int ErrorGenerator=1;
        private BlockingCollection<int> _items;
        /// <summary>
        /// 
        /// </summary>
        private readonly object _objLock;

        public Fifo()
        {
            _items = new BlockingCollection<int>();
            _objLock = new object();
            RunDeQueue();
        }

        public void AddItems(List<int> items )
        {
            items.ForEach(x=>this._items.Add(x)); 
        }

        public void StopLoop()
        {
            this._items.CompleteAdding();
        }

        private async void RunDeQueue()
        {
            if (this._infiniteTask != null && this._infiniteTask.Status == TaskStatus.Running) return;

            this._infiniteTask = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Start Infinite Loop");
                while (!_items.IsCompleted)
                {
                    
                    if (_items.Count == 0) continue;

                    Console.WriteLine("Items was found ... ");
                    var item = _items.Take();
                    ComplexOperation(item);
                }
                Console.WriteLine("End Infinite Loop");
            });
            try
            {
                await this._infiniteTask;
            }
            catch (Exception xx)
            {
                Console.WriteLine("Handled Exception -'{0}' , Task State \"{1}\" ", xx.Message, this._infiniteTask.Status);
                RunDeQueue();
                Console.WriteLine("Restart Infinite Loop , Task State \"{0}\" ", this._infiniteTask.Status);
            }
        }

        private void ComplexOperation(int time)
        {
            lock (_objLock)
            {
                Task.Delay(Delay);
                Console.WriteLine("Finish..." + time);
                
                //Raise Exception
                if (time == 5)
                    time = time/ ErrorGenerator;

            }
        }
    }
}