using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate {
    class MyStack_List {
        private readonly List<object> myStackList = new List<object>(); //use read only when you don't want to accidentally reinitialize this list anywhere else in this class.

        public MyStack_List() {
        }

        public void Push(object obj) {
            if(obj == null) {
                throw new InvalidOperationException();                
            } else {
                myStackList.Add(obj);
            }
        }
        public object Pop() {
            if(myStackList.Count > 0) {
                int topElement = myStackList.Count - 1;
                object temp = myStackList[topElement];
                myStackList.RemoveAt(topElement);
                return temp;
            } else {
                throw new InvalidOperationException();
            }
            
        }
        public void Clear() {
            myStackList.Clear();
        }
    }
}
