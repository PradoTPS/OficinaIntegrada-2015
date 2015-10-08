using UnityEngine;
using System.Collections;

public class Player_Mov : MonoBehaviour {
	
	private Vector2 startPosition;
	private Vector2 finalPosition;
	private float speed = 2;
	public float minorBound;
	public float majorBound;
	public bool isMoving;
	public bool moveAllowed;
	bool facingRight = true;
	Animator anim;
	
	void Start(){
		anim = GetComponent<Animator> ();
		gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
		if (PlayerPrefs.HasKey(Application.loadedLevelName + "x")) {
			float positionX = PlayerPrefs.GetFloat (Application.loadedLevelName + "x");
			float positionY = PlayerPrefs.GetFloat (Application.loadedLevelName + "y");
			gameObject.transform.position = new Vector2 (positionX, positionY);
		}
	}
	
	void playerMov(){
		if (moveAllowed) {
			Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.up, 0.0023f);
			
			if (!isMoving) {
				startPosition = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y);
					
				isMoving = true;
				anim.SetBool("Mov", true);
			}
			
			if ((hit.collider != null) && (hit.transform.tag == "MoveToObject") || (hit.transform.tag == "Bag") || (hit.transform.tag == "NoteDoor") || (hit.transform.tag == "Door") || (hit.transform.tag == "LockedDoor")){
				finalPosition = new Vector2(hit.transform.gameObject.transform.position.x, startPosition.y);
			} else {
				finalPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				finalPosition = new Vector2(finalPosition.x, finalPosition.y + renderer.bounds.size.y / 2);
			}

			if(finalPosition.x < gameObject.transform.position.x && facingRight){
				Flip();
			}else if(finalPosition.x > gameObject.transform.position.x && !facingRight){
				Flip ();
			}
			
			moveAllowed = false;
			
		} else if (isMoving) { 
			gameObject.transform.position = Vector2.MoveTowards (startPosition, finalPosition, Time.deltaTime * speed);
			startPosition = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y);
		}

		if(startPosition == finalPosition){
			isMoving = false;
			anim.SetBool("Mov", false);
		}else{
			isMoving = true;
		}
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 charScale = transform.localScale;
		charScale.x *= -1;
		transform.localScale = charScale;
	}

	public void PlayerAudio(){
		if (isMoving && gameObject.audio.isPlaying == false) {
			gameObject.audio.Play ();
		} else if(!isMoving){
			gameObject.audio.Stop ();
		}
	}

	void SavePosition(){
		PlayerPrefs.SetFloat(Application.loadedLevelName + "x", gameObject.transform.position.x);
		PlayerPrefs.SetFloat(Application.loadedLevelName + "y", gameObject.transform.position.y);
	}
	
	void FixedUpdate () {
		playerMov ();
		SavePosition ();

		/*if (transform.position.x <= minorBound) {
			transform.position.x = minorBound;
		} else if (transform.position.x <= majorBound) {
			transform.position.x = majorBound;
		}*/
	}

	void OnApplicationQuit(){
		PlayerPrefs.DeleteAll ();
	}
}