using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticeExercise3
{
    public class Deque<T> : IDeque<T>
    {
        private LinkedList<T> linkedList;

        public Deque()
        {
            linkedList = new LinkedList<T>();
            length = 0;
            length = linkedList.Count;
        }

        public bool IsEmpty => Length == 0;

        public int Length => linkedList.Count;
        private int length = 0;
        
        

        public T Front => IsEmpty ? throw new EmptyQueueException() : linkedList.First.Value;

        public T Back => IsEmpty ? throw new EmptyQueueException() : linkedList.Last.Value;

        public void AddBack(T item)
        {
            linkedList.AddLast(item);
            length++;
            
        }

        public void AddFront(T item)
        {
            linkedList.AddFirst(item);
            length++;
        }

        public T RemoveBack()
        {
            linkedList.RemoveLast();
            return linkedList.Last();
            length--;
        }

        public T RemoveFront()
        {
            linkedList.RemoveFirst();
            return linkedList.First();
            length--;
        }

        public override string ToString()
        {
            string result = "<Back> ";

            var currentNode = linkedList.Last;
            while (currentNode != null)
            {
                result += currentNode.Value;
                if (currentNode.Previous != null)
                {
                    result += " → ";
                }
                currentNode = currentNode.Previous;
            }

            result += " <Front>";

            return result;
        }
    }
}