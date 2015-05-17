//=======================================================
// FPSSet.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class FPSSet : MonoBehaviour {
//------------------
// Member variable
//------------------
	[SerializeField]
	private int FPS;

//------------------
// Member method
//------------------

	//=======================================================
	// Change project settings
	//=======================================================
	void Awake() {
		Application.targetFrameRate = FPS;
		Destroy (this);
	}
}
