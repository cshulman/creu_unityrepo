using UnityEngine;
using System.Collections;

public class ProbabilityManager : MonoBehaviour {
	public int maxQuestPerLevel;
	public int maxFactPerLevel;
	//note that question = 0 and fact =1
	public enum PopUpType { QUESTION, FACT};
	//prob * 10 = %
	public int QUESTIONPROB = 6;
	public int FACTPROB = 4;
	public bool firstCoin;



	// Use this for initialization
	void Start () {
		maxQuestPerLevel = 10;
		maxFactPerLevel = 10;
		firstCoin = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*
	method returns PopUp type: fact or question
	TODO: first time should never be question
	*/
	public PopUpType getPopUpType() {
		
		int popUpType = Random.Range (1, 10);

		if (popUpType > 4 && popUpType < 11) {
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
