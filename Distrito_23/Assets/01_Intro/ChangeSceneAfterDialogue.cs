using UnityEngine;
using System.Collections;

public class ChangeSceneAfterDialogue : MonoBehaviour {

	public int changeTo;
	public GameObject fader;

	IEnumerator change(){
		Instantiate (fader);
		yield return new WaitForSeconds (1.23f);
		Application.LoadLevel (changeTo);
	}

	void Update () {
		if (GameObject.FindGameObjectWithTag ("Dialogue") == null)
			StartCoroutine (change());
	}
}
