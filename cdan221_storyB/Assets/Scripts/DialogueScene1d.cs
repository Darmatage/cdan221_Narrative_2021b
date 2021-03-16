using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1d : MonoBehaviour {
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "(It's getting later in the day, the sun is nearly touching the horizon).";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Wow, sun's getting pretty low, this date's gone by so fast.";
				Char3name.text = "";
				Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Guess time does fly when you're having fun.";
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
				Char3speech.text = "(Baz blushes, flattered by your comment).";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Well I'm glad you're enjoying it. My other dates never seem to like my date spots.";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "Who wouldn't like the beach?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "I know, right! Isn't the water awesome?";
				Char3name.text = "";
				Char3speech.text = "";
		}		
       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Right...I've swallowed a few coins.";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "(Baz seems uncomfortable. This might be a touchy subject).";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Baz";
                Char2speech.text = "Y-yeah, like fish scales.";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "(Baz blushes, happy you appreciate his scaly appearance).";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "It's like shimmering coins.";
                Char2name.text = "";
                Char2speech.text = "";
				gameHandlerObj.UpdateDateScore("Baz", -1);
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "It's like shimmering fish scales.";
                Char2name.text = "";
                Char2speech.text = "";
				gameHandlerObj.UpdateDateScore("Baz", 1);
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene1e");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene1e");
        }
}