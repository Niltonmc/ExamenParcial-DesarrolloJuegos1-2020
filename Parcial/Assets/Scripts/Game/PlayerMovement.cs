using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
	[HideInInspector]
    private Rigidbody2D rbPlayer;

	[Header("Movement Variables")]
	public float speedXMovement;

	[Header("Position Variables")]
	public float minPosX;
	public float maxPosX;
	private float currentXPos;
    void Start(){
		rbPlayer = GetComponent<Rigidbody2D> ();
	}

    void FixedUpdate(){

		currentXPos = Mathf.Clamp(transform.position.x, minPosX, maxPosX);
		transform.position = new Vector2(currentXPos,transform.position.y);

		if (Input.GetKey (KeyCode.A)) {
			rbPlayer.velocity = new Vector2 (-speedXMovement, 0);

		} else if (Input.GetKey (KeyCode.D)) {
			rbPlayer.velocity = new Vector2 (speedXMovement, 0);

		} else {
			rbPlayer.velocity = new Vector2 ();
		}
	}
}
