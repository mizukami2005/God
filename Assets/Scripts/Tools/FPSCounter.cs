//=======================================================
// FPSCounter.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class FPSCounter : MonoBehaviour {
//------------------
// Member constant
//------------------
	private const float INTERVAL = 0.5f;

//------------------
// Member variable
//------------------
	private float oldTime;
	private int frame = 0;
	private float frameRate = 0.0f;

//------------------
// Member method
//------------------

	//=======================================================
	// Use this for initialization
	//=======================================================
	void Start () {
		oldTime = Time.realtimeSinceStartup;
	}
	
	//=======================================================
	// Update is called once per frame
	//=======================================================
	void Update () {
		frame++;
		float time = Time.realtimeSinceStartup - oldTime;
		if (time >= INTERVAL)
		{
			frameRate = frame / time;
			oldTime = Time.realtimeSinceStartup;
			frame = 0;
		}
		string strText = "FPS:";
		strText = string.Concat (strText, frameRate.ToString("F2"));
		strText = string.Concat (strText, "\n");
		if(GameObject.FindGameObjectWithTag("DebugController")) {
			GameObject.FindGameObjectWithTag("DebugController").GetComponent<DebugString>().SetDebugStr(0, strText);
		}
	}
}
