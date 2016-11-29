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
	public Text feedbackText;
	public Toggle choiceA;
	public Toggle choiceB;
	public Toggle choiceC;
	public Toggle choiceD;
	public ToggleGroup questionChoicesGroup;
	public string answer;
	public string CORRECT = "correct";
	public string INCORRECT = "incorrect";
	public string NO_ANSWER = "no answer given";
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

		//no feedback to begin with
		feedbackText.text = " ";
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

    public string verifyAnswer() {
    	Debug.Log("Which toggles are on:");
    	Debug.Log("choiceA on? " + choiceA.isOn);
    	Debug.Log("choiceB on? " + choiceB.isOn);
    	Debug.Log("choiceC on? " + choiceC.isOn);
    	Debug.Log("choiceD on? " + choiceD.isOn);
    	if(choiceA.isOn == true && answer == "A"){
    		return CORRECT;
    	} else if(choiceA.isOn == true && answer != "A"){
    		return INCORRECT;
    	} else if(choiceB.isOn == true && answer == "B"){
    		return CORRECT;
    	} else if (choiceB.isOn == true && answer != "B"){
    		return INCORRECT;
    	} else if(choiceC.isOn == true && answer == "C"){
    		return CORRECT;
    	} else if(choiceC.isOn == true && answer != "C"){
    		return INCORRECT;
    	} else if(choiceD.isOn == true && answer == "D"){
    		return CORRECT;
    	} else if(choiceD.isOn == true && answer != "D"){
    		return INCORRECT;
    	} else {
    		//no answer was chosen
    		return NO_ANSWER;
    	}
    }
   
    //if wrong answer is given, turn off all toggles to try again
    public void wrongAnswer(){
    	feedbackText.text = "Wrong. Try again.";
    	choiceA.isOn = false;
		choiceB.isOn = false;
		choiceC.isOn = false;
		choiceD.isOn = false;
    }

    public void noAnswer(){
    	feedbackText.text = "You must submit an answer.";
    }

}






