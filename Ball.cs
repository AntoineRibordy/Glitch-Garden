using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 paddleToBallPosition;
	private bool hasStarted = false;
	private Rigidbody2D ballBody; 
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		paddleToBallPosition = this.transform.position - paddle.transform.position;
		ballBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			// Keep ball on paddle at the start of the game
			this.transform.position = paddle.transform.position + paddleToBallPosition;

			// Wait for a mouse button click to launch
			if (Input.GetMouseButtonDown (0)) {
				hasStarted = true;
				ballBody.velocity = new Vector2 (2f, 10f);
			}
		}
	}
	void OnCollisionEnter2D (Collision2D collider)
	{
		AudioSource audioSource = GetComponent<AudioSource> ();
		Vector2 tweak = new Vector2 (Random.Range (0f, 0.2f), Random.Range (0f, 0.2f));
		if (hasStarted) {
			ballBody.velocity += tweak;
			audioSource.Play ();
		}
	}
}
