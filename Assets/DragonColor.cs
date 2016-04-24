using UnityEngine;
using System.Collections;

public class DragonColor : MonoBehaviour {

	public Material color;

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform)
		{
			child.gameObject.GetComponent<Renderer>().material = color;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
