using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	Player player;
	Room currentRoom;

	public GameObject ExitPrefab;
	public float ExitDistance = 6f;

	// Use this for initialization
	void Start () {
		player = new Player();
		Room firstRoom = new Room();
		Content.initContent(player, currentRoom);
		setRoom(firstRoom);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void setRoom(Room newRoom)
	{
		if(currentRoom != null)
		{
			//clear current room
		}
		//init current room
		currentRoom = newRoom;
		renderExits();
	}

	private void renderExits()
	{
		foreach(Room.Exit exit in currentRoom.exits)
		{
			GameObject door = Instantiate(ExitPrefab);
			
		}

	}
}
