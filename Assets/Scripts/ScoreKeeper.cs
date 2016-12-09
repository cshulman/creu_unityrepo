
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
	
	int targetScore;
	int index;

	public Text scoreText;


	// Use this for initialization
	void Start () 
	{
		Debug.Log("in ScoreKeeper's start");

		index = SceneManager.GetActiveScene ().buildIndex;
		targetScore = 10;
		//targetScore = 10 * (index + 1);
		Debug.Log("index + 1: " + (index +1));
		Debug.Log("targetScore: " + targetScore);

		scoreText.text = "Score: " + GameControl.Instance.getScore();
	}

	//function increases score
	public void GotCoin(int coinValue)
	{
		Debug.Log("in GotCoin");

		//increment score and display
		GameControl.Instance.increaseScore (coinValue);
		int score = GameControl.Instance.getScore ();
		scoreText.text = "Score: " + score;
		Debug.Log("Score: " + score);

		//level up if got 10 points on current level
		if (score >= targetScore) 
		{
			targetScore -= 10;
			Debug.Log("Level up!");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			//TODO Display on top right or left LEVEL (level)
			
			//TODO if level is 4 (or greater just in case) 
			//Display Game Over/ You Won etc.
			//end scene etc
		}
	}

}