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
	}

	public void onMove()
	{
		int rand = Random.Range (0, 6);
		main.setRoom(myRoom);
		AudioSource.PlayClipAtPoint(audio, transform.position);
	}
}
