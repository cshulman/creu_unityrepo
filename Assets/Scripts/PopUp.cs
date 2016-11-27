/*
PopUp script sets conditions for pop up question
by setting off all toggles first and setting them to a toggle group so only 1 can be on at a time

PopUp script belongs to Coin and activates canvas when hero collides with coin
PopUp script deactivates the coin

*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PopUp : MonoBehaviour {

	public GameObject myQuestionObject;
	public Text questionText;
	public Toggle choiceA;
	public Toggle choiceB;
	public Toggle choiceC;
	public Toggle choiceD;
	public ToggleGroup questionChoicesGroup;
	public string answer;
	//public Button myButton;

	public void Awake()
	{
		if (myQuestionObject == null)
		{
			myQuestionObject = GameObject.Find("questionCanvas");
			//print (mySecondCanvas.ToString());
			//myQuestionObject = new GameObject(); //Flo did this, not sure why. DK deleted. 
			Debug.Log("In game object find");
		}
		/*if (myQuestionObject == null)
		{
			myQuestionObject = GetComponent("questionCanvas");
			Debug.Log("In find component");
		}*/
		// Button btn = myButton.GetComponent<Button>();
		// btn.onClick.AddListener(OnClickButton);
		questionText.text = "Choose the correct statement to define a 1d array of pointers to double with 10 elements.";
		 //gameObject.enableChildren(false);

		//assign toggle group to all multiple choices
		choiceA.group = questionChoicesGroup;
		choiceB.group = questionChoicesGroup;
		choiceC.group = questionChoicesGroup;
		choiceD.group = questionChoicesGroup;

		//start off with no toggle on
		choiceA.isOn = false;
		choiceB.isOn = false;
		choiceC.isOn = false;
		choiceD.isOn = false;

		answer = "B";
	}

    //activate canvas
	public void activateCanvas() {
        myQuestionObject.SetActive(true);
	}


    //all components have a gameObject they are attached to
    //use gameObject to deactivate coin
    public void DisableCoin()
    {
   	    this.gameObject.SetActive(false);
    }

    public bool verifyAnswer() {
    	return true;
    }

}





