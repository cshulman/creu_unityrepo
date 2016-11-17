
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
	public int score;
	public int level;
	public int targetScore;
	public Text scoreText;


	// Use this for initialization
	void Start () 
	{
		Debug.Log("in ScoreKeeper's start");

		score = GameControl.Instance.getScore();
		level = GameControl.Instance.getLevel();
		if(level == 0){
			GameControl.Instance.setLevel(1);
			level = 1;
		}
		Debug.Log("Starting Level: " + level);
		targetScore = score + 10;
		Debug.Log("targetScore: " + targetScore);
		
		if (scoreText == null)
			{print ("NULL");}
		/*GameObject g = GameObject.Find("scoreText");
		if (g == null)
		{
			print("g is also null!");
		}*/
		scoreText.text = "Score: " + score;
	}

	public void GotCoin()
	{
		Debug.Log("in GotCoin");

		//increment score and display
		score++;
		GameControl.Instance.setScore(score);
		scoreText.text = "Score: " + score;
		Debug.Log("Score: " + score);

		//check if need to level up, if score is greater or equal to 10
		if (score >= targetScore) 
		{
			//increment level and display
			level++;
			GameControl.Instance.setLevel(level);
			Debug.Log("Level up!");
			Debug.Log("Level: " + level);

			//if level is not greater than 4
			if (level <= 4) 
			{
				//load the next level
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
				//Debug.Log(score);
				Debug.Log("in GotCoin stmt after loading new scene");
				//TODO Display on top right or left LEVEL (level)
			}

			//TODO if level is 4 (or greater just in case) 
			//Display Game Over/ You Won etc.
			//end scene etc
		}

		
		
	}

}