using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene0 : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
		public Text Char4name;
		public Text Char4speech;
        public GameObject dialogue;
		public GameObject dialogue2;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
		public GameObject ArtChar3;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
        public GameObject NextScene1Button;
		public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
       //public GameObject gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
		dialogue2.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
        ArtBG1.SetActive(false);
		ArtBG2.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Ugh.... I’ve decided it...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "I’M TIRED OF BEING SINGLE!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "(You fish beneath your pillow for your phone, and open the dating app you’ve left untouched for months).";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Sinder.... A cesspool of horny college ghouls, couples looking for a third, and people who just really want to smoke weed. ";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "You’d tried to be successful on there before, but the dating world can be hard for mortals.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "Plus, some demons and monsters can be pretty tempermental. ";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "(You take a look at some of the people who have matched with you most recently. Certainly one of them will be willing to give you a shot, right?).";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				ArtBG2.SetActive(false);
				dialogue.SetActive(false);
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true); // function Choice1cFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char3name.text = "YOU";
                Char3speech.text = "And the fishing kind. Odd.";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 101){
                Char3name.text = "YOU";
                Char3speech.text = "At least we have something in common, let's give it a shot.";
                Char4name.text = "";
                Char4speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char3name.text = "YOU";
                Char3speech.text = "Vampires can have a bit of an ego problem...";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 201){
                Char3name.text = "YOU";
                Char3speech.text = "I'll give'em a chance.";
                Char4name.text = "";
                Char4speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		
		else if (primeInt == 300){
                Char3name.text = "YOU";
                Char3speech.text = "Natas'sha? That's an interesting name.";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 301){
                Char3name.text = "YOU";
                Char3speech.text = "Seems risky..but why not.";
                Char4name.text = "";
                Char4speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
     }
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char3name.text = "YOU";
                Char3speech.text = "A mortal? on Sinder?";
                Char4name.text = "";
                Char4speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				ArtChar1.SetActive(true);
				ArtBG1.SetActive(true);
                nextButton.SetActive(true);
				dialogue2.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char3name.text = "YOU";
                Char3speech.text = "At least this guy looks nice.";
                Char4name.text = "";
                Char4speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				ArtChar2.SetActive(true);
				ArtBG1.SetActive(true);
                nextButton.SetActive(true);
				dialogue2.SetActive (true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                Char3name.text = "YOU";
                Char3speech.text = "Demon-girl...she looks like a partier.";
                Char4name.text = "";
                Char4speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				ArtChar3.SetActive(true);
				ArtBG1.SetActive(true);
                nextButton.SetActive(true);
				dialogue2.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene1a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2a");
        }
		public void SceneChange3(){
                SceneManager.LoadScene("Scene3a");
        }
	}