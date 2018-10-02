/*
MIT License
Copyright (c) 2018 Thomas Boose
*/

public class Program {

	public static void main(String[] args) {
		Lijst l = new Lijst(8);
		for (Item i : l) {
			System.out.println(i.getValue());
		}

		BinTree btA = new BinTree(null, null, "A");
		BinTree btC = new BinTree(null, null, "C");
		BinTree btB = new BinTree(btA, btC, "B");
		BinTree btE = new BinTree(null, null, "E");
		BinTree btG = new BinTree(null, null, "G");
		BinTree btF = new BinTree(btE, btG, "F");
		BinTree btD = new BinTree(btB, btF, "D");
		
		btD.setIterator(new PreFixIterator(btD));
		
		for (BinTree bt : btD ) {
			System.out.println(bt.toString());
		}
		
		System.out.println("---");
		btD.setIterator(new InFixIterator(btD));
		
		for (BinTree bt : btD ) {
			System.out.println(bt.toString());
		}
		System.out.println("---");
	}

}
