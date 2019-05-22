using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Section6 {
    class WorkflowEngine {
        public void Run(WorkflowObject workflow) {
            foreach(IActivity activity in workflow.GetActivites()) {
                activity.Execute();
            }
        }
    }
}
