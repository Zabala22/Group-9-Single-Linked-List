namespace SingleLinkedList
{
    public class LinkedList<T>
    {
        // properties to find which is the first and last node in the linked list
        public Node<T> First { get; private set; } // to find the first node
        public Node<T> Last { get; private set; } // to find the last node
        public int Count { get; private set; } // to count how many items is stored in the list

        //constructor (not really needed)
        public LinkedList()
        {
            this.First = null;
            this.Last = null;
        }

        //operations for the linked list program//

        public void AddFirst(Node<T> newNode)
        {
            if (this.First == null)
            {
                // this means the linked list is empty
                // insert the new node on point the head and tail to the node
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }
        public void AddLast(Node<T> newNode)
        {
            if (this.First == null)
            {
                // this means the linked list is empty
                // insert the new node on point the head and tail to the node
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }
        public void AddAfter(Node<T> newNode, Node<T> existingNode)
        {
            // if you want to add a new node right after the existing node
            if (this.Last == existingNode)
            {
                Last = newNode;
            }

            newNode.Next = existingNode.Next; // your new node points to the existing node
            existingNode.Next = newNode; // and your existing node points to the new node
            this.Count++;
        }
        public Node<T> Find(T target) // recieves data that is inside a node
        {
            Node<T> currentNode = First; // used a pointer to the first element
            while (currentNode != null && !currentNode.Data.Equals(target)) // used to search for the element
            {
                currentNode = currentNode.Next;
            }
            return currentNode; // if it finds it returns the current node
        }
        public void RemoveFirst()
        {
            if (First == null || this.Count == 0) // if the list is empty do nothing
            {
                // if theres nothing to do.. return
                return;
            }

            First = First.Next; // otherwise get the pointer that points to the second element
            this.Count--; // then decrease the count
        }

        public void Remove(Node<T> doomedNode) // removing a given node within the linked list
        {
            // doomedNode is the node we want to remove from the list

            if (First == null || this.Count == 0)
            {
                //if theres nothing to do.. return
                return;
            }

            if (this.First == doomedNode) //if the first item is our doomedNode we will remove it.
            {
                this.RemoveFirst();
                return;
            }

            // else, we will need to traverse the linked list to find the doomedNode and remove it
            Node<T> previous = First;
            Node<T> current = previous.Next;

            while (current != null && current != doomedNode)
            {
                //moving to the next node
                previous = current;
                current = previous.Next;
            }

            // it will be able to find the doom node
            // after the while loop, the current pointer will point to the doomNode
            //then the previous pointer will point to the node before the doomNode

            //removing it
            if (current != null)
            {
                previous.Next = current.Next; // it will ignore the current node that is the doomNode
                this.Count--;
            }
        }

        public void Traverse()

        //traversing the linked list to know the content of the list

        {


            Node<T> node = this.First;

            while (node.Next != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine(node.Data);

        }
    }
}
    