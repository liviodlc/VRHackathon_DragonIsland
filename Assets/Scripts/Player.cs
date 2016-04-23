using UnityEngine;
using System.Collections;

public class Player {
	private Room currentRoom;
	private int health;
	private Item items;

	public Player() {
		health = 10;
	}

	public bool IsAlive() {
		return health == 0;
	}


}
