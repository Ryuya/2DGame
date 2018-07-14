using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	Rigidbody2D rb;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.W)) {
			rb.velocity = new Vector3 (0f, 1f, 0f);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			rb.velocity = new Vector3 (-1f, 0, 0f);
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			rb.velocity = new Vector3 (0f, -1f, 0f);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			rb.velocity = new Vector3 (1f, 0f, 0f);
		}
	}
}
