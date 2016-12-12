using UnityEngine;
using System.Collections;
using System.IO;
using System;


public class QuestionReader : MonoBehaviour {

	public TextAsset questionData;

	// Use this for initialization
	public void Start () {

	}

	public string getQuestion(){

		//questionData = Resources.Load ("Assets/QuestionsFolder/unityQuestions.txt") as TextAsset;
		//questionData = Resources.Load ("unityQuestions.txt") as TextAsset;

		string str = questionData.text;

		//need to change 
		string[] questions = str.Split(new[] {'\n','\r'} );

		foreach (string str1 in questions) {
			Debug.Log(str1);
			//return str1;
		}

		//TODO
		print(questions[0]);
		return questions[0];
	}
	// Update is called once per frame
	void Update () {

	}

}