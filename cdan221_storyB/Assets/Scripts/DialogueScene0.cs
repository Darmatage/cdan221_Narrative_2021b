﻿using UnityEngine;
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
        dialogue.SetActive(true);
		dialogue2.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
        ArtBG1.SetActive(false);
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
                Char1speech.text = "Wakey wakey, human.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "I know I did not hit you that hard.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "I am searching for a fugitive. Ragu Fahn.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "Do not play the stupid. You will take me to him.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				dialogue.SetActive(false);
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true); // function Choice1cFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char3name.text = "YOU";
                Char3speech.text = "They're pretty cute...";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 101){
                Char3name.text = "YOU";
                Char3speech.text = "Fine, why not.";
                Char4name.text = "";
                Char4speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char3name.text = "YOU";
                Char3speech.text = "Weird that the fish is in the photo. Must like fishing.";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 201){
                Char3name.text = "YOU";
                Char3speech.text = "Oh well, worth a shot.";
                Char4name.text = "";
                Char4speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		
		else if (primeInt == 300){
                Char3name.text = "YOU";
                Char3speech.text = "They seem pretty nice...a bit weird.";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 301){
                Char3name.text = "YOU";
                Char3speech.text = "Ok, let's do it.";
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
                Char3speech.text = "Different...";
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
                Char3speech.text = "Hm...Interesting";
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
                Char3speech.text = "Ok...";
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