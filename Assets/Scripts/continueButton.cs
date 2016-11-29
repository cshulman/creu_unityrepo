/*
continueButton script is used to make the educational fact canvas invisible.
*/
using UnityEngine;
using System.Collections;

public class continueButton : MonoBehaviour {
	public GameObject eduFactObject;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	/*
	eduFactCanvas is disabled when eduFactObject is disabled 
	because eduFactObject belongs to eduFactCanvas

	to disable coin (making it no longer visible), 
	call DisableCoin method of PopUp 
	note that questionCanvas is a child of Coin
	*/
	public void OnClickContinue() {
        	Debug.Log("You have clicked the continue button");
        	eduFactObject.SetActive(false);
	}

}
