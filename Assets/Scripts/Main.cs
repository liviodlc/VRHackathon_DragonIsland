using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	Player player;
	Room currentRoom;
	public Room selectedRoom;
	ArrayList roomStuff;

	public GameObject ExitPrefab;
	public BlackScreen black;
	public float transitionTime = 1f;
	public float ExitDistance = 6f;

	// Use this for initialization
	void Start () {
		roomStuff = new ArrayList();
		player = new Player();
		Room firstRoom = new Room();
		Content.initContent(player, firstRoom);
		setRoom(firstRoom);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setRoom(Room newRoom)
	{
		StartCoroutine(_setRoom(newRoom));
	}
	public IEnumerator _setRoom(Room newRoom)
	{
		if (currentRoom != null)
		{
			//clear current room
			black.darken(true);
			foreach (GameObject obj in roomStuff)
			{
				Destroy(obj);
			}
			yield return new WaitForSeconds(transitionTime);
			black.darken(false);
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
			//door.transform.position = new Vector3(0, 0, 0);
			switch(exit.d)
			{
				case Direction.North:
					door.transform.position += new Vector3(0, 0, ExitDistance);
					break;
				case Direction.South:
					door.transform.position += new Vector3(0, 0, -ExitDistance);
					break;
				case Direction.East:
					door.transform.position += new Vector3(ExitDistance, 0, 0);
					door.transform.Rotate(new Vector3(0, 90f, 0));
					break;
				case Direction.West:
					door.transform.position += new Vector3(-ExitDistance, 0, 0);
					door.transform.Rotate(new Vector3(0, -90f, 0));
					break;
			}
			ExitToRoom doorComp = door.GetComponent<ExitToRoom>();
			doorComp.myRoom = exit.r;
			doorComp.main = this;
			roomStuff.Add(door);
		}

	}
}
