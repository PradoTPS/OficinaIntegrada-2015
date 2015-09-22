using UnityEngine;
using System.Collections;

public class NeedKeyDoor : MonoBehaviour {

	public int scene;
	public string need;
	public GameObject fader;
	public GameObject reason;
	public AudioClip Opening;
	
	void OnMouseDown(){
		string hasKey = PlayerPrefs.GetString ("HasKey?");
		string hasRead = PlayerPrefs.GetString ("HasRead?");
		if (hasKey == "True" && need == "Key") {
			StartCoroutine (change ());
		} else if (hasRead == "True" && need == "Note"){
			StartCoroutine(change());
		} else if(GameObject.FindGameObjectWithTag("Dialogue") == null) {
			if (gameObject.tag == "Note") {
				PlayerPrefs.SetString("HasRead?", "True");
			}
			Instantiate(reason);
		}
	}
	
	IEnumerator change(){
		Instantiate (fader);
		yield return new WaitForSeconds (1.23f);
		Application.LoadLevel (scene);
	}
}
