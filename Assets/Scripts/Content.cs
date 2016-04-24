﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Content
{

	public static void initContent (Player player, Room startingRoom)
	{
		Room r1 = startingRoom;
		Ball ball = new Ball ();

		Room r2 = new Room ();
		Ball b2 = new Ball ();

		Room r3 = new Room ();
		Room r4 = new Room ();
		Room r5 = new Room ();


		Dragon d1 = new Dragon();
		Chest c1 = new Chest();

	

		//Room 1
		r1.setExit (Direction.East, r2);
		r1.addItem (ball);
		r1.addDragon(d1);
		r1.addItem (c1);

		//#room2
		r2.setExit (Direction.East, r3);
		r2.addItem (b2);

		//Room3
		r3.setExit (Direction.North, r4);
		r3.setExit (Direction.East, r5);

	}
}