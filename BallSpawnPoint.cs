using UnityEngine;
using System.Collections;

public class BallSpawnPoint : MonoBehaviour {

	Player player;
	GameObject shooter;

	// Use this for initialization
	void Start () 
	{
		shooter = GameObject.Find("Shooter");
		player = shooter.GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.position = new Vector2 (  
			-4.8f+Mathf.Cos (Player.angle_shooter * 3.14f / 180f),
			-3.267f+Mathf.Sin (Player.angle_shooter * 3.14f / 180f));
	}
}
