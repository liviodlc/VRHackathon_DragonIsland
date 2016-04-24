using UnityEngine;
using System.Collections;

public class ExitToRoom : MonoBehaviour {

	public Main main;
	public Room myRoom;
	public AudioClip audio;

	public void OnHighlight(bool state)
	{
		GetComponent<Renderer>().material.color = state ? Color.green : Color.white;
		if (state)
			main.selectedRoom = myRoom;
		else if (main.selectedRoom == myRoom)
			main.selectedRoom = null;
	}

	public void onMove()
	{
		AudioSource.PlayClipAtPoint(audio, transform.position);
		main.setRoom(myRoom);
	}
}
