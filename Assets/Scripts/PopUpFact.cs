using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopUpFact : MonoBehaviour {

	public GameObject myFactObject;
	public Text didYouKnow;
	public Text factText;

	// Use this for initialization
	void Start () {
	
	}

	void Awake() {
		didYouKnow.text = "Did you know...";
		factText.text = "pointers are magical!";

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void activatePopUpFact() {
		Time.timeScale = 0.0f;
		myFactObject.SetActive(true);

	}
}
