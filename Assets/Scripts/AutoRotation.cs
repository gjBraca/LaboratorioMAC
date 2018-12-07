using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour 
{
	[SerializeField] private float speedX = 1;
	[SerializeField] private float speedY = 1;
	[SerializeField] private float speedZ = 1;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		//transform.Rotate(Vector3.up * speed * Time.deltaTime);
		transform.Rotate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
	}
}
