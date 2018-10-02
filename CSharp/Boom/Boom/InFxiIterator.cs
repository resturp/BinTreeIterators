/*
MIT License
Copyright (c) 2018 Thomas Boose
*/

using System.Collections;
using System.Collections.Generic;

namespace Boom
{
    public class InFxiIterator : IEnumerator<BinTree>
    {
        private BinTree NextItem;
        private BinTree Original;
        private bool First = true;

        public InFxiIterator(BinTree root)
        {
            NextItem = root;
            Original = root;
        }

        public BinTree Current => NextItem;
        object IEnumerator.Current => NextItem;


        public bool MoveNext()

        {
            if (First) {
                First = false;
            } else {
                if (NextItem.left != null)
                {
                    NextItem = NextItem.left;
                }
                else
                {
                    if (NextItem.right != null)
                    {
                        NextItem = NextItem.right;
                    }
                    else
                    {
                        if (NextItem.parent.right != null)
                        {
                            while (NextItem.parent != null && NextItem == NextItem.parent.right)
                            {
                                NextItem = NextItem.parent;
                            }
                            if (NextItem.parent != null)
                            {
                                NextItem = NextItem.parent.right;
                            }
                            else
                            {
                                NextItem = null;
                            }

                        }
                        else
                        {
                            NextItem = null;
                        }
                    }
                }              
            }
            return NextItem != null;
        }

        public void Reset()
        {
            NextItem = Original;
            First = true;
        }

        public void Dispose()
        {
            NextItem = null;
            Original = null;
        }
    }

}
