using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1a : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
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

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
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
                Char3name.text = "";
                Char3speech.text = "(You chose to go on a date with Sea-bass-tion. He seemed way more down to earth than the others).";
                Char1name.text = "";
                Char1speech.text = "";
				Char2name.text = "";
				Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char3name.text = "";
				Char3speech.text ="(The two of you decided to have a walk on the beach).";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char2speech.text = "";
        }
       else if (primeInt ==4){
                Char3name.text = "";
				Char3speech.text ="(You don’t see him anywhere around, though. Is he late…?).";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";		
                //gameHandler.AddPlayerStat(1);
       }
       else if (primeInt ==5){
                Char3name.text = "";
				Char3speech.text ="";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "H-Hey!";
        }
       else if (primeInt == 6){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "You";
                Char1speech.text = "...?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 7){
				Char3name.text = "";
				Char3speech.text = "(You turn to see, running towards you, a reverse fish-man...man-fish?).";
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==8){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "You";
                Char1speech.text = "Wait...are you Baz?";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt ==9){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Yeah! Just like in the picture. You didn't think I was catfishing you, right?";		
        }
       else if (primeInt ==10){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "You";
                Char1speech.text = "Not exactly...the photo just confused me.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
       else if (primeInt ==11){
                Char3name.text = "";
				Char3speech.text = "(All this time, you thought he was the human guy in the photo).";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
		 }
       else if (primeInt ==12){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Oh, haha, no. That's my bro Kyle from the frat!";
		 }
       else if (primeInt ==13){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "You";
                Char1speech.text = "Oh...";
                Char2name.text = "";
                Char2speech.text = "";
		 }
       else if (primeInt ==14){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Anyway, I'm glad you wanted to come! You like the beach, right?";		
	    }		
       else if (primeInt == 15){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "You";
                Char1speech.text = "Um...";
                Char2name.text = "";
                Char2speech.text = "";
				//gameHandler.AddPlayerStat(1);
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
				Char3name.text = "";
				Char3speech.text = "";
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "That's ok, you just need to come with the right person.";     
        }
       else if (primeInt == 101){
                Char3name.text = "";
				Char3speech.text = "(Baz winks- or did he just blink?).";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
		 }
       else if (primeInt ==102){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "You";
                Char1speech.text = "Yeah, I guess you're right..";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Awesome! This'll be fun.";               
        }
       else if (primeInt == 201){
                Char3name.text = "";
				Char3speech.text = "(Baz winks- or did he just blink at you?).";
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
		 }
       else if (primeInt ==202){
                Char3name.text = "";
				Char3speech.text = "";
				Char1name.text = "You";
                Char1speech.text = "Yeah, it will!";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
               
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "I'm not a huge fan.";
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
                Char2speech.text = "Yeah! I love coming to the beach.";
				gameHandlerObj.UpdateDateScore("Baz", 1);
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
			public void SceneChange1a(){
               SceneManager.LoadScene("Scene1b");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene1b");
        }
	}
