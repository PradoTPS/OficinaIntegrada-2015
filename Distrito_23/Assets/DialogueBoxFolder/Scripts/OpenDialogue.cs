using UnityEngine;
using System.Collections;

public class OpenDialogue : MonoBehaviour {

	public GameObject safe;
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

	
	void Update(){

		string hasTakenBag = PlayerPrefs.GetString("hasTakenBag");

		if (Application.loadedLevel == 5 && gameObject.tag == "MoveToObject" && hasTakenBag == "true") {
			Instantiate(safe);
			Destroy(gameObject);
		}
		
	}
}