﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	/*private string itemHeld = null;
	private bool hldnItem = false;
	private bool carry = false;*/

	void Update(){
		if (Input.GetMouseButtonDown (0)) {

			Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.up, 0.0023f);

			if(hit.collider != null)
				switch (hit.transform.gameObject.tag) {
					
				/*case "Item":
					if(!hldnItem){
						hit.transform.gameObject.GetComponent<ItemBehaviour>().itemCheck();
						itemHeld = hit.transform.gameObject.GetComponent<ItemBehaviour>().itemName;
						hldnItem = true;
					} else {
						GameObject.FindGameObjectWithTag("Item").GetComponent<ItemBehaviour>().itemCheck();
						carry = true;
					}
					
					break;*/

				case "Floor":
					/*if(GameObject.FindGameObjectsWithTag("EmptySlot")[0].GetComponent<ChildVerifier>().hasChild == true){
						if(GameObject.FindGameObjectWithTag("Item").GetComponent<ItemBehaviour>().followMouse == false){
							GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Mov>().moveAllowed = true;
						} else {
							GameObject.FindGameObjectWithTag("Item").GetComponent<ItemBehaviour>().itemCheck();
							hldnItem = false;
							carry = false;
						}
					} else {*/
					if (GameObject.FindGameObjectWithTag ("Dialogue") == null) {
						GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Mov>().moveAllowed = true;
					}
					//}
					
					break;

				case "MoveToObject":
					GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Mov>().moveAllowed = true;
					break;

				case "Bag":
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Mov>().moveAllowed = true;
					break;

				case "Note":
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Mov>().moveAllowed = true;
					break;
				}
		}
	}
}