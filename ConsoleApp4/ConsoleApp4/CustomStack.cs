/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CustomStack<T>
    {
        public List<T> _stack;

        public CustomStack() 
        { 
        _stack = new List<T>();
        }
       

        internal void Push(T item) {
            _stack.Add(item);
        }

      internal  T Pop()
        {
            if (IsEmpty()) {
                Console.WriteLine("stack is empty");
            }
            T item = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return item;
        }


        internal T Peek() {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
            }

            return _stack[_stack.Count - 1]; 
        }

        public bool IsEmpty()
        {
           return _stack.Count == 0;
        }

       
    }
}
*/

using System;
using System.Collections.Generic;

public class CustomStack<T>
{
    private List<Stack<T>> _stacks;
    private int _limit;

    public CustomStack(int limit)
    {
        _stacks = new List<Stack<T>>();
        _limit = limit;
        _stacks.Add(new Stack<T>());
    }

    public void Push(T item)
    {
        Stack<T> currentStack = _stacks[_stacks.Count - 1];
        if (currentStack.Count >= _limit)
        {
            currentStack = new Stack<T>();
            _stacks.Add(currentStack);
        }
        currentStack.Push(item);
    }

    public T Pop()
    {
        if (_stacks.Count == 0)
        {
            throw new InvalidOperationException("All stacks are empty.");
        }

        Stack<T> currentStack = _stacks[_stacks.Count - 1];
        T item = currentStack.Pop();

        if (currentStack.Count == 0 && _stacks.Count > 1)
        {
            _stacks.RemoveAt(_stacks.Count - 1);
        }

        return item;
    }

    public T Peek()
    {
        if (_stacks.Count == 0)
        {
            throw new InvalidOperationException("All stacks are empty.");
        }

        Stack<T> currentStack = _stacks[_stacks.Count - 1];
        return currentStack.Peek();
    }

    public bool IsEmpty()
    {
        return _stacks.Count == 0 || (_stacks.Count == 1 && _stacks[0].Count == 0);
    }

    public int TotalCount()
    {
        int count = 0;
        foreach (var stack in _stacks)
        {
            count += stack.Count;
        }
        return count;
    }

    public IEnumerable<T> GetElements()
    {
        for (int i = _stacks.Count - 1; i >= 0; i--)
        {
            foreach (var item in _stacks[i])
            {
                yield return item;
            }
        }
    }
}
