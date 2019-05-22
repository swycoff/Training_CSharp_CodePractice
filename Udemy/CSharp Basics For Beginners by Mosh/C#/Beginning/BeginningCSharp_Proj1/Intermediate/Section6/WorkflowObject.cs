using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Section6 {
    class WorkflowObject {
        private readonly List<IActivity> activityList;
     
        public WorkflowObject() {
            activityList = new List<IActivity>();
        }
        public void AddActivityToWorkFlow(IActivity activity) {
            activityList.Add(activity);
        }
        public void RemoveActivityFromWorkFlow(IActivity activity) {
            activityList.Remove(activity);
        }
        //This makes sure your returning a read only version of your internal list - you don't want to return a reference that they can change the list with.
        public IEnumerable<IActivity> GetActivites() {
            return activityList;
        }

    }
}
