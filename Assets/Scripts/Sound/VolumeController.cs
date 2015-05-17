//=======================================================
// VolumeController.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class VolumeController : MonoBehaviour {
//------------------
// Member constant
//------------------

//------------------
// Member variable
//------------------
	public int bgmVolume = 50;
	public int seVolume  = 50;

//------------------
// Member method
//------------------

	//=======================================================
	// Set
	//=======================================================
	public void SetBGMVolume(int value) {
		bgmVolume = value;
	}
	public void SetSEVolume(int value) {
		seVolume = value;
	}

	//=======================================================
	// Get
	//=======================================================
	public float GetBGMVolume () {
		return bgmVolume / 100.0f;
	}
	public float GetSEVolume () {
		return seVolume / 100.0f;
	}
}
