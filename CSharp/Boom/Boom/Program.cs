/*
MIT License
Copyright (c) 2018 Thomas Boose
*/

using System;

namespace Boom
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Infix over bintree!");
            BinTree btA = new BinTree(null, null, "A");
            BinTree btC = new BinTree(null, null, "C");
            BinTree btB = new BinTree(btA, btC, "B");
            BinTree btE = new BinTree(null, null, "E");
            BinTree btG = new BinTree(null, null, "G");
            BinTree btF = new BinTree(btE, btG, "F");
            BinTree btD = new BinTree(btB, btF, "D");
        
            btD.setIterator(new InFxiIterator(btD));
        
            foreach (BinTree bt in btD ) {
                Console.WriteLine(bt);
            }
        
        }
    }
}
