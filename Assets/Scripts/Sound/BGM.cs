//=======================================================
// BGM.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class BGM : MonoBehaviour {
//------------------
// Member constant
//------------------

//------------------
// Member variable
//------------------
	
//------------------
// Member method
//------------------
	
	//=======================================================
	// Sound effect play
	//=======================================================
	public void Play() {
		gameObject.GetComponent<AudioSource> ().enabled = false;

		// Volume set
		float volume = GameObject.FindGameObjectWithTag ("GameController").GetComponent<VolumeController> ().GetBGMVolume ();
		gameObject.GetComponent<AudioSource> ().volume = volume;
		gameObject.GetComponent<AudioSource> ().enabled = true;
	}

	//=======================================================
	// Stop
	//=======================================================
	public void Stop() {
		gameObject.GetComponent<AudioSource> ().enabled = false;
	}
}
