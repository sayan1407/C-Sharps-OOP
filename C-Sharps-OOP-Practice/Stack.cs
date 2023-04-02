using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace C_Sharps_OOP_Practice
{
    class Stack
    {
        private ArrayList ListOfObj;
        public Stack()
        {
            ListOfObj = new ArrayList();
        }
        public void Push(Object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot store null");
            ListOfObj.Add(obj);
        }
        public Object Pop()
        {
            if (ListOfObj.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            Object obj = ListOfObj[ListOfObj.Count - 1];
            ListOfObj.RemoveAt(ListOfObj.Count - 1);
            return obj;
        }
        public void Clear()
        {
            ListOfObj.Clear();
        }


    }
}
