using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class myTimer : MonoBehaviour {
	public float countTimer=50;
	private Text timerText;
	private bool timerIsActive=true;

	// Use this for initialization
	void Start () 
	{
		timerText = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (timerIsActive)
		{
			countTimer -= Time.deltaTime;
			timerText.text = "TIMER :" + countTimer.ToString ("f2");
			print (countTimer);
			if (countTimer <= 0) 
			{
				countTimer = 0;
				timerIsActive = false;
				print ("Stop");
			}
		}
	
	}
}
