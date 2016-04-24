using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {
	public AudioClip audio;
	// Use this for initialization
	void Start () {
		AudioClip
		AudioSource.PlayClipAtPoint(audio, transform.position);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		Destroy(gameObject);
	}
}
