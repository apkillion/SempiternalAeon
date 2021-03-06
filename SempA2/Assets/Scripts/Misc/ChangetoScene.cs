﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangetoScene : MonoBehaviour
{

	public string sceneName = "";

	private void OnMouseDown ()
	{
		if (SceneManager.GetActiveScene ().name == "QuestScene" || SceneManager.GetActiveScene ().name == "townscene") {
			SceneSelection ();
		}
	}

	private void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Player") {
			SceneSelection ();
		}
	}

	private void SceneSelection ()
	{
		switch (sceneName) {
		case "grassy":
			SceneManager.LoadScene ("Grassy Scene", LoadSceneMode.Single);
			break;
		case "town":
			SceneManager.LoadScene ("TownScene", LoadSceneMode.Single);
			break;
		case "quest":
			SceneManager.LoadScene ("QuestScene", LoadSceneMode.Single);
			break;
		case "Platform generation":
			SceneManager.LoadScene ("Platform generation", LoadSceneMode.Single);
			break;
		default:
			break;
		}
	}

}
	


