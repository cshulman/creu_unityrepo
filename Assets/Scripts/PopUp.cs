using UnityEngine;
using System.Collections;


public class PopUp : MonoBehaviour {

	public GameObject mySecondCanvas;

	public void Awake()
	{
		if (mySecondCanvas == null)
		{
			mySecondCanvas = GameObject.Find("QuestionCanvas");
			print ("I tried");
			//print (mySecondCanvas.ToString());
		}
	}

    //activate canvas
	public void activateCanvas() {
        mySecondCanvas.SetActive(true);
	}

	//to deactivate window when button is clicked
	public void OnClickButton(string choice) {
        if( choice == "continue") {
            mySecondCanvas.SetActive(false);
            Destroy(mySecondCanvas);
        }
}

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
}





