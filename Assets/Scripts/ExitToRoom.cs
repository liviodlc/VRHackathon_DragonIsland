using UnityEngine;
using System.Collections;

public class ExitToRoom : MonoBehaviour {

	public Main main;
	public Room myRoom;

	public void OnHighlight(bool state)
	{
		GetComponent<Renderer>().material.color = state ? Color.green : Color.white;
	}

	public void onMove()
	{
		main.setRoom(myRoom);
	}
}
