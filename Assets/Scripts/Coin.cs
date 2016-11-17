using UnityEngine;
using System.Collections;


public class Coin : MonoBehaviour {

    public PopUp popupInstance;

	// Use this for initialization
	void Start () {

		if (popupInstance == null)
		{
			popupInstance = GetComponent<PopUp>();
		}
		if (popupInstance == null)
		{
			print ("null popup");
		}


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{   
			popupInstance.activateCanvas();

			//function so can keep track of all coins caught
			other.GetComponent<ScoreKeeper>().GotCoin ();
			//popupInstance.activateCanvas();

			Destroy(gameObject);
		}
	}		
}
