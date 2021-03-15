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
        endGood.SetActive(false);
        endBad.SetActive(false);
        nextButton.SetActive(true);
		
		 if (gHandler.WhatIsDateScore("Baz")<= 0 ){
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
               ArtChar1a.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "Jeda";
                Char1speech.text = "Wakey wakey, human.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Wuh..? What happened?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "Jeda";
                Char1speech.text = "I know I did not hit you that hard.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Hit me? Why?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "Jeda";
                Char1speech.text = "I am searching for a fugitive. Ragu Fahn.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Why do you think I know anything?";
        }
       else if (primeInt == 8){
                Char1name.text = "Jeda";
                Char1speech.text = "Do not play the stupid. You will take me to him.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				endGood.SetActive(true);
        }
	}


}
