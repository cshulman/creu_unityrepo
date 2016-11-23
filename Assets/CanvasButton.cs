﻿/*
CanvasButton script is used to make questionCanvas -- both question text and answer buttons -- invisible.
*/

using UnityEngine;
using System.Collections;

public class CanvasButton : MonoBehaviour {
	public GameObject myQuestionObject;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	/*
	questionCanvas is disabled when myQuestionObject is disabled 
	because myQuestionObject belongs to questionCanvas

	to disable coin (making it no longer visible), 
	call DisableCoin method of PopUp 
	note that questionCanvas is a child of Coin
	*/
	public void OnClickButton(string choice) {
        //if( choice == "continue") {
        	Debug.Log("You have clicked the button");
            myQuestionObject.SetActive(false); //TODO!
            PopUp pop = GetComponentInParent<PopUp>();
            pop.DisableCoin();
            //Debug.Log(IsActive);
       // }
	}


}