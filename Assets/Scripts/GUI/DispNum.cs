//=======================================================
// DispNum.cs
//=======================================================
using UnityEngine;
using System.Collections;

public class DispNum : MonoBehaviour {
//------------------
// Member constant
//------------------
	
//------------------
// Member variable
//------------------
	[SerializeField]private Sprite[] Numbers;		// Numbers sprite
	
	[SerializeField]private int  maxDigit;			// Display digit
	[SerializeField]private bool isZeroInsert;		// If not use digit is  
													//	 True: Zero into digit
													//	False: Don't show digit

//------------------
// Member method
//------------------

	//=======================================================
	// Showing numbers
	//=======================================================
	public void ShowNum(int num) {
		int mod = 10;
		int divid = 1;
		for (int i = 0; i < maxDigit; i ++) {
			// Get target object
			SpriteRenderer target = gameObject.transform.FindChild("Digit_"+divid).GetComponent<SpriteRenderer>();
			target.enabled = true;

			// If not use digit is
			if(num < divid) {
				// Zero into digit
				if(isZeroInsert || (i == 0 && num == 0)) {
					target.sprite  = Numbers[0];
				}
				// Don't show digit
				else {
					target.enabled = false;
				}
				// Prepare to next
				mod *= 10;
				divid *= 10;
				continue;
			}

			// Calclation
			int shownum = num % mod;
			shownum /= divid;

			// Showing 'shownum' to digit
			target.sprite = Numbers[shownum];

			// Prepare to next
			mod *= 10;
			divid *= 10;
		}
	}
}
