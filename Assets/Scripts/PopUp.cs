using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PopUp : MonoBehaviour {

	public GameObject myQuestionObject;
	public Text questionText;
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
		questionText.text = "My question goes here!";
		 //gameObject.enableChildren(false);

	}

    //activate canvas
	public void activateCanvas() {
        myQuestionObject.SetActive(true);
	}

	//shoud be called when button is clicked
	//to deactivate window when button is clicked
	/*public void OnClickButton(string choice) {
        //if( choice == "continue") {
        	Debug.Log("You have clicked the button");
        	//this.gameObject.SetActive(false);
            //myQuestionObject.SetActive(false);
            //Debug.Log(IsActive);
            //Destroy(myQuestionObject);
       // }*/
//}

	// public Rect windowRect = new Rect(200, 100, 500, 300);

 //    void OnGUI() {
 //        windowRect = GUI.Window(0, windowRect, DoMyWindow, "My Window");
 //    }

 //    void DoMyWindow(int windowID) {
 //        if (GUI.Button(new Rect(200, 100, 500, 300), "Hello World"))
 //            print("Got a click");
        
 //    }

	// // Use this for initialization
	// void Start () {
	
	// }
	
	// // Update is called once per frame
	// void Update () {
	
	// }
     public void DisableCoin()
     {
     	this.gameObject.SetActive(false);
     }
}





