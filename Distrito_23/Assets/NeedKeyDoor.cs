using UnityEngine;
using System.Collections;

public class NeedKeyDoor : MonoBehaviour {

	public int scene;
	public string need;
	public GameObject fader;
	public GameObject reason;
	private bool inside;

	void OnMouseDown(){
		if (inside) {
			string hasKey = PlayerPrefs.GetString ("HasKey?");
			string hasRead = PlayerPrefs.GetString ("HasRead?");
			if (hasKey == "True" && need == "Key") {
				StartCoroutine (change ());
			} else if (hasRead == "True" && need == "Note"){
				StartCoroutine(change());
			} else if(GameObject.FindGameObjectWithTag("Dialogue") == null) {
				if (gameObject.tag == "NoteDoor") {
					PlayerPrefs.SetString("HasRead?", "True");
				}
				
				Instantiate(reason, new Vector3(Camera.main.transform.position.x, 0.4f, 0), Quaternion.identity);
				
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		inside = true;
	}

	void OnTriggerExit2D(Collider2D other){
		inside = false;
	}
	
	IEnumerator change(){
		Instantiate (fader);
		yield return new WaitForSeconds (1.23f);
		Application.LoadLevel (scene);
	}
}
