using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assemblies;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            LinkedList<int> sortedList = new LinkedList<int>();

            //while (j != null)
            //{
            //    LinkedListNode<int> i = list.First;
            //    LinkedListNode<int> j = i.Next;
            //}
            //var current = list.First;
            //var next = current.Next;

            //while (next != null)
            //{
            //    if (current.Value > next.Value)
            //    {
            //        var temp = current;
            //        current = next;
            //        next = temp;
            //    }
            //    next = current.Next;
            //}
          
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            return list;
        }
    }
}
