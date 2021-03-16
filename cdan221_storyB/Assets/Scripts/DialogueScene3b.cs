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
	public GameObject ArtChar1a; 
	public GameObject ArtChar1b; 
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
		ArtChar1a.SetActive(false); 
		ArtChar1b.SetActive(false);
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
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "BARISTA";
			Char3speech.text = "Hey cuties! What I can get you two?";
		}
		else if (primeInt ==3){
			ArtChar1a.SetActive(true);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Heyyy Lulu! I’ll have my usual.";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 4){
			ArtChar1a.SetActive(false);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "Lulu";
			Char3speech.text = "Of course! I'll take that cup for you, babe.";
		}
		else if (primeInt == 5){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Lulu";
			Char3speech.text = "And what'll the cute mortal be having?";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 6){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Um...";
			Char3name.text = "";
			Char3speech.text = "";
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			ArtChar1a.SetActive(true);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Ohh, I see. You’ve got a sweet tooth?";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 101){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Haha, sort of.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 102){
			ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Hmm. Well, be careful. That’s basically a milkshake. I don’t get how people can have that kind of thing so early in the day.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 103){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Oh.. I guess that’s true. I just don’t like coffee is all."; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 104){
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "They do have tea, you know. That’s what I get. Suuuper sweet, and still caffeinated. Not to mention healthier...";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 105){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(I get the feeling that Natas’sha is judging your diet….)"; 
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(false); 
			allowSpace = false; 
			NextScene1Button.SetActive(true);
		} 

		else if (primeInt == 200){
			ArtChar1a.SetActive(true);
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "O. M. G. No freakin way!";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 201){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "What? Is it bad?";
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 202){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "That’s what I get! Like, every time!";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 203){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "That's sooo funny. I can't believe you like Styx Tea!";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 204){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Oh, uh.. I've actually never tried it. Is it good?"; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 205){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "SO good.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 206){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "I know that damned souls can be a bit hard to swallow for mortals, but once you get used to it you’ll love it!";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 207){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(Damned what-now?!)"; 
			Char3name.text = "";
			Char3speech.text = "";
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
		Char3name.text = "";
		Char3speech.text = "";
		gameHandlerObj.UpdateDateScore("Natas'sha", -1);
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
		Char2speech.text = "I’ll have the… ‘Blue Moon Styx Bubble Tea.’";
		Char3name.text = "";
		Char3speech.text = "";
		gameHandlerObj.UpdateDateScore("Natas'sha", 1);
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
		SceneManager.LoadScene("Scene3c");
	}
}

