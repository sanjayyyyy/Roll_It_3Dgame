using UnityEngine;
using System.Collections;

public class QuitOnClick : MonoBehaviour {


	//exiting from play mode And from build mode
	public void Quit()
	{
	
		#if UNITY_EDITOR
		    UnityEditor.EditorApplication.isPlaying=false;
		#else 
		    Application.Quit();
		#endif
	}
}
