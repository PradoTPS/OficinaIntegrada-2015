using UnityEngine;
using System.Collections;

public class FinalScene : MonoBehaviour {
	
	public GameObject Fade;

	void Start(){
		PlayerPrefs.DeleteAll();
	}
	
	void Update (){
		if(Input.anyKey)
			StartCoroutine (helloworld());
	}
	
	IEnumerator helloworld(){
		Instantiate (Fade);
		yield return new WaitForSeconds (3);
		Application.LoadLevel (0);
	}
	
}
