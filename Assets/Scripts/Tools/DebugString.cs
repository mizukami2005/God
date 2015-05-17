//=======================================================
// DebugString.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class DebugString : MonoBehaviour {
//------------------
// Member constant
//------------------

//------------------
// Member variable
//------------------
	[SerializeField]private int maxStr; 
	private string[] debugStr;

//------------------
// Member method
//------------------

	//=======================================================
	// Use this for initialization
	//=======================================================
	void Start () {
		Initialize ();
	}

	//=======================================================
	// Initialize
	//=======================================================
	void Initialize () {
		debugStr = new string[maxStr];
		for(int i = 0; i < maxStr; i ++) {
			debugStr[i] = "";
		}
	}
	
	//=======================================================
	// Set - debugStr
	//=======================================================
	public void SetDebugStr(int strNo, string strTxt) {
		debugStr[strNo] = strTxt;
	}

	//=======================================================
	// OnGUI
	//=======================================================
	void OnGUI () {
		string dispStr = "";
		for(int i = 0; i < maxStr; i ++) {
			dispStr = string.Concat(dispStr, debugStr[i]);
		}
		GUI.Label(new Rect(0, 0, Screen.width, Screen.height), dispStr);
	}
}
