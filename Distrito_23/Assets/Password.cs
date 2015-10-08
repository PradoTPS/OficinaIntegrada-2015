using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Password : MonoBehaviour {

	public GameObject openBank;
	public GameObject speech;
	private GameObject text;

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.up, 0.0023f);

			text = GameObject.Find (gameObject.name + "/Canvas/Text");
			
			if(hit.collider != null){
				switch (hit.transform.gameObject.name) {
					case "1":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "1";
					break;

					case "2":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "2";
					break;

					case "3":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "3";
					break;

					case "4":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "4";
					break;

					case "5":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "5";
					break;

					case "6":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "6";
					break;

					case "7":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "7";
					break;

					case "8":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "8";
					break;

					case "9":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "9";
					break;

					case "0":
						if(text.GetComponent<Text>().text.Length < 4)
							text.GetComponent<Text>().text = text.GetComponent<Text>().text + "0";
					break;

					case "Enter":
						if(text.GetComponent<Text>().text == "2003"){
							Instantiate(openBank);
							Destroy (gameObject);
							Instantiate(speech);
						} else {
							text.GetComponent<Text>().text = null;
						}
					break;

					case "Cancel":       	 
						text.GetComponent<Text>().text = null;
					break;

					case "Out":
						Destroy(gameObject);
					break;
				}
			}
		}
	}
}
