﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingSingleLinkList
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }

    class Stack
    {
        node top;
        public Stack()
        {
            top = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
