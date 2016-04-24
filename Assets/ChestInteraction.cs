using UnityEngine;
using System.Collections;

public class ChestInteraction : MonoBehaviour {
		public Main main;
		public Item myItem;

		public void OnHighlight(bool state)
		{
		GetComponent<Renderer>().material.color = state ? Color.green : Color.white;
		if (state)
			main.selectedChest = this;
		else if (main.selectedChest == this)
			main.selectedChest = null;
		}


}
