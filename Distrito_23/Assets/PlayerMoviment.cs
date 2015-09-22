using UnityEngine;
using System.Collections;

public class PlayerMoviment : MonoBehaviour {

	public float jump;

	void OnMouseDown(){
		GameObject bg = GameObject.FindGameObjectWithTag ("Background");
		bg.transform.position = new Vector2 (bg.transform.position.x + jump, bg.transform.position.y);
		//GameObject.FindGameObjectWithTag ("Background").transform.position = new Vector2 ();
	}
}
