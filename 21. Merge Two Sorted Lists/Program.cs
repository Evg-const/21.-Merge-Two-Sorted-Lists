using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Merge_Two_Sorted_Lists
{




    class Program
    {
        static void Main(string[] args)
        { 
            


            int[] aa = { 1, 2, 4 };
            int[] bb = { 1, 3, 4 };
            ListNode a = new ListNode();
            ListNode b = new ListNode();




            ListNode c = MergeTwoLists(a, b);




            ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                ListNode answer = new ListNode(), cur = answer;

                if (l1 == null && l2 == null) return null;
                else if (l1 == null) return l2;
                else if (l2 == null) return l1;

                while (l1 != null && l2 != null)
                {
                    if (l1.val < l2.val)
                    {
                        cur.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        cur.next = l2;
                        l2 = l2.next;
                    }
                    cur = cur.next;

                }

                if (l1 == null)
                {
                    cur.next = l2;
                }
                if (l2 == null)
                {
                    cur.next = l1;
                }

                return answer.next;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}




