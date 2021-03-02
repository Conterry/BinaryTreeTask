using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class BST
    {
        private BST LeftElement;
        private BST RightElement;
        private int CurrentElement;

        public BST(int FirstElementOfTree)
        {
            this.CurrentElement = FirstElementOfTree;
        }

        public void Add(int element)
        {
            if (element < this.CurrentElement) this.GoLeft(element);
            if (element > this.CurrentElement) this.GoRight(element);

        }

        public bool DoesTreeContain(int value)
        {
            if (value == this.CurrentElement)
            {
                return true;
            }
            else if (value < this.CurrentElement && this.LeftElement != null)
            {
                this.LeftElement.DoesTreeContain(value);
                return false;
            }
            else if( value > this.CurrentElement && this.RightElement != null)
            {
                this.RightElement.DoesTreeContain(value);
                return false;
            }
            else
            {
                return false;
            }
        }

        //private bool GoLeft(int element) => this.CurrentElement > element;
        //private bool GoRight(int element) => this.CurrentElement < element;

        private void GoLeft(int element)
        {
            if ((element < this.CurrentElement) && (this.LeftElement!=null))
            {
                this.LeftElement.GoLeft(element);
            }
            else if((element > this.CurrentElement) && (this.LeftElement != null))
            {
                this.LeftElement.GoRight(element);
            }
            else
            {
                this.LeftElement = new BST(element);
            }
        }

        private void GoRight(int element)
        {
            if ((element < this.CurrentElement) && (this.RightElement!=null))
            {
                this.RightElement.GoLeft(element);
            }
            else if ((element > this.CurrentElement) && (this.RightElement != null))
            {
                this.RightElement.GoRight(element);
            }
            else
            {
                this.RightElement = new BST(element);
            }
        }

        /*public int[] TreeElements()
        {
            List<int> Elements = new List<int>();
            int previous;

        }*/

        public int FirstElement()
        {

            return this.LeftElement == null ? this.CurrentElement : this.LeftElement.FirstElement();
        }

        public int LastElement()
        {

            return this.RightElement == null ? this.CurrentElement : this.RightElement.LastElement();
        }

    }
}
