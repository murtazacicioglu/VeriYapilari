namespace VeriYapilari.Primitive
{
    public class Agac
    {
        public AgacDugumu? root;

        public Agac()
        {
            root = null;
        }

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new AgacDugumu(value);
                Console.WriteLine(root.value);
                return;
            }

            AgacDugumu current = root;
            while (true)
            {
                if (value < current.value)
                {
                    if (current.left == null)
                    {
                        current.left = new AgacDugumu(value);
                        break;
                    }
                    current = current.left;
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = new AgacDugumu(value);
                        break;
                    }
                    current = current.right;
                }
            }
        }

        public bool Search(int value)
        {
            AgacDugumu current = root;
            while (current != null)
            {
                if (value == current.value)
                    return true;
                if (value < current.value)
                    current = current.left;
                else if (value > current.value)
                    current = current.right;
            }
            return false;
        }

        public void Delete(int value)
        {
            AgacDugumu current = root;
            AgacDugumu parent = null;
            while (current != null)
            {
                if (value == current.value)
                    break;
                parent = current;
                if (value < current.value)
                    current = current.left;
                else
                    current = current.right;
            }
            if (current == null)
                return;
            if (current.left == null && current.right == null)
            {
                if (current == root)
                    root = null;
                else if (parent.left == current)
                    parent.left = null;
                else
                    parent.right = null;
            }
            else if (current.left == null || current.right == null)
            {
                AgacDugumu child = (current.left != null) ? current.left : current.right;
                if (current == root)
                    root = child;
                else if (parent.left == current)
                    parent.left = child;
                else
                    parent.right = child;
            }
            else
            {
                AgacDugumu minNode = current.right;
                AgacDugumu minNodeParent = current;
                while (minNode.left != null)
                {
                    minNodeParent = minNode;
                    minNode = minNode.left;
                }
                current.value = minNode.value;
                if (minNodeParent.left == minNode)
                    minNodeParent.left = minNode.right;
                else
                    minNodeParent.right = minNode.right;
            }
        }

        public void PrintPostorder()
        {
            Console.Write("Postorder Traversal: ");
            PrintPostorderRecursive(root);
            Console.WriteLine();
        }

        private void PrintPostorderRecursive(AgacDugumu node)
        {
            if (node != null)
            {
                PrintPostorderRecursive(node.left);
                PrintPostorderRecursive(node.right);
                Console.Write(node.value + " ");
            }
        }
    }
}