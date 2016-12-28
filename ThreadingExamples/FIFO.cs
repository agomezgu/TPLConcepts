#region Header

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
        private Task _infinieTask;
        public int ErrorGenerator=1;
        private BlockingCollection<int> _items;
        private object _objLock;

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

        private async void RunDeQueue()
        {
            if (this._infinieTask != null && this._infinieTask.Status == TaskStatus.Running) return;

            this._infinieTask = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Start Infinite Loop");
                while (!_items.IsCompleted)
                {
                    
                    if (_items.Count == 0) continue;

                    Console.WriteLine("Items was found ... ");
                    var item = _items.Take();
                    ComplexOperation(item);
                }
            });
            try
            {
                await this._infinieTask;
            }
            catch (Exception xx)
            {
                Console.WriteLine("Handled Exception -'{0}' , Task State \"{1}\" ", xx.Message, this._infinieTask.Status);
                RunDeQueue();
                Console.WriteLine("Restart Infinite Loop , Task State \"{0}\" ", this._infinieTask.Status);
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