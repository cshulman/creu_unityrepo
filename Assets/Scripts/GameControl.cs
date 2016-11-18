/*
GameControl script is meant to store score data which we want to preserve throughout the game

this is achieved by attaching this script to a GameObject
this GameObject is then added to the first scene that has the data we want to store

there should only be one (static) instance of this class
this instance should not be destroyed on load

Then you can reference it in another scene using NameOfClass.NameOfInstance.NameOfFunction
*/
using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public static GameControl Instance;

	//sets of data to persist throughout game
	public int score;

	// // Use this for initialization
	void Start () {
		Debug.Log("GameControl is started");
		score = 0;
	}

	//called before component is enabled
	//ensure that this instance is not destroyed on load
	void Awake() {
		Debug.Log("GameControl is awake");
		if (Instance == null) {
			DontDestroyOnLoad (gameObject);
			Instance = this;
		} else {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setScore(int n)
	{
		score = n;
	}

	public void increaseScore (int n)
	{
		score += n;
	}

	public int getScore()
	{
		return score;
	}
}








	

