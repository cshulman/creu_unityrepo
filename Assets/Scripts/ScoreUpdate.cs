using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour {

	[SerializeField] public Text scoreText;
	//public int myScore;
	

	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad(scoreText);
		//scoreText.text = "Score : " +  ScoreKeeper.score;
	}
	
	// Update is called once per frame
	void Update () {
		//ScoreKeeper obj2 = GetComponent<ScoreKeeper>();
		//myScore;
		//scoreText.text = "score : " + myScore;
	
	}

	// public void UpdateScoreText ()
	// {
	// 	//ScoreKeeper obj2 = GetComponent<ScoreKeeper>();
	// 	scoreText.text = "score : " + myScore;
	// }
}
