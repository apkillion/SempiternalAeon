﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class SpawnPlatforms : MonoBehaviour
{

	/// <summary>
	///
	/// </summary>
	/// <param name="xGroundMin"> Used to prevent platforms from spawning below the ground </param>
	/// <param name="xMinDelta"> Min x distance from previous platform </param>
	/// <param name="xMaxDelta"> Max x distance from previous platform </param>
	public int maxPlatforms = 20;
	public GameObject levelPlatform;
	public GameObject upPlatform;
	public GameObject downPlatform;
	public float xGroundMin = 0;
	public float xMinDelta = 1.5f;
	public float xMaxDelta = 10f;
	public float yMinDelta = -2.5f;
	public float yMaxDelta = 2.5f;


	//basics of code taken from Unity.com tutorial on basic platformer creation
	//changes and additions author: Benjamin Kauppi
	private Vector2 originPosition;


	void Start ()
	{
		originPosition = new Vector2 (0, 0);
		Spawn ();

	}

	void Spawn ()
	{
		for (int i = 0; i < maxPlatforms; i++) {

			Vector2 randomPosition = originPosition + new Vector2 (Random.Range (xMinDelta, xMaxDelta), Random.Range (yMinDelta, yMaxDelta));
//			Instantiate (levelPlatform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
	}

}
