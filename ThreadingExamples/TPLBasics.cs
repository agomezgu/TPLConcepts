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
using System.Diagnostics;
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

        /// <summary>
        /// Here an asynchronous method is executed, without any waiting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Example1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Begin Execution");

            //Async Run
            //You can monitor task state in this variables.
            var task = this.RunLongTask("1");
            var task2 = this.RunLongTask("2");
            var task3 = this.RunLongTask("3");

            Console.WriteLine("End Execution!!!");
        }
        /// <summary>
        /// Here an asynchronous method is executed, without any waiting . But task is created and started using a factory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Example2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Begin Execution");
            var a = RunLongTaskWithFactory("1");
            var b = RunLongTaskWithFactory("2");
            var c = RunLongTaskWithFactory("3");
            Console.WriteLine("End Execution!!!");
        }
        /// <summary>
        /// Here you execute async task , and raise an error in task action.
        /// when you generate an exception in a task , all exceptions are added in Exception.InnerException propertie
        /// and you cant iterate it .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Example3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Begin Execution");
            var t1 = RunLongTaskWithUnhandledError("1");
            Console.WriteLine("End Execution!!!");

            //If at this moment there isn't exceptions , you will generate a nullreferenceexception
            foreach (var exception in t1.Exception.InnerExceptions)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Here you execute an async method as sync .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Btn_Example4_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Begin Execution");
                await RunLongTaskWithUnhandledError("1");

                //This line  is never executed, 
                Console.WriteLine("End Execution!!!");
            }
            catch (Exception xx)
            {
                //Here capture async method exception, it is because we use "await"
                Console.WriteLine(xx.Message);
            }
        }
        /// <summary>
        /// Here you execute async task and try to get exception, but at the moment that you verify the Task object, 
        /// there is'nt exceptions generated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Here you execute async task but all the exceptions was handled in the async methods.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Example6_Click(object sender, EventArgs e)
        {
            //No exceptions were thrown here 
            Console.WriteLine("Begin Execution");
            var a = RunLongTaskWithHandledError("1",0);
            var b = RunLongTaskWithHandledError("2", 0);
            var c = RunLongTaskWithHandledError("3", 0);
            Console.WriteLine("End Execution!!!");

            Console.WriteLine("All Task was successfully executed ... State Task a '{0},State Task b '{1}',State Task c '{2}", a.Status , b.Status,c.Status);
        }

        #endregion

        #region AsynMethodExamples
        /// <summary>
        /// Execute a Task, it takes 20 seconds
        /// </summary>
        /// <param name="NameThread"></param>
        /// <returns></returns>
        private async Task RunLongTask(string NameThread)
        {
            
            for (var i = 0; i < 4; i++)
            {
                await Task.Delay(5000);
                Console.WriteLine("Executing Method..." + NameThread);
            }

            Console.WriteLine("End Async Method..." + NameThread);
        }

        /// <summary>
        /// Here you execute a task and generate unhandled exception
        /// </summary>
        /// <param name="NameThread"></param>
        /// <returns></returns>
        private async Task RunLongTaskWithUnhandledError(string NameThread)
        {
            await Task.Delay(0);
            Console.WriteLine("Executing Method");
            //Asyn Execution
            var a = 0;
            var b = 1;

            //Raise error
            var c = b/a;

            for (var i = 0; i < 4; i++)
            {
                
                Console.WriteLine("Executing Method..." + NameThread);
            }
        }

        /// <summary>
        /// Here you run a task and use Try/Catch Block .. The exception never reach the button method
        /// </summary>
        /// <param name="NameThread"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Here you run a task and generate a unhandled exception after 5 seconds 
        /// </summary>
        /// <param name="NameThread"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Here you run a Task generated with Task.Factory.StartNew instruction
        /// </summary>
        /// <param name="NameThread"></param>
        /// <returns></returns>
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
        
        #region others
        private void LinkLbl_SeeDocumentationClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://agomezgu.wixsite.com/soeasy");
        }
        #endregion
    }
}