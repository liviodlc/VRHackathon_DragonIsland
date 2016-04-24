using UnityEngine;
using System.Collections;

public class Chest : Item {
	public Random rand = new Random();
	private int assignment;
	private Main main;

	public Chest() {
		assignment = (int) Random.Range(0, 2);
	}

	public void HPValue() {
		if (assignment == 1) {
			main.player.Damage();
		} else {
			if (main.player.health <= 10) {
				main.player.health = main.player.health + 1;
			}
		}
	}
}