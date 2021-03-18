using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1b : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameHandler gameHandlerObj;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
         		Char3name.text = "";
				Char3speech.text = "(You both are walking on the beach, the date feels pretty awkward to start).";
		}
		else if (primeInt == 3){
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Do you tend to hang around the beach?";
                Char2name.text = "";
                Char2speech.text = "";
         		Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 4){
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Yeah! Further inland is too dry, makes my scales itch.";
         		Char3name.text = "";
				Char3speech.text = "";
		}		
		else if (primeInt == 5){
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Oh, that's fair.";
                Char2name.text = "";
                Char2speech.text = "";
         		Char3name.text = "";
				Char3speech.text = "";
		}		
		else if (primeInt == 6){
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
         		Char3name.text = "";
				Char3speech.text = "(Things get quiet again as you walk).";
		}		
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "So, is there anything you’d want to do while we’re here? I didn’t plan too far ahead..";
				Char3name.text = "";
				Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()

		}
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
				ArtChar1.SetActive(false);
				ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Oh, uh, maybe some other time...";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "(Baz looks away, clearly uncomfortable).";
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Sure! Try not to hit my friends, though.";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "(You both skip stones over the water).";
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
                Char2speech.text = "Wanna go fishing?";
				gameHandlerObj.UpdateDateScore("Baz", -1);
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Maybe we can skip rocks? I'm pretty good.";
				gameHandlerObj.UpdateDateScore("Baz", 1);
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
		}
	        public void SceneChange1(){
               SceneManager.LoadScene("Scene1c");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene1c");
        }
	}