﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons_Menu : MonoBehaviour
{
   public void Play()
	{
		SceneManager.LoadScene("Main");
	}

	public void Options()
	{
		//Write Options Code
	}

	public void Quit()
	{
		Application.Quit();
	}
}