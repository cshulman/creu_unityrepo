using UnityEngine;
using System.Collections;

public class ProbabilityManager : MonoBehaviour {
	public int maxQuestPerLevel;
	public int maxFactPerLevel;
	//note that question = 0 and fact =1
	public enum PopUpType { QUESTION, FACT};



	// Use this for initialization
	void Start () {
		maxQuestPerLevel = 10;
		maxFactPerLevel = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*
	method returns PopUp type: fact or question
	TODO: first time should never be question
	*/
	public PopUpType getPopUpType() {
		
		int popUpType = Random.Range (0, 5);

		if (popUpType < 2) {
			
			PopUp pop = GetComponentInParent<PopUp> ();
			pop.activateCanvas ();
			return PopUpType.QUESTION;
			
		} else {
			
			PopUpFact factpop = GetComponentInParent<PopUpFact>();
			factpop.activatePopUpFact();
			return PopUpType.FACT;
		}


	}
}
