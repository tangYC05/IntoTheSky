using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {


	float gravityForce = -0.00981f;
	float initialVelocity = 0.4f;
	float xVelocity ;
	float yVelocity ;
	Player player;
	GameObject shooter;

	public static Vector3 ballPosition;

	// Use this for initialization
	void Start () 
	{
		shooter = GameObject.Find("Shooter");
		player = shooter.GetComponent<Player> ();
		xVelocity = initialVelocity * Mathf.Cos (Player.angle_shooter * 3.14f / 180f);
		yVelocity = initialVelocity * Mathf.Sin (Player.angle_shooter * 3.14f / 180f);
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		//Horizontal distance = x=vt
		//Horizontal velocity = x0
		//Vertical distance y=vt-1/2(g*t^2)
		//Vertical Velocity v = v0-gt
		xVelocity = 0.1f;

		yVelocity += gravityForce;

		transform.Translate (Vector2.right * xVelocity);
		transform.Translate (Vector2.up * yVelocity);

		ballPosition.x = transform.position.x;
		ballPosition.y = transform.position.y;
		ballPosition.z = 0f;

		if (Ball.ballPosition.y <= -4.18f) 
		{
			Destroy (gameObject);
		}
	}
}
