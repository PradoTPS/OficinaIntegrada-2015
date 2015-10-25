using UnityEngine;
using System.Collections;

public class IntroPass : MonoBehaviour {

	public GameObject Fade;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString("hasTakenBag", "false");
		PlayerPrefs.SetString("HasKey?", "false");
		StartCoroutine (helloworld());
	}
		
	IEnumerator helloworld(){
		yield return new WaitForSeconds (3);
		Instantiate (Fade);
		yield return new WaitForSeconds (3);
		Application.LoadLevel (1);
	}

}
