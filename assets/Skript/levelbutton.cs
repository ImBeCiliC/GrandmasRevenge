﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelbutton : MonoBehaviour {

	public void Level()
	{
		SceneManager.LoadScene ("levelauswahl");
	}
}

