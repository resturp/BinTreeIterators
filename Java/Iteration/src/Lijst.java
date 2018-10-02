/*
MIT License
Copyright (c) 2018 Thomas Boose
*/

import java.util.Iterator;

public class Lijst implements AftelbaarItem{

	private Item[] lijst;
	private int current = 0; 
	
	public Lijst(int aantal) {
		this.lijst = new Item[aantal];
		for (int i = 0; i<aantal ; i++) {
			lijst[i] = new Item();
		}
	}
	
	@Override
	public boolean hasNext() {
		return current < lijst.length;
	}

	@Override
	public Item next() {
		return lijst[current++];
	}

	@Override
	public Iterator<Item> iterator() {
		return this;
	}

}
