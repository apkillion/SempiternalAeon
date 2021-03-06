﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawnManager : MonoBehaviour
{
	public int spawnCount;
	public int maxSpawns;
	public int spawnTime;
	public GameObject enemy;
	private GameObject[] spawnPoints;
	// Use this for initialization
	void Start ()
	{
		spawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");
		if (spawnPoints.Length == 0) {
			Debug.Log ("No spawn points found!");
			StartCoroutine (CheckForSpawns ());
			return;
		}
		spawnCount = 0;
		if (spawnCount < maxSpawns) {
			Spawn (); 
		}
	}

	void Spawn ()
	{
		StartCoroutine (SpawnAfterDelay ());
	}

	IEnumerator SpawnAfterDelay ()
	{
		yield return new WaitForSeconds (spawnTime);
		if (spawnCount < maxSpawns) {
			int spawnPointIndex = UnityEngine.Random.Range (0, spawnPoints.Length); 
			Instantiate (enemy, spawnPoints [spawnPointIndex].transform.position, Quaternion.identity);
			spawnCount++;
			if (spawnCount < maxSpawns) {
				Spawn ();
			}
		}
	}

	IEnumerator CheckForSpawns ()
	{
		yield return new WaitForSeconds (3);
		spawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");
		if (spawnPoints.Length == 0) {
			Debug.Log ("No spawn points found!");
			StartCoroutine (CheckForSpawns ());
		} else {
			Spawn ();
		}
	}

	public void ReduceSpawnCount ()
	{
		spawnCount--;
		Spawn ();
	}

	public void SetEnemy (GameObject e)
	{
		enemy = e;
	}
}
