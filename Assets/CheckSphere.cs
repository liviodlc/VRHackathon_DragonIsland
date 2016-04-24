using UnityEngine;
using System.Collections;

public class CheckSphere : MonoBehaviour {

	public Main main;
//	public Room myRoom;

	public void OnHighlight(bool state)
	{
		GetComponent<Renderer>().material.color = state ? Color.green : Color.black;
	}

	public void onMove()
	{
		Debug.Log ("I clicked sphere");
	}
}
