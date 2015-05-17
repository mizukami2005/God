//=======================================================
// Common.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class Common {
//------------------
// Common structure
//------------------	
	public struct Point {
		public int x, y;
		
		// Constructor:
		public Point(int x, int y) {
			this.x = x;
			this.y = y;
		}
		// Override the ToString merhod:
		public override string ToString() {
			return(string.Format("({0},{1})", x, y));
		}
	};
	
//------------------
// Common method
//------------------
	
	//=======================================================
	// Instantiate GUI object
	//=======================================================
	static public GameObject InstantiateGUI (string guiName) {
		GameObject guiObj = GameObject.Instantiate (Resources.Load ("Prefabs/GUI/" + guiName)) as GameObject;
		guiObj.name = guiName;
		return guiObj;
	}

	//=======================================================
	// Is Collider2D hit
	//=======================================================
	static public bool Collider2DHit(GameObject obj1, GameObject obj2) {
		Vector3 pos1 = obj1.transform.position;
		Vector3 pos2 = obj2.transform.position;
		Vector3 col1 = obj1.GetComponent<Collider2D> ().bounds.extents;
		Vector3 col2 = obj2.GetComponent<Collider2D> ().bounds.extents;
		if(pos1.x - col1.x <= pos2.x + col2.x &&
		   pos1.x + col1.x >= pos2.x - col2.x &&
		   pos1.y - col1.y <= pos2.y + col2.y &&
		   pos1.y + col1.y >= pos2.y - col2.y) {
			return true;
		}
		return false;
	}	
}