using UnityEngine;
using System.Collections;


public class Coin : MonoBehaviour {

	//for now, all coins give player 1 point!
	public int COINVALUE = 1;

	// Use this for initialization
	void Start () {
		//GameObject canvas = GetComponent<questionCanvas>();
		//canvas.enabled = false;

		// if (questionPopUp == null)
		// {
		// 	questionPopUp = GetComponent<PopUp>();
		// }
		// if (questionPopUp == null)
		// {
		// 	print ("null popup");
		// }
	}
	
	// Update is called once per frame
	// void Update () {
	
	// }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{   
			ProbabilityManager probManager = GetComponentInParent<ProbabilityManager>();
			ProbabilityManager.PopUpType popType = probManager.getPopUpType();
			//only increase score if got question
			if( popType == ProbabilityManager.PopUpType.QUESTION ){
				other.GetComponent<ScoreKeeper>().GotCoin (COINVALUE);
			}
			
			


			//Destroy(questionPopUp);
			//this.gameObject.SetActive(false);
		}
	}		
}
