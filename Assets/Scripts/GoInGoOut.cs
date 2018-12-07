using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoInGoOut : MonoBehaviour {

	[SerializeField] private float speedX = 1;
	[SerializeField] private float speedY = 1;
	[SerializeField] private float speedZ = 1;
	[SerializeField] private float time;
	float timer = 0;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		timer += Time.deltaTime;
		if (timer > 0 && timer < time/2)
		{
			transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
			return;
		}
		if (timer > time/2 && timer < time)
		{
			transform.Translate(-speedX * Time.deltaTime,  -speedY * Time.deltaTime, -speedZ * Time.deltaTime);
			return;
		}
		timer = 0;
	}
}
