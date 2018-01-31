using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Ball.ballPosition.x <= TargetSpawning.maxSide.x &&
			Ball.ballPosition.x >= TargetSpawning.minSide.x) 
		{
			if (Ball.ballPosition.y <= TargetSpawning.maxSide.y &&
				Ball.ballPosition.y >= TargetSpawning.minSide.y) 
			{
				Destroy(gameObject);
			}
		}
			
	}
}
