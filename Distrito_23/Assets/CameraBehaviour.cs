using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	public GameObject target;
	public float Start_x;
	public float End_x;

	void Update () {
		float target_x = target.transform.position.x;

		if (target_x < Start_x)
			target_x = Start_x;
		else if (target_x > End_x)
			target_x = End_x;

		Vector3 targetPosition = new Vector3 (target_x, 0, -10); 
		gameObject.transform.position = targetPosition;
	}
}
