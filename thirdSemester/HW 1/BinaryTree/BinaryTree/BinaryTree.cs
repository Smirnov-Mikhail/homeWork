namespace BinaryTreeNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class of tree.
    /// </summary>
    /// <typeparam name="T"> Type of element. </typeparam>
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable
    {
        private Node root;

        public BinaryTree()
        {
            this.root = null;
        }

        /// <summary>
        /// Method for add element in tree.
        /// </summary>
        /// <param name="value"> This element. </param>
        public void Add(T value)
        {
            if (this.Exist(value))
                throw new AddRepeatElementException();
            else  if (this.root == null)
                this.root = new Node(value);
            else
                this.root.Add(value);
        }

        /// <summary>
        /// Method for search element in tree.
        /// </summary>
        /// <param name="value"> This element. </param>
        /// <returns></returns>
        public bool Exist(T value)
        {
            if (this.root != null)
                return this.root.Exist(value);

            return false;
        }

        /// <summary>
        /// Method for delete element in tree.
        /// </summary>
        /// <param name="value"> This element. </param>
        public void Delete(T value)
        {
            if (this.root == null || !this.Exist(value))
                return;
            else if (this.root.Value.CompareTo(value) != 0)
            {
                if (this.root.Value.CompareTo(value) < 0)
                    this.root.LeftChild.Delete(value, this.root);
                else
                    this.root.RightChild.Delete(value, this.root);
            }
            else
            {
                if (this.root.RightChild == null && this.root.LeftChild == null)
                    this.root = null;
                else if (this.root.LeftChild == null)
                    this.root = this.root.RightChild;
                else if (this.root.RightChild == null)
                    this.root = this.root.LeftChild;
                else
                {
                    if (this.root.LeftChild.RightChild == null)
                    {
                        this.root.LeftChild.RightChild = this.root.RightChild;
                        this.root = this.root.LeftChild;
                    }
                    else
                    {
                        var currentNode = this.root.LeftChild.RightChild;
                        var tempNode = new Node(default(T));

                        if (currentNode.RightChild == null)
                            this.root.LeftChild.RightChild = null;
                        else
                        {
                            while (currentNode.RightChild.RightChild != null)
                                currentNode = currentNode.RightChild;
                            tempNode = currentNode.RightChild;
                            currentNode.RightChild = null;
                        }

                        tempNode.RightChild = this.root.RightChild;
                        tempNode.LeftChild = this.root.LeftChild;
                        this.root = tempNode;
                    }
                }
            }
        }

        /// <summary>
        /// Method for write tree.
        /// </summary>
        public void Print()
        {
            if (this.root == null)
            {
                Console.WriteLine("Tree is empty!");
            }
            else
                this.root.Print();
        }

        /// <summary>
        /// Method for test tree on empty.
        /// </summary>
        /// <returns></returns>
        public bool TestForEmpty()
        {
            return this.root == null;
        }

        /// <summary>
        /// Tree element.
        /// </summary>
        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
                this.LeftChild = null;
                this.RightChild = null;
            }

            /// <summary>
            /// Method for add element in tree.
            /// </summary>
            /// <param name="value"> This element. </param>
            public void Add(T value)
            {
                if (this.Value.CompareTo(value) < 0)
                {
                    if (this.LeftChild == null)
                    {
                        var newNode = new Node(value);
                        this.LeftChild = newNode;
                    }
                    else
                        this.LeftChild.Add(value);
                }
                else
                {
                    if (this.RightChild == null)
                    {
                        var newNode = new Node(value);
                        this.RightChild = newNode;
                    }
                    else
                        this.RightChild.Add(value);
                }
            }

            /// <summary>
            /// Method for search element in tree.
            /// </summary>
            /// <param name="value"> This element. </param>
            /// <returns></returns>
            public bool Exist(T value)
            {
                if (this.Value.CompareTo(value) == 0)
                    return true;
                else if (this.Value.CompareTo(value) < 0)
                {
                    if (this.LeftChild == null)
                        return false;
                    else
                        return this.LeftChild.Exist(value);
                }
                else
                {
                    if (this.RightChild == null)
                        return false;
                    else
                        return this.RightChild.Exist(value);
                }
            }

            /// <summary>
            /// Method for delete element in tree.
            /// </summary>
            /// <param name="value"> This element. </param>
            /// <param name="previous"> Previous element. </param>
            public void Delete(T value, Node previous)
            {   
                if (this.Value.CompareTo(value) == 0)
                {
                    if (this.LeftChild == null && this.RightChild == null)
                    {
                        if (previous.LeftChild == null)
                            previous.RightChild = null;
                        else if (previous.RightChild == null || previous.LeftChild.Value.CompareTo(value) == 0)
                            previous.LeftChild = null;
                        else
                            previous.RightChild = null;
                    }
                    else if (this.LeftChild == null)
                    {
                        if (previous.LeftChild == null)
                            previous.RightChild = this.RightChild;
                        else if (previous.RightChild == null || previous.LeftChild.Value.CompareTo(value) == 0)
                            previous.LeftChild = this.RightChild;
                        else
                            previous.RightChild = this.RightChild;
                    }
                    else if (this.RightChild == null)
                    {
                        if (previous.LeftChild == null)
                            previous.RightChild = this.LeftChild;
                        else if (previous.RightChild == null || previous.LeftChild.Value.CompareTo(value) == 0)
                            previous.LeftChild = this.LeftChild;
                        else
                            previous.RightChild = this.LeftChild;
                    }
                    else
                    {
                        if (previous.LeftChild == null)
                        {
                            if (this.RightChild.LeftChild == null)
                            {
                                previous.RightChild = this.RightChild;
                                this.RightChild.LeftChild = this.LeftChild;
                            }
                            else
                            {
                                var currentNode = this.RightChild.LeftChild;
                                var tempNode = new Node(default(T));

                                if (currentNode.LeftChild == null)
                                    this.RightChild.LeftChild = null;
                                else
                                {
                                    while (currentNode.LeftChild.LeftChild != null)
                                        currentNode = currentNode.LeftChild;
                                    tempNode = currentNode.LeftChild;
                                    currentNode.LeftChild = null;
                                }

                                previous.RightChild = tempNode;
                                tempNode.LeftChild = this.LeftChild;
                                tempNode.RightChild = this.RightChild;
                            }
                        }
                        else if (previous.RightChild == null || previous.LeftChild.Value.CompareTo(value) == 0)
                        {
                            if (this.LeftChild.RightChild == null)
                            {
                                previous.LeftChild = this.LeftChild;
                                this.LeftChild.RightChild = this.RightChild;
                            }
                            else
                            {
                                var currentNode = this.LeftChild.RightChild;
                                var tempNode = new Node(default(T));

                                if (currentNode.RightChild == null)
                                    this.LeftChild.RightChild = null;
                                else
                                {
                                    while (currentNode.RightChild.RightChild != null)
                                        currentNode = currentNode.RightChild;
                                    tempNode = currentNode.RightChild;
                                    currentNode.RightChild = null;
                                }

                                previous.LeftChild = tempNode;
                                tempNode.LeftChild = this.LeftChild;
                                tempNode.RightChild = this.RightChild;
                            }
                        }
                        else
                        {
                            if (this.RightChild.LeftChild == null)
                            {
                                previous.RightChild = this.RightChild;
                                this.RightChild.LeftChild = this.LeftChild;
                            }
                            else
                            {
                                var currentNode = this.RightChild.LeftChild;
                                var tempNode = new Node(default(T));

                                if (currentNode.LeftChild == null)
                                    this.RightChild.LeftChild = null;
                                else
                                {
                                    while (currentNode.LeftChild.LeftChild != null)
                                        currentNode = currentNode.LeftChild;
                                    tempNode = currentNode.LeftChild;
                                    currentNode.LeftChild = null;
                                }

                                previous.RightChild = tempNode;
                                tempNode.LeftChild = this.LeftChild;
                                tempNode.RightChild = this.RightChild;
                            }
                        }
                    }
                }
                else if (this.Value.CompareTo(value) < 0)
                {
                    if (this.LeftChild == null)
                        return;
                    else
                        this.LeftChild.Delete(value, this.LeftChild);
                }
                else
                {
                    if (this.RightChild == null) 
                        return;
                    else
                        this.RightChild.Delete(value, this.RightChild);
                }
            }

            /// <summary>
            /// Method for write tree.
            /// </summary>
            public void Print()
            {
                Console.WriteLine(this.Value);
                if (this.LeftChild != null)
                    this.LeftChild.Print();
                if (this.RightChild != null)
                    this.RightChild.Print();   
            }

            public T Value { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
        }

        private class NodeIterator : IEnumerator<T>
        {
            private Node currentElement;
            private BinaryTree<T> tree;
            private  Stack<Node> stack;

            public NodeIterator(BinaryTree<T> tree)
            {
                this.tree = tree;
                stack = new Stack<Node>();
                stack.Push(tree.root);
            }

            public T Current
            {
                get { return currentElement.Value; }
            }

            void IDisposable.Dispose()
            {

            }

            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                if (stack.Count == 0)
                    return false;
                else
                {
                    currentElement = stack.Pop();
                    if (currentElement.LeftChild != null)
                        stack.Push(currentElement.LeftChild);
                    if (currentElement.RightChild != null)
                        stack.Push(currentElement.RightChild);
                    return true;
                }
            }

            void System.Collections.IEnumerator.Reset()
            {
                stack.Clear();
                stack.Push(tree.root);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new NodeIterator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}