using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form1.cs;


class HashMap
{
    private int bucketCount;
    private List<TreeNode>[] buckets;

    public HashMap(int bucketCount = 16)
    {
        this.bucketCount = bucketCount;
        buckets = new List<TreeNode>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<TreeNode>();
        }
    }

    private int HashFunction(int key)
    {
        return key.GetHashCode() % bucketCount;
    }


    public void BiletSil(int key)
    {
        int index = HashFunction(key);
        var bucket = buckets[index];
        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].Key == key)
            {
                bucket.RemoveAt(i);
                return;
            }
        }
    }
}

