using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_alogorithms
{
    class Node
    {
        public int info;
        public Node link;

        public Node(int i)
        {
            info = i;
            link = null;
        }

    }
    class SingleLinkedlist
    {
        private Node start;
        public SingleLinkedlist()
        {
            start = null;

        }
        //public void Append(object value)
        //{
        //    Node n = new Node { data = value };
        //    if (root == null)
        //        root = n;
        //    else
        //        Last.next = n;
        //}
        public void Insertatbeginning(int data)
        {
            Node p;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
                return;
            }
            temp.link = start;
            start = temp;
        }
        public void Append(int value)
        {
            Node temp = new Node(value);
            //Node p = start;
            if (start == null)
            {
                start = temp;
                return;
            }

            Node p = start;
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = temp;
        }

        public void CreateLinkedlist()
        {
            int k, x, data;
            Console.WriteLine("Please enter the length of the linked list");
            k = Convert.ToInt32(Console.ReadLine());
            if (k == 0)
                return;
            for (x = 1; x <= k; x++)
            {
                Console.WriteLine("Please enter the element");
                data = Convert.ToInt32(Console.ReadLine());
                Append(data);

            }
        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is :");
            p = start;
            while (p != null)
            {
                Console.WriteLine(p.info + "");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            Node p = start;
            int n = 0;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.Write("Number of nodes are :" + n);
        }
        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine("Element x not found in the given list");
                return false;
            }
            else
            {
                Console.WriteLine("Element x is at position " + position);
                return true;
            }
        }

        public void InsertatPosition(int data, int position)
        {
            Node p;
            Node temp;
            if (start == null)
                return;// List is empty; return;= new Node(data);
            else
                p = start;
            if (position == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;

            }
            int i;
            for (i = 1; i < position - 1 && p != null; i++)
                p = p.link;
            if (p == null)
                Console.WriteLine("You can only insert element upto " + i + "th position");
            else {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void InsertAfter(int data, int x)
        {
            Node P;
            P = start;
            while (P != null)
            {
                if (P.info == x)
                    break;
                P = P.link;
            }
            if (P == null)
            {
                Console.WriteLine(x + "Node not present in the list");
            }
            else
            {
                Node temp = new Node(data);
                temp.link = P.link;
                P.link = temp;
            }

        }
        public void InsertBefore(int data, int x)
        {
            Node temp;
            Node p;
            p = start;
            if (start == null) // List is empty; return;

                if (start.info == x)
                {
                    temp = new Node(data);
                    temp.link = start;
                    start = temp;
                    return;
                }
            while (p != null && p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == null)
            {
                Console.WriteLine(x + "Node not present in the list");
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void DeleteFirstNode()
        {
            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            start = start.link;

        }

        public void DeleteLastNode()
        {
            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            if (start.link == null)
            {
                start = null;
                return;
            }
            Node p = start;
            while (p.link.link != null)

                p = p.link;
            p.link = null;

        }
        //Delete node given a pointer to the node

        public void DeleteNodewithpointer(Node p)
        {
            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            if (start.link == p.link)
            {
                start = null;
                return;
            }
            Node d = start;
            while (d.link != null)
            {
                if (d.link == p.link)                
                    break;
                d = d.link;                
            }
            d.link = p.link;
            p.info = d.info;
            p.link = d.link;
            d.link = d.link.link;
        }
        // Given only a pointer/reference to a node to be deleted in a singly linked list, how do you delete it?
        //struct node *temp = node_ptr->next;
        //node_ptr->data    = temp->data;
        //node_ptr->next    = temp->next;
        //free(temp);


        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            if (start.info == x)
            {
                start = start.link;
                return;
            }
            // Deleteion in between or at the end
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == null)
            {
                Console.WriteLine("element " + x + " is not found on the list");
                return;
            }
            p.link = p.link.link;
        }

        public void ReverseList()
        {
            Node prev, P, Next;
            prev = null; P = start;
            while (P != null)
            {
                Next = P.link;
                P.link = prev;
                prev = P;
                P = Next;
            }
            start = prev;
        }
        public void BubblesortexData()
        {
            Node end, p, q;
            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void Bubblesortexlink()
        {
            Node end, p, q, r, temp;
            for (end = null; end != start.link; end = p)
            {
                for (r = p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;
                        if (p != start)
                            r.link = q;
                        else
                            start = q;
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Merging 2 sorted lists using data
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public SingleLinkedlist Merge1(SingleLinkedlist list)
        {
            SingleLinkedlist mergeList = new SingleLinkedlist();
            mergeList.start = Merge1(start, list.start);
            return mergeList;
        }
        private Node Merge1(Node p1, Node p2)
        {
            Node startM;
            if (p1.info <= p2.info)
            {
                startM = new Node(p1.info);
                p1 = p1.link;
            }
            else
            {
                startM = new Node(p2.info);
                p2 = p2.link;
            }
            Node pm = startM;
            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pm.link = new Node(p1.info);
                    p1 = p1.link;
                }
                else
                {
                    pm.link = new Node(p2.info);
                    p2 = p2.link;
                }
                pm = pm.link;
            }
            while (p1 != null)
            {
                pm.link = new Node(p1.info);
                p1 = p1.link;
                pm = pm.link;
            }
            while (p2 != null)
            {
                pm.link = new Node(p2.info);
                p2 = p2.link;
                pm = pm.link;
            }


            return startM;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public SingleLinkedlist Merge2(SingleLinkedlist list)
        {
            SingleLinkedlist mergeList = new SingleLinkedlist();
            mergeList.start = Merge2(start, list.start);
            return mergeList;
        }
        private Node Merge2(Node p1, Node p2)
        {
            Node StartM;
            if (p1.info <= p2.info)
            {
                StartM = new Node(p1.info);
                p1 = p1.link;
            }
            else
            {
                StartM = new Node(p2.info);
                p2 = p2.link;
            }
            Node pm = StartM;
            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pm.link = p1;
                    pm = pm.link;
                    p1 = p1.link;
                }
                else
                {
                    pm.link = p2;
                    pm = pm.link;
                    p2 = p2.link;
                }
            }
            if (p1 == null)
                pm.link = p2;
            else
                pm.link = p2;
            return StartM;
        }

        public void MergeSort()
        {
            start = MergeSortRec(start);
        }
        private Node MergeSortRec(Node listStart)
        {
            if (listStart == null || listStart.link == null)
                return listStart;
            Node start1 = listStart;
            Node start2 = DivideList(start1);
            start1 = MergeSortRec(start1);
            start2 = MergeSortRec(start2);
            Node startM = Merge2(start1, start2);
            return startM;
        }
        private Node DivideList(Node p)
        {
            Node q = p.link.link;
            while (q != null || q.link != null) { 
            p = p.link;
            q = q.link.link;
            }
            Node start2 = p.link;
            p.link = null;
            return start2;
        }
        public bool Hascycle()
        {
            if (Findcycle() == null)
                return false;
            else return true;
        }
        private Node Findcycle()
        {
            if(start == null || start.link == null)
            
                return null;

            Node fastR = start, slowR = start;
            while(fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                    return slowR;
            }
            return null;
        }
        public void RemoveCycle()
        {
            Node c = Findcycle();
            if (c == null) return;
            Console.WriteLine("Node at which cycle was detected  is " + c.info);

            Node p = c, q = c;
            int lenCycle = 0;
            do
            {
                lenCycle++;
                q = q.link;
            } while (p != q);
            Console.WriteLine("Length of cycle is" + lenCycle);
            int lenRemainingList = 0;
            p = start;
            while (p!= q)
            {
                lenRemainingList++;
                p = p.link;
                q = q.link;
            }
            int len = lenRemainingList + lenCycle;
            Console.WriteLine("Total lenghth of the lis is " + len);

            //Remove the cycle
            p = start;
            for (int i = 1; i<- len-1; i++)           
                p = p.link;
                p.link = null;
        }
        public void InsertCycle(int x)
        {
            if (start == null) return;
            Node p = start, px = null, prev = null;
            while (p!= null)
            {
                if(p.info == x)
                 px = p;
                    prev = p;
                p = p.link;
                }
            if (px != null)
                prev.link = px;
            else 
            Console.WriteLine(x + " is not present in te list");
            }
        }
 }

    //Traversing a singly linked list
    //Node p = start;
    //while (p.link != null)
    //    {
    //        Console.write(p.info +"");
    //         p = p.link;
    //    }


