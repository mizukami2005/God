//=======================================================
// ResetBtn.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class ResetBtn : MonoBehaviour {
//------------------
// Member variable
//------------------
	public string sceneName;

//------------------
// Member method
//------------------

	//=======================================================
	// OnGUI
	//=======================================================
	void OnGUI () {
		if (GUI.Button (new Rect(Screen.width - Screen.width / 4, 0, Screen.width / 4, Screen.height / 8), "Reset")) {
			Application.LoadLevel(sceneName);
		}
	}
}
