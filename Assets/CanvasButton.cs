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

	public void OnClickButton(string choice) {
        //if( choice == "continue") {
        	Debug.Log("You have clicked the button");
        	//this.gameObject.SetActive(false);
            myQuestionObject.SetActive(false); //TODO!
            PopUp pop = GetComponentInParent<PopUp>();
            pop.DisableCoin();
            //Debug.Log(IsActive);
            //Destroy(myQuestionObject);
       // }
}
}
