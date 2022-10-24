using System;
using System.Collections.Generic;

namespace PracticeExercise3
{
    public class Deque<T> : IDeque<T>
    {
        private LinkedList<T> linkedList;

        public Deque()
        {
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty => throw new EmptyQueueException();

        public int Length => linkedList.Count;

        public T Front => linkedList.First();

        public T Back => linkedList.Last(); 

        public void AddBack(T item)
        {
            linkedList.AddLast(item);
        }

        public void AddFront(T item)
        {
            linkedList.AddFirst(item);
        }

        public T RemoveBack()
        {
            linkedList.RemoveLast();
            return linkedList.Last();
        }

        public T RemoveFront()
        {
            linkedList.RemoveFirst();
            return linkedList.First();
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