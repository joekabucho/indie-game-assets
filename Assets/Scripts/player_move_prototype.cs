using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move_prototype : MonoBehaviour {
	 public int playerSpeed = 10;
	 private bool facingRight = true;
	 public int playerJumpPower = 1250;
     private float moveX;
	// Use this for initialization
	public bool isGround ;
	
	// Update is called once per frame
	void Update () {
		PlayerMove();
	}
	void PlayerMove()
	{
		//CONTROL
      moveX=Input.GetAxis("Horizontal");
	  if(Input.GetButtonDown ("Jump")&& isGround==true ){
		  Jump();
	  }
		//ANIMATION
		//P
		if (moveX<0.0f && facingRight ==false){
			FlipPlayer();
		}
		else if  (moveX>0.0f && facingRight ==true){
			FlipPlayer();
		}
		//PHYSICS
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed,gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}
	void Jump()
	{
        //jump code
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
		isGround=false;
	}
	void FlipPlayer()
	{
       facingRight=!facingRight;
	   Vector2 localScale = gameObject.transform.localScale;
	   localScale.x*=-1;
	   transform.localScale=localScale;
	}
void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log("player has collided with" + col.collider.name);
		if (col.gameObject.tag=="ground"){
			isGround=true;
		}
	}
}
