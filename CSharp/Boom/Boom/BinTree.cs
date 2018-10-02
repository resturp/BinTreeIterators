/*
MIT License
Copyright (c) 2018 Thomas Boose
*/


using System;
using System.Collections;
using System.Collections.Generic;

namespace Boom
{
    public class BinTree : IEnumerable<BinTree>
    {

        public BinTree left, right, parent;

        private String value;
        private IEnumerator<BinTree> iter;


        public BinTree(BinTree left, BinTree right, String value)
        {
            this.left = left;
            this.right = right;
            this.value = value;

            if (left != null)
            {
                left.parent = this;
            }
            if (right != null)
            {
                right.parent = this;
            }

        }

    
        public override String ToString()
        {
            return value;
        }


        public void setIterator(IEnumerator<BinTree> iter)
        {
            this.iter = iter;
        }


        public IEnumerator<BinTree> GetEnumerator()
        {
            return iter;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return iter;
        }
    }
}
