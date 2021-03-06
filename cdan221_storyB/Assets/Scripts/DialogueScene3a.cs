﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 

public class DialogueScene3a : MonoBehaviour { 
	public int primeInt =0; // This integer drives game progress!
	public Text Char1name; 
	public Text Char1speech;
	public Text Char2name; 
	public Text Char2speech;
	public Text Char3name; 
	public Text Char3speech; 
	public GameObject dialogue; 
	public GameObject ArtChar1; 
	public GameObject ArtBG1; 
	public GameObject Choice1a; 
	public GameObject Choice1b; 
	public GameObject NextScene1Button;
	public GameObject NextScene2Button; 
	public GameObject nextButton; 
	public GameHandler gameHandlerObj; 
	//public AudioSource audioSource; 
	private bool allowSpace = true; 

	void Start(){ // initial visibility settings
		dialogue.SetActive(false);
		ArtChar1.SetActive(false); 
		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false); 
		nextButton.SetActive(true);
	} 

	void Update(){ // use spacebar as Next button
		if (allowSpace == true){
		if (Input.GetKeyDown("space")){
			talking(); 
			} 
		}
	} 

	public void talking(){ // main story function. Players hit next to progress to next int
		primeInt = primeInt + 1;
		if (primeInt == 1){
			// AudioSource.Play();
		}
		else if (primeInt == 2){  
			dialogue.SetActive(true); 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(I chose to go on a date with Natas'sha. The two of us decided to go to the cafe, MoonStruck.)";
		}
		else if (primeInt ==3){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(I'd always heard good things about it, but it never really seemed like my taste; or within my budget).";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 4){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(Luckily for me, today I'm being treated by a princess of Hell.)";
		}
		else if (primeInt == 5){
			ArtChar1.SetActive(true);
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Yoohooo! Over here!";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 6){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Oh, hi! It's nice to finally meet you..";
		}
		else if (primeInt ==7){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "(She looks a bit different than her photo-- With the tan skin and casual clothes, she could almost be mistaken for human at first glance.)";
		}
		else if (primeInt == 8){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Aww, look at you! You're even cuter in person. I always forget how tiny mortals are.";
			Char2name.text = ""; 
			Char2speech.text = "";
			// Turn off "Next" button, turn on "Choice" buttons
			nextButton.SetActive(false); 
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Ha! What, that old thing?";
			Char2name.text = ""; 
			Char2speech.text = ""; 
		} 
		else if (primeInt == 101){ 
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Yeah, I know. I was craazzzyyyy back then. lol";
			Char2name.text = ""; 
			Char2speech.text = "";
		}
		else if (primeInt == 102){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "But I look super hot! So like, who cares, right?";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			nextButton.SetActive(false); 
			allowSpace = false; 
			NextScene1Button.SetActive(true);
		}

		else if (primeInt == 200){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Me? Cute...?";
			Char2name.text = ""; 
			Char2speech.text = ""; 
		} 
		else if (primeInt == 201){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "Natas'sha bursts into laughter.";
		}	
		else if (primeInt == 202){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "OMMGGGG SKSKSKSKSKSKABSHSNFNFNDNF AHAHAHA ";
			Char2name.text = ""; 
			Char2speech.text = ""; 
		}
		else if (primeInt == 203){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "You’re toooo sweeet! Like, TOO sweet! I might vomit for real, or like, get that disease and die.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
		} 	
		else if (primeInt == 204){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Do...you mean diabetes?";
		}	
		else if (primeInt == 205){ 
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Whatever. lol";
			Char2name.text = ""; 
			Char2speech.text = "";
			nextButton.SetActive(false); 
			allowSpace = false; 
			NextScene2Button.SetActive(true);
			} 
		} 

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
		Char1name.text = ""; 
		Char1speech.text = "";
		Char2name.text = "YOU"; 
		Char2speech.text = "You look pretty different than your photo. I mean, no red skin and fire and all..";
		gameHandlerObj.UpdateDateScore("Natas'sha", 1);
		primeInt = 99;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true); 
		allowSpace = true;
	} 
	public void Choice1bFunct(){ 
		Char1name.text = ""; 
		Char1speech.text = ""; 
		Char2name.text = "YOU"; 
		Char2speech.text = "You seem really cute too.";
		gameHandlerObj.UpdateDateScore("Natas'sha", -1);
		primeInt = 199;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true); 
		allowSpace = true;
	}

	public void SceneChange2a(){
		SceneManager.LoadScene("Scene3b");
	} 
	public void SceneChange2b(){ 
		SceneManager.LoadScene("Scene3b");
	}
}