//=======================================================
// SE.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class SE : MonoBehaviour {
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
		float volume = GameObject.FindGameObjectWithTag ("GameController").GetComponent<VolumeController> ().GetSEVolume ();
		gameObject.GetComponent<AudioSource> ().volume = volume;
		gameObject.GetComponent<AudioSource> ().enabled = true;
	}

	//=======================================================
	// Sound effect stop
	//=======================================================
	public void Stop() {
		gameObject.GetComponent<AudioSource> ().enabled = false;
	}
}
