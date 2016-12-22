using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3(103,96,36)*Time.deltaTime);
	
	}
}
