using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {
	
	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			
			Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.up, 0.0023f);
			
			if(hit.collider != null)
			switch (hit.transform.gameObject.tag) {
				
				case "SecondaryObject":
					hit.transform.gameObject.audio.Play();
				
					break;
			}
			
		}
	}
}
