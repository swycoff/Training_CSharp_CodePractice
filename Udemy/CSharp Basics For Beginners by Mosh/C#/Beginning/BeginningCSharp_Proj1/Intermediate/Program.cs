using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intermediate.Section5;
using Intermediate.Section6;
using System.Threading;
using System.Diagnostics; // allows us to write to the output window using Debug.WriteLine()

namespace Intermediate {
    class Program {
        static void Main(string[] args) {
            //StopWatch sw = new StopWatch();
            //for(var i=0; i<2; i++) {
            //    sw.Start();
            //    Thread.Sleep(1000);
            //    Debug.WriteLine("Duration: " + sw.Stop());
            //    Debug.WriteLine("Press enter to run the stopwatch one more time.");
            //    Console.ReadLine();
            //}

            //Post p = new Post("title here", "description here");
            //int voteCount = p.UpVote();
            //voteCount = p.UpVote();
            //voteCount = p.DownVote();

            //MyStack_List stack = new MyStack_List();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //Console.WriteLine(stack.Pop()); // take out 4
            //Console.WriteLine(stack.Pop()); // take out 3

            //stack.Push(5);
            //stack.Push(6);
            //stack.Push(7);

            //Console.WriteLine(stack.Pop()); // Takes out 7

            ////should have 1,2,5,6

            //stack.Clear();

            ////POP V2
            //var ini = 0;
            //var max = 5;
            ////Pushes the numbers 0 to 5
            //for(int i = ini; i<=max; i++) {
            //    stack.Push(i);
            //    Debug.WriteLine("Pushed: {0}", i);
            //}
            ////Pops all items in the list
            //for (int i = ini; i <= max; i++) {
            //    var itemPopped = stack.Pop();
            //    Debug.WriteLine("Popped: {0}", itemPopped);
            //}

            //section 5

            //SqlConnection sqlConnection = new SqlConnection("my SQL connection string.");
            //OracleConnection oracleConnection = new OracleConnection("my Oracle connection string.");

            //DbCommand dbCommand = new DbCommand(sqlConnection, "instruction for db");
            //dbCommand.Open();
            //dbCommand.Run();
            //dbCommand.Close();

            WorkflowObject workFlowObject = new WorkflowObject();
            workFlowObject.AddActivityToWorkFlow(new Activity_1());
            workFlowObject.AddActivityToWorkFlow(new Activity_2());
            workFlowObject.AddActivityToWorkFlow(new Activity_3());

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workFlowObject);

        }
    }
}
