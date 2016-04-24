using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{

	Player player;
	Room currentRoom;
	public Room selectedRoom;
	public CheckSphere selectedBall;
	public CheckSphere holdingBall;
	public CheckSphere selectedChest;
	public GameObject dragonPrefab;
	ArrayList roomStuff;

	public GameObject ExitPrefab;
	public GameObject BallPrefab;
	public GameObject FireballPrefab;
	public float fireballSpeed = 10;
	public BlackScreen black;
	public GameObject head;
	public GameObject point;
	public float transitionTime = 1f;
	public float ExitDistance = 6f;

	// Use this for initialization
	void Start()
	{
		roomStuff = new ArrayList();
		player = new Player();
		Room firstRoom = new Room();
		Content.initContent(player, firstRoom);
		setRoom(firstRoom);
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.P))
		{
			pewPew();
		}
	}

	public Vector3 getDirection()
	{
		return point.transform.position - head.transform.position;
	}

	public void setRoom(Room newRoom)
	{
		if (newRoom != null)
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
				if (holdingBall != null && obj == holdingBall.gameObject)
				{

				}else {
					Destroy(obj);
				}
			}
			roomStuff = new ArrayList();
			if (holdingBall)
				roomStuff.Add(holdingBall);
			yield return new WaitForSeconds(transitionTime);
			black.darken(false);
		}
		//init current room
		currentRoom = newRoom;
		renderExits();
		renderItems();
		renderDragons();
	}

	private void renderExits()
	{
		foreach (Room.Exit exit in currentRoom.exits)
		{
			GameObject door = Instantiate(ExitPrefab);
			//door.transform.position = new Vector3(0, 0, 0);
			switch (exit.d)
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
	private void renderItems()
	{
		foreach (Item item in currentRoom.items)
		{
			GameObject obj;
			if (item is Ball)
			{
				obj = Instantiate(BallPrefab);
				CheckSphere cs = obj.GetComponent<CheckSphere>();
				cs.myItem = item;
				cs.main = this;
				roomStuff.Add(obj);
			}
		}
	}

	private void renderDragons()
	{
		foreach (Dragon d in currentRoom.dragons)
		{
			GameObject obj;
			if (d is Dragon)
			{
				obj = Instantiate(dragonPrefab);
				DragonScript cs = obj.GetComponent<DragonScript>();
				cs.myDragon = d;
				cs.main = this;
				roomStuff.Add(obj);
			}
		}
	}

	public void pewPew()
	{
		GameObject fb = Instantiate(FireballPrefab);
		fb.GetComponent<Rigidbody>().velocity = getDirection() * fireballSpeed;
		fb.transform.position = new Vector3(0, 1.5f, 0);
	}
}
