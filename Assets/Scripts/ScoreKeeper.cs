using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	public int score;
	public int level;

	//[SerializeField] 
	public GUIText scoreText;

	// Use this for initialization
	void Start () 
	{
		score = 0;
		level = 1;
		scoreText.text = "Score : 0";

	}
	public void GotCoin()
	{
		score++;
		Debug.Log("Score: " + score);
		scoreText.text = "Score: " + score;

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
				//TODO Display on top right or left LEVEL (level)
			}

			//TODO if level is 4 (or greater just in case) 
			//Display Game Over/ You Won etc.
			//end scene etc
		}
	}

}