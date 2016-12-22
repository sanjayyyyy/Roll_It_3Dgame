using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	private Vector3 offset;
	public GameObject Player;


	// Use this for initialization
	void Start ()
	{
		offset = transform.position - Player.transform.position;
	
	}


	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Player.transform.position + offset;
	
	}
}
