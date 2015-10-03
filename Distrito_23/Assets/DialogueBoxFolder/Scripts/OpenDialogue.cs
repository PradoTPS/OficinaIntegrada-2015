using UnityEngine;
using System.Collections;

public class OpenDialogue : MonoBehaviour {

	public GameObject dialogue;
	public bool inside;
	
	void OnMouseDown(){
		if (inside) {
			if(gameObject.tag == "Bag") {
				if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
					Instantiate (dialogue, new Vector3 (Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
				}
				PlayerPrefs.SetString ("HasKey?", "True");
			} else if (gameObject.tag == "DoorNote") {
				if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
					Instantiate (dialogue, new Vector3 (Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
				}
				PlayerPrefs.SetString ("HasRead?", "True");
			} else {
				if(GameObject.FindGameObjectWithTag("Dialogue") == null) {
					Instantiate (dialogue, new Vector3 (Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
				}
			}
		}
		if (gameObject.tag == "SecondaryObject") {
			if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
				Instantiate (dialogue, new Vector3 (Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		inside = true;
	}

	void OnTriggerExit2D(Collider2D other){
		inside = false;
	}
}