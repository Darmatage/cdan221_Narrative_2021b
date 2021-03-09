using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 

public class DialogueScene3b : MonoBehaviour { 
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
	//public GameObject gameHandler; 
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
			ArtChar1.SetActive(true); 
			dialogue.SetActive(true); 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "Barista"; 
			Char2speech.text = "Hey, Nat! Good to see ya.";
		}
		else if (primeInt ==3){
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Heyyy Lulu! I’ll have the usual, babe.";
			Char2name.text = ""; 
			Char2speech.text = "";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 4){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "Natas’sha hands the werewolf barista the reusable cup she brought with her.";
		}
		else if (primeInt == 5){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 6){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "You"; 
			Char2speech.text = "Um...";
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Ohh, I see. You’ve got a sweet tooth?";
			Char2name.text = ""; 
			Char2speech.text = ""; 
		} 
		else if (primeInt == 101){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "You"; 
			Char2speech.text = "Haha, sort of.";
		}
		else if (primeInt == 102){
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Hmm. Well, be careful. That’s basically a milkshake. I don’t get how people can have that kind of thing so early in the day.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
		} 
		else if (primeInt == 103){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "You"; 
			Char2speech.text = "Oh.. I guess that’s true. I just don’t like coffee is all."; 
		} 
		else if (primeInt == 104){
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "They do have tea, you know. That’s what I get. Suuuper sweet, and still caffeinated. Not to mention healthier...";
			Char2name.text = ""; 
			Char2speech.text = ""; 
		} 
		else if (primeInt == 105){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "You get the feeling that Natas’sha is judging your diet…."; 
			nextButton.SetActive(false); 
			allowSpace = false; 
			NextScene1Button.SetActive(true);
		} 

		else if (primeInt == 200){
			Char1name.text = "Jeda"; 
			Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
			Char2name.text = ""; 
			Char2speech.text = ""; 
		} 
		else if (primeInt == 201){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "You"; 
			Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
			nextButton.SetActive(false); 
			allowSpace = false; 
			NextScene2Button.SetActive(true);
			} 
		} 

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
		Char1name.text = ""; 
		Char1speech.text = "";
		Char2name.text = "You"; 
		Char2speech.text = "I’ll have the… ‘Midnight Mocha Frappuccino.’";
		primeInt = 99;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true); 
		allowSpace = true;
	} 
	public void Choice1bFunct(){ 
		Char1name.text = ""; 
		Char1speech.text = ""; 
		Char2name.text = "You"; 
		Char2speech.text = "I’ll have the… ‘Blue Moon Styx Bubble Tea.’";
		primeInt = 199;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true); 
		allowSpace = true;
	}

	public void SceneChange3c(){
		SceneManager.LoadScene("Scene3c");
	} 
	public void SceneChange2b(){ 
		SceneManager.LoadScene("Scene2b");
	}
}

