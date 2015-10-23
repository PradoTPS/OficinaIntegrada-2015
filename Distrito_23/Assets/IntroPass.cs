using UnityEngine;
using System.Collections;

public class IntroPass : MonoBehaviour {

	public GameObject Fade;

	// Use this for initialization
	void Start () {
		StartCoroutine (helloworld());
	}
		
	IEnumerator helloworld(){
		yield return new WaitForSeconds (3);
		Instantiate (Fade);
		yield return new WaitForSeconds (3);
		Application.LoadLevel (0);
	}

}
