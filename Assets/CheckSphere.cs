using UnityEngine;
using System.Collections;

public class CheckSphere : MonoBehaviour {

	public Main main;
	public Item myItem;
	private Rigidbody rb;
	private bool pickedUp = false;
	public AudioClip audio;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = true;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			onThrow();
	}

	public void OnHighlight(bool state)
	{
		GetComponent<Renderer>().material.color = state ? Color.green : Color.black;
		if (state)
			main.selectedBall = this;
		else if (main.selectedBall == this)
			main.selectedBall = null;
	}

	public void onCommand() {
		transform.parent = main.head.transform;
		transform.localPosition = new Vector3(0.23f, -0.37f, 0.41f);
		GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
//		rb.AddForce (0, 200, 200, ForceMode.Impulse);
		pickedUp = true;
		main.holdingBall = this;
	}

	public void onThrow()
	{
		if (pickedUp)
		{
			AudioSource.PlayClipAtPoint(audio, transform.position);
			rb.isKinematic = false;
			transform.parent = null;
			rb.velocity = main.getDirection() * 10;
			pickedUp = false;
			main.holdingBall = null;
		}
	}


}
