using UnityEngine;
using System.Collections;

public class continuousFade : MonoBehaviour {

	public float fadeSpeed;
	public string fadeTo;
	private float alpha = 1;
	private Color goColor;

	private void verify(){
		if (alpha >= 1) {
			alpha = 1;
			fadeTo = "Black";
		} else if (alpha <= 0) {
			alpha = 0;
			fadeTo = "Clear";
		}
	}

	void Update () {

		verify ();

		if (fadeTo == "Clear") {
			alpha += fadeSpeed; 
		} else if (fadeTo == "Black"){
			alpha -= fadeSpeed;
		}

		goColor = new Color (255, 255, 255, alpha);
		gameObject.GetComponent<SpriteRenderer> ().color = goColor;
	}
}
