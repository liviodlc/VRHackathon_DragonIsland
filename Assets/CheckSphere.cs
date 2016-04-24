using UnityEngine;
using System.Collections;

public class CheckSphere : MonoBehaviour {

	public Main main;
	public Item myItem;

	public void OnHighlight(bool state)
	{
		GetComponent<Renderer>().material.color = state ? Color.green : Color.black;
		if (state)
			main.selectedItem = myItem;
	}

	public void onCommand() {
		transform.position = new Vector3(-0.49f, 0.57f, 0.11f);
	}
}
