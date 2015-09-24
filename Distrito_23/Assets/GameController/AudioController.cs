using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

	static bool AudioBegin = false; 

	void Awake(){
		if (!AudioBegin) {
			audio.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}
	
	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
				Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.up, 0.0023f);
				
				if(hit.collider != null)
				switch (hit.transform.gameObject.tag) {
					
					case "SecondaryObject":
						hit.transform.audio.Play();
					
						break;

					case "Bag":
						hit.transform.audio.Play();
					
						break;

					/*case "Floor":
						//GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Mov>().PlayerAudio();

						if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Mov>().isMoving) {
							GameObject.FindGameObjectWithTag("Player").audio.Play ();
						} else {
							GameObject.FindGameObjectWithTag("Player").audio.Stop ();
						}
						break;*/
				}
			} else {
				GameObject.FindGameObjectWithTag("Dialogue").audio.Play ();
			}
		}

		if(Application.loadedLevelName == "Scenes_Playground"){
			audio.Stop();
			AudioBegin = false;
		}
	}
}
