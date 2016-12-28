#region Header

// /*------------------------------------------------------------
//   <copyright file ="Form1.cs" company="Gnom">
//   </copyright>
//   <Summary>
//   Task Parallel Library Basic Examples 
//   </Summary>
// ------------------------------------------------------------*/

#endregion

#region Dependencies

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace ThreadingExamples
{
    /// <summary>
    /// See documentation on Blog
    /// </summary>
    public partial class TPLBasics : Form
    {
        public TPLBasics()
        {
            InitializeComponent();
        }

        #region EventHandlers
        
        private void Btn_Example1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Begin Execution");

            //Async Run
            var task = this.RunLongTask("1");
            var task2 = this.RunLongTask("2");
            var task3 = this.RunLongTask("3");

            Console.WriteLine("End Execution!!!");
        }
        private void Btn_Example2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Begin Execution");
            var a = RunLongTaskWithFactory("1");
            var b = RunLongTaskWithFactory("2");
            var c = RunLongTaskWithFactory("3");
            Console.WriteLine("End Execution!!!");
        }
        private void Btn_Example3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Begin Execution");
            var t1 = RunLongTaskWithUnhandledError("1");
            Console.WriteLine("End Execution!!!");

            foreach (var exception in t1.Exception.InnerExceptions)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private async void Btn_Example4_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Begin Execution");
                await RunLongTaskWithUnhandledError("1");
                Console.WriteLine("End Execution!!!");
            }
            catch (Exception xx)
            {
                Console.WriteLine(xx.Message);
            }
        }
        private void Btn_Example5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Begin Execution");
            var t1 = RunLongTaskWithUnhandledErrorWithDelay("1");
            Console.WriteLine("End Execution!!!");

            //Here generate an exception, t1 is executing and t1.Exception is null, you must 
            //await 5 seconds after get an exception from Task
            foreach (var exception in t1.Exception.InnerExceptions)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private void Btn_Example6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Begin Execution");
            var a = RunLongTaskWithHandledError("1",2000);
            var b = RunLongTaskWithHandledError("2", 4000);
            var c = RunLongTaskWithHandledError("3", 6000);
            Console.WriteLine("End Execution!!!");
        }

        #endregion

        #region AsynMethodExamples
        private async Task RunLongTask(string NameThread)
        {
            
            Console.WriteLine(Thread.CurrentContext.ContextID);
            
            for (var i = 0; i < 4; i++)
            {
                await Task.Delay(5000);
                Console.WriteLine("Executing Method..." + NameThread);
            }
          
        }
        private async Task RunLongTaskWithUnhandledError(string NameThread)
        {
            
            Console.WriteLine("Executing Method");
            //Asyn Execution
            await Task.Delay(250);
            var a = 0;
            var b = 1;

            //Raise error
            var c = b/a;

            for (var i = 0; i < 4; i++)
            {
                
                Console.WriteLine("Executing Method..." + NameThread);
            }
        }
        private async Task RunLongTaskWithHandledError(string NameThread, int delay)
        {
            try
            {
                Console.WriteLine(Thread.CurrentContext.ContextID);
                Console.WriteLine("Begin execute Method");
                //"Await" is required for async method execution if you forget it  this method run Synchronously
                await Task.Delay(delay);
                var a = 0;
                var b = 1;
                //Raise error
                var c = b/a;

                for (var i = 0; i < 4; i++)
                {
                    
                    Console.WriteLine("Executing Method..." + NameThread);
                }
            }
            catch (Exception xx)
            {
                Console.WriteLine("Exception generated in task..." + xx.Message);
            }
        }
        private async Task RunLongTaskWithUnhandledErrorWithDelay(string NameThread)
        {
            Console.WriteLine(Thread.CurrentContext.ContextID);
            Console.WriteLine("Executing Method");

            await Task.Delay(5000);

            var a = 0;
            var b = 1;
            //Raise error
            var c = b / a;

            for (var i = 0; i < 4; i++)
            {

                Console.WriteLine("Executing..." + NameThread);
            }
        }
        private async Task RunLongTaskWithFactory(string NameThread)
        {
            await Task.Factory.StartNew(() =>
            {
                Console.WriteLine(Thread.CurrentContext.ContextID);
                for (var i = 0; i < 4; i++)
                {
                    Task.Delay(5000);
                    Console.WriteLine("Executing..." + NameThread);
                }
            });
        }

        #endregion

        
    }
}