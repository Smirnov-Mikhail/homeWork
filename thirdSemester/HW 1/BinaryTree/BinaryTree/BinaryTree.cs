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
        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
        }

        private Node root;

        public BinaryTree()
        {}

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
                Add(value, this.root);
        }

        private void Add(T value, Node root)
        {
            if (root.Value.CompareTo(value) > 0)
            {
                if (root.LeftChild == null)
                {
                    var newNode = new Node(value);
                    root.LeftChild = newNode;
                }
                else
                    Add(value, root.LeftChild);
            }
            else
            {
                if (root.RightChild == null)
                {
                    var newNode = new Node(value);
                    root.RightChild = newNode;
                }
                else
                    Add(value, root.RightChild);
            }
        }

        /// <summary>
        /// Method for search element in tree.
        /// </summary>
        /// <param name="value"> This element. </param>
        /// <returns></returns>
        public bool Exist(T value)
        {
            if (this.root != null)
                return this.Exist(value, root);

            return false;
        }

        private bool Exist(T value, Node root)
        {
            if (root.Value.CompareTo(value) == 0)
                return true;
            else if (root.Value.CompareTo(value) > 0)
            {
                if (root.LeftChild == null)
                    return false;
                else
                    return Exist(value, root.LeftChild);
            }
            else
            {
                if (root.RightChild == null)
                    return false;
                else
                    return Exist(value, root.RightChild);
            }
        }

        /// <summary>
        /// Method for write tree.
        /// </summary>
        public void Print()
        {
            if (this.root == null)
                Console.WriteLine("Tree is empty!");
            else
                this.Print();
        }

        private void Print(Node root)
        {
            Console.WriteLine(root.Value);
            if (root.LeftChild != null)
                this.Print(root.LeftChild);
            if (root.RightChild != null)
                this.Print(root.RightChild);
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
        /// Method for delete element in tree.
        /// </summary>
        /// <param name="value"> This element. </param>
        /// <returns></returns>
        public void Delete(T value)
        {
            root = Delete(value, root);
        }

        private Node Delete(T value, Node root)
        {
            if (root == null)
                return null;
            if (value.CompareTo(root.Value) < 0)
                root.LeftChild = Delete(value, root.LeftChild);
            else if (value.CompareTo(root.Value) > 0)
                root.RightChild = Delete(value, root.RightChild);
            else
            {
                if (root.LeftChild == null && root.RightChild == null)
                    return null;
                else if ((root.LeftChild != null && root.RightChild == null) || (root.LeftChild == null && root.RightChild != null))
                    return (root.LeftChild != null) ? root.LeftChild : root.RightChild;
                else
                {
                    if (root.RightChild.LeftChild == null)
                    {
                        Node tmp = root.LeftChild;
                        root = root.RightChild;
                        root.LeftChild = tmp;
                        return root;
                    }
                    else
                    {
                        Node tmp = root.LeftChild;
                        root = root.RightChild;
                        Node tmp2 = root;
                        while (tmp2.LeftChild.LeftChild != null)
                        {
                            tmp2 = tmp2.LeftChild;
                        }
                        tmp2.LeftChild.LeftChild = tmp;
                        return root;
                    }
                }
            }
            return root;
        }

        /// <summary>
        /// Tree enumerator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
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

            /// <summary>
            /// Return current value.
            /// </summary>
            public T Current
            {
                get { return currentElement.Value; }
            }

            void IDisposable.Dispose()
            {}

            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }

            /// <summary>
            /// Move enumenator for next element and check end of tree.
            /// </summary>
            /// <returns></returns>
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

            /// <summary>
            /// Sets initial value.
            /// </summary>
            void System.Collections.IEnumerator.Reset()
            {
                stack.Clear();
                stack.Push(tree.root);
            }
        }

        /// <summary>
        /// Return tree enumerator for this class.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new NodeIterator(this);
        }

        /// <summary>
        /// GetEnumerator
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}