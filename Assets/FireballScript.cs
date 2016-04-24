using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {
	public AudioClip audio;
	public AudioClip audioDragon;
	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint(audio, transform.position);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		Destroy(gameObject);
		if(collision.gameObject.GetComponent<DragonScript>()!=null)
		{
			AudioSource.PlayClipAtPoint(audioDragon, transform.position);
			Destroy(collision.gameObject);
		}
	}
}
