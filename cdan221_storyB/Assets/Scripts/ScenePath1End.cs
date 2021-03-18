using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScenePath1End : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject dialogue;
        public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		public GameObject ArtChar1d;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject nextButton;
		public GameObject endGood;
		public GameObject endBad;
        public GameHandler gHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
        endGood.SetActive(false);
        endBad.SetActive(false);
        nextButton.SetActive(true);
		
		 if (gHandler.WhatIsDateScore("Baz") <= 0 ){
                       ArtBG1.SetActive(true);
					   ArtBG2.SetActive(false);
					   primeInt = 1;         //so that hitting [NEXT] goes to primeInt = 2!
                }
                else if (gHandler.WhatIsDateScore("Baz") > 0 ){
                       ArtBG2.SetActive(true);
					   ArtBG1.SetActive(false);
					   primeInt = 19;         //so that hitting [NEXT] goes to primeInt = 20!
                }
                // else if ((gHandler.WhatIsDateScore("Baz")> 20 )&&(gHandler.WhatIsDateScore("Baz")< 30 )){
                        // primeInt = 59;         
                // }	
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
               ArtChar1b.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "So...end of the date.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Yup...";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "(Baz seems like he's about to cry).";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Are you ok Baz?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt ==6){
				ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "(Baz breaks out crying). I'm sorry...I can't do this.";
		  }
       else if (primeInt ==7){
				ArtChar1b.SetActive(false);
				ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "(You watch as the heart-broken fish man dramatically leaps into the sea. Next time, check who's in the photo).";
                Char2name.text = "";
                Char2speech.text = "";		
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				endBad.SetActive(true);
        }
		else if (primeInt == 20){
               ArtChar1a.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "So...end of the date.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Yup..but I don't think it'll be the last.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 22){
				ArtChar1d.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(You look at Baz, noticing his blush).";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "You want to meet again?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Yeah! I really like you, you're just...not like other mortals.";
        }
       else if (primeInt ==25){
                Char1name.text = "YOU";
                Char1speech.text = "And you're not like other fish. Same place next week?";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt ==26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BAZ";
                Char2speech.text = "It's a date.";
        }
       else if (primeInt == 27){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				endGood.SetActive(true);
        }
	}


}
