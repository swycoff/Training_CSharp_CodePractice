using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate {
    public class MyStack_Array {
        //Stores a list of elements (objects) in the Last in First Out fashion (LIFO)
        static readonly int max = 1000; // max of 1000 objects
        private int top; // Used to keep track of the top of the stack
        private object[] stackList;

        #region Constructor
        public MyStack_Array() {
            stackList = new object[max];
            top = -1; // The first element will be top + 1 which will be element 0 .
        }
        #endregion
        /// <summary>
        /// Stores the given object on top of the stack.
        /// Remember that any type can be upcast automatically to the object type.
        /// </summary>
        /// <param name="obj"></param>
        public void Push(object obj) {          
            if (obj == null) {
                throw new InvalidOperationException();
            }
            //We know where the top of the list is, so we want to store the next element one further in the array
            top = top + 1;
            stackList[top] = obj;            
        }

        /// <summary>
        /// Removes the object on top of the stack and returns it.
        /// </summary>
        /// <returns></returns>
        public object Pop() {
            object removedElement;
            if ((top <= 0)) {
                throw new InvalidOperationException();
            } else {
                removedElement = stackList[top];
                top = top - 1;
            }
            return removedElement;
        }
        /// <summary>
        /// Removes all objects from the stack
        /// </summary>
        public void Clear() {
            stackList = new object[max];
        }
    }


}
