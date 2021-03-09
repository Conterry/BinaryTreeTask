using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class BST
    {
        private BST LeftElement;
        private BST RightElement;
        private int CurrentValue;

        public BST(int FirstElementOfTree)
        {
            this.CurrentValue = FirstElementOfTree;
        }

        public void Add(int element)
        {
            if(this.CurrentValue > element)
            {
                if (this.LeftElement != null) this.LeftElement.Add(element);
                else this.LeftElement = new BST(element);
            }
            else if(this.CurrentValue < element)
            {
                if (this.RightElement != null) this.RightElement.Add(element);
                else this.RightElement = new BST(element);
            }
        }

        public bool DoesTreeContain(int value)
        {
            if (value == this.CurrentValue)
            {
                return true;
            }
            else if (value < this.CurrentValue && this.LeftElement != null)
            {
                return this.LeftElement.DoesTreeContain(value);
            }
            else if (value > this.CurrentValue && this.RightElement != null)
            {
                return this.RightElement.DoesTreeContain(value);
            }
            else return false;
        }

        public void PrintTree()
        {
            if (this.LeftElement != null) this.LeftElement.PrintTree();
            Console.Write($"{this.CurrentValue} ");
            if (this.RightElement != null) this.RightElement.PrintTree();
        }


        public int FirstElement()
        {

            return this.LeftElement == null ? this.CurrentValue : this.LeftElement.FirstElement();
        }

        public int LastElement()
        {

            return this.RightElement == null ? this.CurrentValue : this.RightElement.LastElement();
        }

    }
}
