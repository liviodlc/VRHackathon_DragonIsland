using UnityEngine;
using System.Collections;

public class BlackScreen : MonoBehaviour {

	public Light roomLight;
	private float lightSetting;

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
	}
	
	public void darken(bool on)
	{
		if (on)
		{
			//yes, dark
			lightSetting = roomLight.intensity;
			roomLight.intensity = 0;
			gameObject.SetActive(true);
		}
		else
		{
			//no, light
			roomLight.intensity = lightSetting;
			gameObject.SetActive(false);
		}
	}
}
