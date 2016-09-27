using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	//public vars
	public int maxPlatforms = 20;
	public GameObject platform;
	//min distance to right will be 6.5 units
	public float horizontalMin = 6.5f;
	//max distance will be 14 units
	public float horizontalMax = 14f;
	//can spawn above and below last platform by 6
	public float verticleMin = -6f;
	public float verticleMax = 6;

	//private vars
	private Vector2 originPosition;

	// Use this for initialization
	void Start () 
	{
		originPosition = transform.position;
		Spawn ();
	}

	void Spawn()
	{
		for (int i = 0; i < maxPlatforms; i++)
		{
				Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax) , Random.Range(verticleMin, verticleMax));
			Instantiate(platform, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
		}		
	}
}