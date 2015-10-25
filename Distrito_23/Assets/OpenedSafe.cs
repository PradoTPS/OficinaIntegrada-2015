using UnityEngine;
using System.Collections;

public class OpenedSafe : MonoBehaviour {
	
	void Start () {
		PlayerPrefs.SetString("hasTakenBag", "true");
	}
}
