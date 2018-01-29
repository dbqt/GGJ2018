﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour {

	public int lengthX;
	public int lengthY;

	[Header("Fixed objects")]
	public GameObject[] Environment;
	public GameObject[] NpcRoster;
	public GameObject[] ObjectRoster;
	public GameObject JuryDesk;

	private bool[,] TableDeVerite;

	[Header("Geenration")]
	public int numberSpawnNpc;
	public int countSpawnNpc;

	public int numberSpawnObject;
	public int countSpawnObject;

	private int randX;
	private int randY;
	private int randXJury;
	private Vector3 randPos;


	void GenerateMap()
	{
		TableDeVerite = new bool[lengthX, lengthY];

        foreach(GameObject ob in Environment)
        {
            TableDeVerite[Mathf.FloorToInt(ob.transform.position.x), Mathf.FloorToInt(ob.transform.position
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
				randPos = new Vector3(randX, 0.5f, randY);
				int randNpc = Random.Range(0, NpcRoster.Length);
				GameObject newNpc = Instantiate(NpcRoster[randNpc], randPos, Quaternion.identity) as GameObject;
				countSpawnNpc++;
				TableDeVerite[ Mathf.FloorToInt(randX),  Mathf.FloorToInt(randY)] = true;
			}
		}
	}

	private void SpawnRandomObject()
	{
		while(countSpawnObject < numberSpawnObject)
		{
			randomizeXY();
			randPos = new Vector3(randX, 0.5f, randY);
			int randObject = Random.Range(0, ObjectRoster.Length);
			GameObject newObject = Instantiate(ObjectRoster[randObject], randPos, Quaternion.identity) as GameObject;
			countSpawnObject++;
			TableDeVerite[ Mathf.FloorToInt(randX),  Mathf.FloorToInt(randY)] = true;
		}
	}

		private void SpawnJuryDesk()
	{
		randXJury = Random.Range(5, 15);
		randPos = new Vector3(randXJury, 0.5f, 19);
		GameObject newObject = Instantiate(JuryDesk, randPos, Quaternion.identity) as GameObject;		
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
		SpawnJuryDesk();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
