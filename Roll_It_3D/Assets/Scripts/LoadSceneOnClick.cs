using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {


	//Load scene based on index
	public void LoadByIndex(int SceneIndex)
	{
		SceneManager.LoadScene (SceneIndex);
	}


	}

