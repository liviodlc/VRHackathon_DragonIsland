using UnityEngine;
using System.Collections;

public class Player  {
//	private Room currentRoom;
	private int health;
//	private Item items;
//	public Item currentSelection;

	public Player() {
		health = 10;
	}

	// True if alive, false if otherwise
	public bool IsAlive() {
		return health == 0;
	}

	// Picks up the item currently looking at
	public void PickUp(Item currentSelection) {

	}

	// Takes health damage 
	public void Damage() {
		health--;
	}


}
