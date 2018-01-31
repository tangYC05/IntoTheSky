using UnityEngine;
using System.Collections;

public class TargetSpawning : MonoBehaviour {

	public GameObject target;
	int maxCount = 1;
	int count = 0;
	public Ball ball;
	public static Vector3 maxSide;
	public static Vector3 minSide;

	// Use this for initialization
	void Start () 
	{
		
	}

	void targetSpawn ()
	{
		//Random generate x and y
		float xRand = Random.Range(-3, 3);
		float yRand = Random.Range (-3,3);
		transform.position = new Vector3 (xRand, yRand);

		//spawn target
		Instantiate(target,transform.position,transform.rotation);
	
		maxSide.x = transform.position.x + 0.166f;
		maxSide.y = transform.position.y + 0.166f;
		minSide.x = transform.position.x - 0.166f;
		minSide.y = transform.position.y - 0.166f;

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		while( count < maxCount)
		{
			targetSpawn ();
			count++;
		}
	}
}
