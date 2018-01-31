using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public static float angle_shooter;
	public float rotateSpeed = 0.1F;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		//|| transform.eulerAngles == new Vector3(0,0,80))
		{
			//Rotate cannon angle up
			if (Input.GetKey ("up")) 
			{
				if (transform.eulerAngles.z <= 80) 
				{
					transform.Rotate (Vector3.forward, rotateSpeed);
				}	
			}

				//Rotate cannon angle down
				if (Input.GetKey ("down")) 
				{
					if (transform.eulerAngles.z >= 0.1) 
					{
						transform.Rotate (Vector3.back, rotateSpeed);
					}
				}

			angle_shooter = transform.eulerAngles.z;
			}
		}
}
	