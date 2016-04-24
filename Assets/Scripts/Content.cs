using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Content
{

	public static void initContent(Player player, Room startingRoom)
	{
		Room r1 = startingRoom;

		Room r2 = new Room();
		r1.setExit(Direction.East, r1);

		Room r3 = new Room();
		r2.setExit(Direction.South, r3);
	}
}