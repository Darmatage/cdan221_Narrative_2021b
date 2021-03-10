using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 

public class DialogueScene3d : MonoBehaviour { 
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
	public GameObject ArtChar1c; 
	public GameObject ArtChar4a; 
	public GameObject ArtChar4b;
	public GameObject ArtChar4c;
	public GameObject ArtChar4d;
	public GameObject ArtBG1; 
	public GameObject ArtBG2;
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
		ArtChar1a.SetActive(false); 
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar3a.SetActive(false);
		ArtChar3b.SetActive(false);
		ArtChar3c.SetActive(false);
		ArtChar3d.SetActive(false);
		ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
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
			ArtChar1a.SetActive(true);
			dialogue.SetActive(true); 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(Did somebody just... jump through the window?! What's going on?!)";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt ==3){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "HUMAN GIRL";
			Char3speech.text = "";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 4){
			ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 5){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 6){
			ArtChar1a.SetActive(true);
			ArtChar1b.SetActive(false);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
			else if (primeInt == 7){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 8){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 9){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 10){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 11){
			ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 101){ 
			ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ".";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 102){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 103){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 104){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "But isn’t the majority of environmental problems the direct result of large companies? I don’t think just ditching plastic straws is an effective solution..."; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 105){
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "LARGE COMPANIES ARE THE GREATEST BREEDING GROUND FOR DAMNED SOULS. THAT’S FOOD FOR DEMONS! THAT’S GOOD FOR THE ENVIRONMENT!!";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 106){
			ArtChar1b.SetActive(true);
			ArtChar1c.SetActive(false);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Ugh! You mortals can be so ignorant. You're lucky that I have extras.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 107){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "...Sorry. Thanks."; 
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(false); 
			allowSpace = false; 
			NextScene1Button.SetActive(true);
		} 

		else if (primeInt == 200){
			ArtChar1a.SetActive(true);
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Really?";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 201){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Yeah, sorry.. I was super in a rush to get out here today.";
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 202){
			ArtChar1b.SetActive(false);
			ArtChar1a.SetActive(true);
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Aww. Too excited to see me, huh?";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 203){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "Well, you’re in luck. I always carry extra straws with me.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
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
		Char2name.text = "YOU"; 
		Char2speech.text = "Oops. Was I supposed to?";
		Char3name.text = "";
		Char3speech.text = "";
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
		Char2speech.text = "Oops. I left mine at home.";
		Char3name.text = "";
		Char3speech.text = "";
		primeInt = 199;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true); 
		allowSpace = true;
	}

	public void SceneChange3d(){
		SceneManager.LoadScene("Scene3d");
	} 
	public void SceneChange3e(){ 
		SceneManager.LoadScene("Scene3e");
	}
}


