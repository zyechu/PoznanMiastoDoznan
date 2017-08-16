using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {

	public string buttonName = "Fire1";
	public float forceAmount = 10.0f;
	public float torqueAmount = 10.0f;
	public ForceMode forceMode; 
	public Rigidbody rb;
    

	void Update () {
		rb = GetComponent<Rigidbody>();

		if(Input.GetButtonDown(buttonName))
			{
			rb.AddForce (Random.onUnitSphere * forceAmount, forceMode);
			rb.AddTorque (Random.onUnitSphere * torqueAmount, forceMode);
		}
		
	}

   
}
