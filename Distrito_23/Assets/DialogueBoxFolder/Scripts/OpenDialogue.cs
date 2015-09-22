using UnityEngine;
using System.Collections;

public class OpenDialogue : MonoBehaviour {

	public GameObject dialogue;


	void OnMouseDown(){
		if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
			Instantiate (dialogue);
		}

		if (gameObject.tag == "Bag") {
			PlayerPrefs.SetString ("HasKey?", "True");
		} else if (gameObject.tag == "Note") {
			PlayerPrefs.SetString("HasRead?", "True");
		}
	}
}