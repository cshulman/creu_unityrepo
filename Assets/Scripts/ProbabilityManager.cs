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
	public void getPopUpType() {
		/*if question
		PopUp pop = GetComponentInParent<PopUp>();
		pop.ActivateCanvas();
		*/
		//if fact 
		PopUpFact factpop = GetComponentInParent<PopUpFact>();
		factpop.activatePopUpFact();
	}
}
