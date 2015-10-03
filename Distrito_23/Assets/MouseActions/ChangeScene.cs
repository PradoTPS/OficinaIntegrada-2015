using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public int scene;
	private bool inside;
	public GameObject fader;

	void OnMouseDown(){
		if (inside) {
			StartCoroutine (change ());
		}
		if (gameObject.tag == "Arrow") {
			StartCoroutine (change ());
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

	void Update(){
		GameObject bg = GameObject.FindGameObjectWithTag ("Background");
		if (bg != null) {
			PlayerPrefs.SetFloat(Application.loadedLevelName + "x", bg.transform.position.x);
			PlayerPrefs.SetFloat(Application.loadedLevelName + "y", bg.transform.position.y);
		}
	}

	void OnApplicationQuit(){
		PlayerPrefs.DeleteAll ();
	}
}
