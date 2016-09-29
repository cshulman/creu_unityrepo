using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour 
{
	public int score;
	//keep track of level
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
		//check score here
		if(score >= 10)
		{
			//subtract 10 from score
			score -= 10;
			level++;

			//if less then or equal to 4 then add one 
			if(level <= 4 )
				//load next scene
				level = level;//not supposed to be there but there's an error if not
				//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			else 
				//load YOU WIN or whatever and end the game
				level = level;//not supposed to be there but there's an error if not
		}

	}
	
}
