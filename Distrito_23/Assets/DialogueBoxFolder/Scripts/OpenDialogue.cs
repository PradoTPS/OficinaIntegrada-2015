using UnityEngine;
using System.Collections;

public class OpenDialogue : MonoBehaviour {

	public GameObject dialogue;
	
	void OnMouseDown(){
		if (gameObject.tag == "SecondaryObject") {
			if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
				Instantiate (dialogue, new Vector3 (Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (gameObject.tag == "MoveToObject") {
			if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
				Instantiate (dialogue, new Vector3 (Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
			}
		} else if(gameObject.tag == "Bag") {
			if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
				Instantiate (dialogue, new Vector3 (Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
			}
			PlayerPrefs.SetString ("HasKey?", "True");
		} else if (gameObject.tag == "Note") {
			if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
				Instantiate (dialogue, new Vector3 (Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
			}
			PlayerPrefs.SetString ("HasRead?", "True");
		}
		Debug.Log ("BATAAAAAAAATA");
	}
}