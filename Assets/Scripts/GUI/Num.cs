//=======================================================
// Num.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class Num : MonoBehaviour {
//------------------
// Member constant
//------------------
	
//------------------
// Member variable
//------------------
	[SerializeField]private int num;		// Now numbers
	[SerializeField]private int maxNum;		// Maximam numbers
	[SerializeField]private int minNum;		// Mimimum numbers
	[SerializeField]private bool isLoop;	// Value to loop

//------------------
// Member method
//------------------
	
	//=======================================================
	// Use this for initialization
	//=======================================================
	void Start () {
		transform.FindChild ("DispNum").GetComponent<DispNum>().ShowNum (num);
	}

	//=======================================================
	// Setting numbers to variable
	//=======================================================
	public void SetNum(int newNum) {
		num = newNum;
		if (num > maxNum) {
			num = maxNum;
		}
		if (num < minNum) {
			num = minNum;
		}
		transform.FindChild ("DispNum").GetComponent<DispNum>().ShowNum (num);
	}

	//=======================================================
	// Addition num to numbers
	//=======================================================
	public void AddNum(int addNum) {
		num += addNum;
		if (num > maxNum) {
			if (isLoop) { num = minNum + (num - maxNum - 1); }
			else 		{ num = maxNum; }
		}
		if (num < minNum) {
			if (isLoop) { num = maxNum - (minNum - num - 1); }
			else 	    { num = minNum; }
		}
		transform.FindChild ("DispNum").GetComponent<DispNum>().ShowNum (num);
	}

	//=======================================================
	// Getting numbers
	//=======================================================
	public int GetNum() {
		return num;
	}
}
