using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preloader : MonoBehaviour {
	private CanvasGroup fadeGroup;
	private float loadTime;
	private float minimumLogoTime = 3.0f; //Minimum time of the scene
	// Use this for initialization
	void Start () {
		//grab the only canvas group of the scene
		fadeGroup = FindObjectOfType<CanvasGroup>();

		//start with a white screen
		fadeGroup.alpha = 1;

		//preload the game
		// $$

		//get a time stamp of the completion time
		// if the load time is super fast, give it a buffer time so we can apperciate the logo
		if (Time.time < minimumLogoTime)
			loadTime = minimumLogoTime;
		else
			loadTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		//Fade in
		if (Time.time < minimumLogoTime) {
			fadeGroup.alpha = 1 - Time.time;
		}

		//Fade out
		if (Time.time > minimumLogoTime && loadTime != 0) {
			fadeGroup.alpha = Time.time - minimumLogoTime;
			if (fadeGroup.alpha >= 1) {
				SceneManager.LoadScene ("Menu Scene");
			}

		}

	}
}
