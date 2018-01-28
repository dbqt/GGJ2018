using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour {

	public int lengthX;
	public int lengthY;

	[Header("Fixed objects")]
	public GameObject[] Environment;
	public GameObject[] NpcRoster;
	public GameObject[] ObjectRoster;

	private bool[,] TableDeVerite;

	[Header("Geenration")]
	public int numberSpawnNpc;
	public int countSpawnNpc;

	public int numberSpawnObject;
	public int countSpawnObject;

	private int randX;
	private int randY;
	private Vector3 randPos;


	void GenerateMap()
	{
		TableDeVerite = new bool[lengthX, lengthY];

		for(int i = 0 ; i < Environment.Length ; i++)
		{
			TableDeVerite[Mathf.FloorToInt(Environment[i].transform.position.x), Mathf.FloorToInt(Environment[i].transform.position
			.z)] = true;
		}
		//Debug
		// for(int i = 0 ; i < lengthX ; i++)
		// {
		// 	for( int j = 0 ; j < lengthY ; j++)
		// 	{
		// 		Debug.Log(TableDeVerite[i,j]);
		// 	}
		// }
	}

	private void SpawnRandomEnemy()
	{
		while(countSpawnNpc < numberSpawnNpc)
		{
			randomizeXY();
			if(TableDeVerite[randX, randY] != true)
			{
				randPos = new Vector3(randX, 0, randY);
				int randNpc = Random.Range(0, NpcRoster.Length);
				GameObject newNpc = Instantiate(NpcRoster[randNpc], randPos, Quaternion.identity) as GameObject;
				countSpawnNpc++;
			}
		}
	}

	private void SpawnRandomObject()
	{
		while(countSpawnObject < numberSpawnObject)
		{
			randPos = new Vector3(randX, 0, randY);
			int randObject = Random.Range(0, ObjectRoster.Length);
			GameObject newObject = Instantiate(ObjectRoster[randObject], randPos, Quaternion.identity) as GameObject;
			countSpawnObject++;
		}
	}

	private void randomizeXY()
	{
			randX = Random.Range(0, lengthX-1);
			randY = Random.Range(0, lengthY-1);
	}


	// Use this for initialization
	void Start () {
		countSpawnObject = 0;
		countSpawnNpc = 0;
		GenerateMap();
		SpawnRandomObject();
		SpawnRandomEnemy();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
