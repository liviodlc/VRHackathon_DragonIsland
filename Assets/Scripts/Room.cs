using UnityEngine;
using System.Collections;

public class Room {

	public class Exit
	{
		public Direction d;
		public Room r;

		public Exit(Direction dir, Room room)
		{
			d = dir;
			r = room;
		}
	}

	public ArrayList exits;

	public Room()
	{
		exits = new ArrayList();
	}

	public void setExit(Direction dir, Room room)
	{
		exits.Add(new Exit(dir, room));
	}
}
