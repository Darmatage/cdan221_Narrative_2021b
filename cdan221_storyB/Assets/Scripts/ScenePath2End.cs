using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScenePath2End : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject dialogue;
        public GameObject ArtChar2a;
		public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
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
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        endGood.SetActive(false);
        endBad.SetActive(false);
        nextButton.SetActive(true);
		
		 if (gHandler.WhatIsDateScore("Jett") <= 0 ){
                       ArtBG2.SetActive(true);
					   ArtBG1.SetActive(false);
					   primeInt = 1;         //so that hitting [NEXT] goes to primeInt = 2!
                }
                else if (gHandler.WhatIsDateScore("Jett") > 0 ){
                       ArtBG2.SetActive(true);
					   ArtBG1.SetActive(false);
					   primeInt = 19;         //so that hitting [NEXT] goes to primeInt = 20!
                }
                // else if ((gHandler.WhatIsDateScore("Jett")> 20 )&&(gHandler.WhatIsDateScore("Jett")< 30 )){
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
               ArtChar2a.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "Well, thank you for such a lovely date! Maybe I'll see you around for another one.";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah, I had a fun time.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "Actually . . .";
        }
       else if (primeInt == 5){
            ArtChar2a.SetActive(false);
            ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "I don't really like our date tonight.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Huh?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "You were really rude and mean and you just . . . weren't fun.";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "I dunno, maybe we should see other people or something.";
		}
       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "Oh . . . okay.";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt ==10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "Alright, well . . . maybe I'll see you around.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				endBad.SetActive(true);
        }
		else if (primeInt == 20){
               ArtChar2a.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "Well, thank you for such a lovely date! Maybe I'll see you around for another one.";
        }
       else if (primeInt ==21){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah, I had a fun time.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 22){
            ArtChar2a.SetActive(false);
            ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "Actually . . .";
        }
       else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "I had a really nice time on our date today, well tonight. Do you think we could . . . have another sometime soon?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 24){
                Char1name.text = "YOU";
                Char1speech.text = "Wait . . . really?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "Yeah.";
        }
        else if (primeInt == 26)
        {
            ArtChar2c.SetActive(false);
            ArtChar2d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yeah. I don't want to embarrass you or anything, though, so if you want to go on another date with me, then that would be -";
        }
        else if (primeInt == 27)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I'd love to, Jett";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 28)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Really?";
        }
        else if (primeInt == 29)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah. That would be . . . poggers!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = ". . .";
        }
        else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jett";
                Char2speech.text = "W-W-Well, t-that's great! Let have another date soon, okay!?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				endGood.SetActive(true);
        }
	}


}
