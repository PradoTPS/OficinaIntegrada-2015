using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBoxBehaviour : MonoBehaviour {

	public string[] texts;
	public string who;
	public GameObject instantiateNext;
	private GameObject text;
	private GameObject character;
	private int currentText = 0;

	void Start(){
		gameObject.transform.SetParent (Camera.main.transform);
	}

	void textChange(){
		if (Input.GetMouseButtonDown (0)) {
			currentText++;
		}
	}

	void Update () {

		textChange ();

		if (currentText == texts.Length) {
			Destroy (gameObject);
			currentText --;
			if(instantiateNext != null){
				Instantiate(instantiateNext);
			}
		}

		character = GameObject.Find (gameObject.name + "/Canvas/Speaking");
		character.GetComponent<Text> ().text = who;

		text = GameObject.Find (gameObject.name + "/Canvas/Text");
		text.GetComponent<Text> ().text = texts[currentText];
	}
}
