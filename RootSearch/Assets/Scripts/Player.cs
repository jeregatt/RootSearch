using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour {


	public float speed = 10f;
	private Rigidbody rig;
	public float threshold;
	// Use this for initialization
	void Start () {

		rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (hAxis, 0, vAxis) * speed * Time.deltaTime;



		rig.MovePosition (transform.position + movement);


		if(Input.GetKey(KeyCode.Space)){
			Vector3 jmp = new Vector3 (0, 6, 0);
			rig.AddForce(jmp * speed);

		}

		if (transform.position.y < threshold)
			transform.position = new Vector3(0, 0, 0);
	}



	void OnTriggerEnter (Collider c)
	{

		if (c.tag == "Obstacle") {
			Destroy (c.gameObject);
		

		}

		if (c.tag == "Win") {
			Destroy (c.gameObject);
			SceneManager.LoadScene ("Finish"); 


		}

	


	}
}
