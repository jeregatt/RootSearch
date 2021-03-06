using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	//The speed set for the ball to move is 10.
	public float speed = 10f;
	//The variable rig is called for rigidbody attached to the player.
	private Rigidbody rig;
	//The variable threashold is called for the player. The player is restricted to start the game again from the starting position.
	public float threshold;


	// Use this for initialization
	void Start () {

		rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		//The player can move either horizontally or vertically.
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (hAxis, 0, vAxis) * speed * Time.deltaTime;



		rig.MovePosition (transform.position + movement);

		//If the player hits the Spacebar key from the keyboard, the player will be able to jump.
		if(Input.GetKey(KeyCode.Space)){
			Vector3 jmp = new Vector3 (0, 6, 0);
			rig.AddForce(jmp * speed);

		}
		//If the player falls from the playing floor, he will start the game again, the ball will start again from the starting point.
		if (transform.position.y < threshold)
			transform.position = new Vector3(0, 0, 0);
	}



	void OnTriggerEnter (Collider c)
	{

		if (c.tag == "Obstacle") {
			Destroy (c.gameObject);
		

		}

		//The Finish screen will appear if the player hit the finish house , which is tagged as Win.
		if (c.tag == "Win") {
			Destroy (c.gameObject);
			SceneManager.LoadScene ("Finish"); 


		}

	}
}
