using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    // TODO - Define the IBinaryTree interface.
    public interface IBinaryTree<Titem> 
    {
        void Add(Titem newItem);
        void Remove(Titem itemToRemove);
        void WalkTree();
    }
}
