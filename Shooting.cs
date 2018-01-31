using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	//the Bullet Emitter
	public GameObject bulletHole;

	//the Bullet
	public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//The Bullet instantiation
			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate(Bullet,bulletHole.transform.position,bulletHole.transform.rotation) as GameObject;

		}

	}
}
