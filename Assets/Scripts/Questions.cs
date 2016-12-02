using UnityEngine;
using System.Collections;

public class Questions : MonoBehaviour {

	public TextAsset questionData;

	// Use this for initialization
	void Start () {
		questionData = Resources.Load ("unityQuestions.txt") as TextAsset;

		string str = questionData.text;
		string[] questions = str.Split(new[] {'\n','\r'});

		foreach (string str1 in questions) {
			print(str1);
			//return str1;
		}
			
		//return "empty string";
	}

	// Update is called once per frame
	void Update () {

	}

}
