using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicConcepts
{
    public partial class Examples : Form
    {
        private delegate void DoOperation(string par);
        private delegate string DoOperationWithReturn(string par);
        private delegate string DoOperationWithReturnAndTwoParameters(string par1 , string par2);

        public Examples()
        {
            InitializeComponent();
        }

        private void Btn_DelegateExamples_Click(object sender, EventArgs e)
        {
            //Instantiate delegate with named Methods
            DoOperation op = NamedVoidMethod;
            DoOperationWithReturn opReturn = NamedMethodWithStringReturn;

            //Invoke Delegate methods
            op("Required Par");
            var returnedValueFromDelegate = opReturn("Required Par");
            Console.WriteLine(returnedValueFromDelegate);

            //Instantiate with Anonymus method
            op = delegate(string par)
            {
                Console.WriteLine(par);
            };
            op("3-You wrote this in anonymus method oh yeahh!!!!");


            // Finally ..... Instantiate with lambda Instrucction
            // hey hey it's diferent to Lambda expression

            opReturn = par =>
            {
                Console.WriteLine("4-Call Lambda Instruction!!!!");
                return "Returned from delegate Method with lambda Instruction }:) ";
            };
            var returnedValueFromDelegateLambdaInst = opReturn("Execute Lambda String Method!!!!");
            Console.WriteLine(returnedValueFromDelegateLambdaInst);

        }

        private void NamedVoidMethod(string par)
        {
            Console.WriteLine("1- Call Void Method!!!!");
        }

        private string NamedMethodWithStringReturn(string par)
        {
            Console.WriteLine("2- Call String Method!!!!");
            return "Returned from delegate Method :) :-]...";
        }

        private void Btn_ActionsExample_Click(object sender, EventArgs e)
        {
            //Ptssss Ptssss this are Lambda Expression ... 
            Action<string> action = x=>MessageBox.Show(x);
            Action<string> action2 =y => Console.WriteLine(y);

            INeedActionToExecute(action,"Action 1 Executed");
            INeedActionToExecute(action2, "Action 2 Executed");
        }

        private void INeedActionToExecute(Action<string> actionToExecute  , string valueToWrite)
        {
            actionToExecute(valueToWrite);
        }

        private void Btn_FuncExample_Click(object sender, EventArgs e)
        {
            //Ptssss Ptssss this are Lambda Instruction ... 
            Func<int, string> func = (x) =>
            {
                MessageBox.Show(x.ToString());
                return "I show a Message Box --- Parameter Received is :"+x.ToString(); 
            };
            Func<int, string> func2 = (y) =>
            {
                Console.WriteLine(y.ToString());
                return "I write in Console --- Parameter Received is :" + y.ToString();
            };

            Console.WriteLine(INeedFunctionToExecute(func, 1000));
            Console.WriteLine(INeedFunctionToExecute(func2, 2000));
        }

        private string INeedFunctionToExecute(Func<int , string> functionToExecute, int inParameter)
        {
            return functionToExecute(inParameter);
        }

        private void Btn_LambdaExample_Click(object sender, EventArgs e)
        {
            const string msg = "Lambda Example ";

            DoOperation lambdaVoid = par => Console.WriteLine(par);

            DoOperationWithReturn lambdaReturnStringInstruction = par =>
            {
                return par;
            };
            DoOperationWithReturn lambdaReturnStringExpression = par => par;

            DoOperationWithReturnAndTwoParameters lambdaReturnStringInstructionTwoParameters = (par1, par2) =>
            {
                return par1 + par2;
            };

            lambdaVoid(msg+1);
           Console.WriteLine(lambdaReturnStringInstruction(msg + 2));
            Console.WriteLine(lambdaReturnStringExpression(msg + 3));
            Console.WriteLine(lambdaReturnStringInstructionTwoParameters(msg , 4.ToString()));

        }
    }
}
