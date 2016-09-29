using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	public int score;
	public int level;

	// Use this for initialization
	void Start () 
	{
		score = 0;
		level = 0;
	}
	public void GotCoin()
	{
		score++;

		//check if need to level up
		if (score <= 10) 
		{
			//reset score
			score = 0;
			//increment level
			level++;

			//nested if 
			//TODO load next level

			//TODO Game Over/ You Won etc.
			//if level is 4 (or greater just in case)
			//game over
		}
	}

}