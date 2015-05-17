//=======================================================
// DestroyMe.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class DestroyMe : MonoBehaviour {
//------------------
// Member constant
//------------------

//------------------
// Member variable
//------------------
	public bool   destroyParent;
	public float  destroyTime;
	public bool   disableDestroyTime;

//------------------
// Member method
//------------------

	//=======================================================
	// Use this for initialization
	//=======================================================
	void Start () {
		if (disableDestroyTime) {
			return;
		}
		if(destroyParent) {
			Destroy(transform.parent.gameObject, destroyTime);
		}
		Destroy(gameObject, destroyTime);
	}
	
	//=======================================================
	// Update is called once per frame
	//=======================================================
	void Update () {
	}

	//=======================================================
	// Destroy
	//=======================================================
	void DestroyObject() {
		if(destroyParent) {
			Destroy (transform.parent.gameObject);
		}
		Destroy (gameObject);
	}
}
