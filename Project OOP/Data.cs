using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    internal class Node
    {
        public Node Next;
        public Product data;
    }

    internal class StackList
    {
        Node top;
        int id = 1111110;
        public bool isEmpty()
        {
            if (top == null)
                return true; else return false; 
        }
        public void push(string name, string category, int quantity, double cost, double profit)
        {
            Node newProduct = new Node();
            newProduct.data = new Product(name, category, quantity, id, cost, profit);
            newProduct.Next = top;
            top = newProduct;
            id++;
        }
        //public int pop()
        //{
              
        //}
        public void Display()
        {
            Node pointer = new Node();
            pointer = top;
            while (pointer != null)
            {
                
                pointer.data.Display();
                pointer = pointer.Next;
            }
        }
    }
}
