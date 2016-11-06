using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	public static int score;
	public int level;

	


	// Use this for initialization
	void Start () 
	{
		Debug.Log("in ScoreKeeper's awake");
		score = 0;
		level = 1;

		ScoreUpdate obj = GetComponent<ScoreUpdate>();
		obj.scoreText.text = "Score: " + score;
		Debug.Log(SceneManager.GetActiveScene().name);
	}

	public void GotCoin()
	{
		Debug.Log("in GotCoin");
		Debug.Log(SceneManager.GetActiveScene().name);

		//score++;

		ScoreUpdate obj = GetComponent<ScoreUpdate>();
		obj.scoreText.text = "Score: " + score;

		Debug.Log("Score: " + score);
		Debug.Log(SceneManager.GetActiveScene().name);

		//check if need to level up, if score is greater or equal to 10
		if (score >= 10) 
		{
			//reset score
			score = 0;

			//increment level
			level++;
			Debug.Log("Level: " + level);

			//if level is not greater than 4
			if (level <= 4) 
			{
				//load the next level
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
				Debug.Log(score);
				Debug.Log("in GotCoin stmt after loading new scene");
				//TODO Display on top right or left LEVEL (level)
			}

			//TODO if level is 4 (or greater just in case) 
			//Display Game Over/ You Won etc.
			//end scene etc
		}

		
		
	}

}