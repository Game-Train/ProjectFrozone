using UnityEngine;
using System.Collections;

public class TruckController : MonoBehaviour {

	public float speed = 10;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		Vector2 direction = new Vector2 (x, y);

		rb.velocity = speed * direction;

	}
}
