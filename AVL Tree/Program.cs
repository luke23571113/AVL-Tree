﻿using System;

namespace AVL_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var avl = new AVL<int>();


            avl.Insert(5);
            avl.Insert(10);
            avl.Insert(7);
            avl.Insert(13);
            var x = avl.findParent(avl.root.rightChild);
            ;
        }
    }
}
