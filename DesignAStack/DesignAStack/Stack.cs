using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignAStack
{
    public class Stack
    {
        //Could use either of these fields
        //private readonly ArrayList _list = new ArrayList();
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            //Don't store null references
            try
            {
                if (obj == null)
                {
                    throw new InvalidOperationException("obj should not be null");                
                }
                _list.Add(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public object Pop()
        {
            //Need to check for an empty stack and throw exception if there is
            if (_list.Count <= 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            var result = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return result;
        }

        public void Clear()
        {
            //Needs to remove all objects from the stack
            _list.Clear();
        }
    }
}