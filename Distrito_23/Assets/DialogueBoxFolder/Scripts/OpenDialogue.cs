using UnityEngine;
using System.Collections;

public class OpenDialogue : MonoBehaviour {

	public GameObject dialogue;
	
	void OnMouseDown(){
		if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
			Instantiate(dialogue, new Vector3(Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
		}

		if (gameObject.tag == "Bag") {
			PlayerPrefs.SetString ("HasKey?", "True");
		} else if (gameObject.tag == "Note") {
			PlayerPrefs.SetString("HasRead?", "True");
		}
	}
}