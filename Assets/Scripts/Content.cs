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
		Ball ball = new Ball();
		r1.setExit(Direction.East, r2);
		r1.addItem(ball);

		Room r3 = new Room();
		Ball b2 = new Ball();
		r2.setExit(Direction.South, r3);
		r2.addItem(b2);
	}
}