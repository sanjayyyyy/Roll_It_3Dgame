using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

	public EventSystem eventSystem;
	public GameObject SelectedObject;
	private bool ButtonSelected;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetAxisRaw ("Vertical") != 0 && ButtonSelected == false) 
		{
			eventSystem.SetSelectedGameObject (SelectedObject);
			ButtonSelected = true;
		}
	}
	private void OnDisable()
	{
		ButtonSelected = false;
	}
}
