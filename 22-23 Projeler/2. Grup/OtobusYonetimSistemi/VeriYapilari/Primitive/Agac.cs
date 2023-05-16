namespace VeriYapilari.Primitive;

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
            Console.WriteLine(root.Deger);
            return;
        }

        AgacDugumu current = root;
        while (true)
        {
            if (value < current.Deger)
            {
                if (current.Sol == null)
                {
                    current.Sol = new AgacDugumu(value);
                    break;
                }
                current = current.Sol;
            }
            else
            {
                if (current.Sag == null)
                {
                    current.Sag = new AgacDugumu(value);
                    break;
                }
                current = current.Sag;
            }
        }
    }

    public bool Search(int value)
    {
        AgacDugumu current = root;
        while (current != null)
        {
            if (value == current.Deger)
                return true;
            if (value < current.Deger)
                current = current.Sol;
            else if (value > current.Deger)
                current = current.Sag;
        }
        return false;
    }

    public void Delete(int value)
    {
        AgacDugumu current = root;
        AgacDugumu parent = null;
        while (current != null)
        {
            if (value == current.Deger)
                break;
            parent = current;
            if (value < current.Deger)
                current = current.Sol;
            else
                current = current.Sag;
        }
        if (current == null)
            return;
        if (current.Sol == null && current.Sag == null)
        {
            if (current == root)
                root = null;
            else if (parent.Sol == current)
                parent.Sol = null;
            else
                parent.Sag = null;
        }
        else if (current.Sol == null || current.Sag == null)
        {
            AgacDugumu child = (current.Sol != null) ? current.Sol : current.Sag;
            if (current == root)
                root = child;
            else if (parent.Sol == current)
                parent.Sol = child;
            else
                parent.Sag = child;
        }
        else
        {
            AgacDugumu minNode = current.Sag;
            AgacDugumu minNodeParent = current;
            while (minNode.Sol != null)
            {
                minNodeParent = minNode;
                minNode = minNode.Sol;
            }
            current.Deger = minNode.Deger;
            if (minNodeParent.Sol == minNode)
                minNodeParent.Sol = minNode.Sag;
            else
                minNodeParent.Sag = minNode.Sag;
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
            PrintPostorderRecursive(node.Sol);
            PrintPostorderRecursive(node.Sag);
            Console.Write(node.Deger + " ");
        }
    }
}