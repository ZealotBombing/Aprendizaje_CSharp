using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Tree<TItem> where TItem : IComparable<TItem> //es una restricción del tipo, no de la clase
    {
        public TItem NodeData { get; set; }//ah mira, de un tipo que no sabemos qué será
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }

        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }
        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null) this.LeftTree = new Tree<TItem>(newItem);
                else this.LeftTree.Insert(newItem);//se llama al métodos desde la propertie poque es de tipo Tree<TItem>
            }
            else
            {
                if (this.RightTree == null) this.RightTree = new Tree<TItem>(newItem);
                else this.RightTree.Insert(newItem);
            }
        }
        public string WalkTree()
        {
            string result = "";

            if (this.LeftTree != null) result = this.LeftTree.WalkTree();

            result += $"{this.NodeData.ToString()} ";

            if (this.RightTree != null) result += this.RightTree.WalkTree();

            return result;

        }
    }
}
