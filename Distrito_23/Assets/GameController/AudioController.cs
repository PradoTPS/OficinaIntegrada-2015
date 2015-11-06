using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

	static bool AudioBegin = false;
	static bool PlayingTheme;
	private bool changed = false;
	public AudioClip themeMusic;

	void Awake(){
		if (!AudioBegin) {
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
			audio.Play ();
		}
	}

	void FixedUpdate(){
		if (Input.GetMouseButtonDown (0)) {
			if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
				Vector2 ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				RaycastHit2D hit = Physics2D.Raycast (ray, Vector2.up, 0.0023f);
				
				if (hit.collider != null) {
					switch (hit.transform.gameObject.tag) {
					
					case "SecondaryObject":
						hit.transform.audio.Play ();
					
						break;

					case "MoveToObject":
						if(hit.collider.GetComponent<OpenDialogue>().inside == true){
							hit.transform.audio.Play ();
						}
						
						break;

					case "Bag":
						if(hit.collider.GetComponent<OpenDialogue>().inside == true){
							hit.transform.audio.Play ();
						}
					
						break;
					}
				} 

			} else {
				GameObject.FindGameObjectWithTag ("Dialogue").audio.Play ();
			}
		}

		try{
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Player_Mov> ().PlayerAudio ();
		} catch {
		}

		if (Application.loadedLevelName == "Scenes_Playground" && !changed) {
			ChangeMusic (themeMusic, 0.3f);
			changed = true;
		}
		if (Application.loadedLevelName == "OpenScene") {
			changed = false;
			Destroy (gameObject);
		}
	}

	void ChangeMusic(AudioClip music, float volume){
		audio.clip = music;
		audio.volume = volume;
		audio.Play ();
	}
}
