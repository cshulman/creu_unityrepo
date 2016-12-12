using UnityEngine;
using System.Collections;

public class PauseResumeButtons : MonoBehaviour {
	bool isPaused;

	// Use this for initialization
	void Start () {
		isPaused = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PauseGame(){
		if(!isPaused){
			isPaused = true;
			Time.timeScale = 0.0f;
		}
	}

	public void ResumeGame(){
		if(isPaused){
			isPaused = false;
			Time.timeScale = 1.0f;
		}
	}

}
