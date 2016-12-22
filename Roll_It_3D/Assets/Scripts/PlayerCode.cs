using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCode : MonoBehaviour {
	private Rigidbody rb;
	public float Speed;
	public int Count;
	public Text countText,winText;
	public myTimer Time;


	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		Count = 0;
		setCount ();
		winText.text=" ";
	}



	//physics calculation code goes here
	void FixedUpdate()
	{
		float move_along_X= Input.GetAxis ("Horizontal");
		float move_along_Z = Input.GetAxis ("Vertical");
	
		rb.AddForce (new Vector3( move_along_X, 0.0f , move_along_Z)*Speed);
	
	}


	//collectable objects code goes here
	void OnTriggerEnter(Collider cube)
	{
		if (cube.gameObject.CompareTag ("pick UP")) 
		{
			cube.gameObject.SetActive (false);
			Count++;
			setCount ();
		}


	}

	//win or lose code goes here
	void setCount()
	{
		countText.text = "COUNT :" + Count.ToString(); 
		if (Count >= 27)
		{
			winText.text = " YOu WInn !!!!";
		} else 
		{
			if((Count<27||Count==0)&&(Time.countTimer==0.00f))
			
			winText.text = " YOu Lose !!!!";
		}
	}
}
