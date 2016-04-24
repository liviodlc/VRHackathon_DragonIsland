using UnityEngine;
using System.Collections;

public class CheckSphere : MonoBehaviour {

	public Main main;
	public Item myItem;
	private Rigidbody rb;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}
	public void OnHighlight(bool state)
	{
		GetComponent<Renderer>().material.color = state ? Color.green : Color.black;
		if (state)
			main.selectedItem = myItem;
	}

	public void onCommand() {
		transform.parent = main.head.transform;
		transform.localPosition = new Vector3(0.23f, -0.37f, 0.41f);
		//		rb.AddForce (0, 200, 200, ForceMode.Impulse);
	}

	public void onThrow()
	{
		transform.parent = null;
		rb.velocity = (transform.position - main.head.transform.position) * 5;
	}


}
