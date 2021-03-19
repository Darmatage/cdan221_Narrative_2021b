using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScenePath3End : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject dialogue;
        public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
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
        endGood.SetActive(false);
        endBad.SetActive(false);
        nextButton.SetActive(true);
		
		 if (gHandler.WhatIsDateScore("Natas'sha") <= 0 ){
                       ArtBG2.SetActive(true);
					   ArtBG1.SetActive(false);
					   primeInt = 1;         //so that hitting [NEXT] goes to primeInt = 2!
                }
                else if (gHandler.WhatIsDateScore("Natas'sha") > 0 ){
                       ArtBG2.SetActive(true);
					   ArtBG1.SetActive(false);
					   primeInt = 19;         //so that hitting [NEXT] goes to primeInt = 20!
                }
                // else if ((gHandler.WhatIsDateScore("Natas'sha")> 20 )&&(gHandler.WhatIsDateScore("Natas'sha")< 30 )){
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "That was really awesome. I hope I’m not coming on too strong, but… could we maybe… see eachother again?";
        }
       else if (primeInt ==3){
                Char1name.text = "Natas'sha";
                Char1speech.text = "Phhhffbbt… lol…. LMAO…..";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "...So that's a no?";
        }
       else if (primeInt == 5){
                Char1name.text = "Natas'sha";
                Char1speech.text = "Mm.. I meeaaan, no hard feelings or whatever… But you’re kind of lame. Plus, I can totally tell that you were faking your interest in environmental activism… ";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
				ArtChar1c.SetActive(true);
				ArtChar1a.SetActive(false);
                Char1name.text = "Natas'sha";
                Char1speech.text = "And, by the way, you should NEVER lie to me. EVER.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
				ArtChar1a.SetActive(true);
				ArtChar1c.SetActive(false);
                Char1name.text = "Natas'sha";
                Char1speech.text = "But we can meet again, yeah. Just not for a date.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "What-?!";
		}
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "(Natas'sha laughs at me as the air around us grows hotter.)";
		}
       else if (primeInt ==10){
				ArtChar1a.SetActive(false);
				ArtBG2.SetActive(false);
				ArtBG1.SetActive(true);
                Char1name.text = "Natas'sha";
                Char1speech.text = "Bye for now, sweetie! I hope you’ll look forward to seeing all my favorite torture methods!";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt ==11){
                Char1name.text = "Natas'sha";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "That was really awesome. I hope I’m not coming on too strong, but… could we maybe… see eachother again?";
        }
       else if (primeInt ==21){
                Char1name.text = "Natas'sha";
                Char1speech.text = "You know what? I think we should.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Really?";
        }
       else if (primeInt == 23){
				ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
                Char1name.text = "Natas'sha";
                Char1speech.text = "Yeah, really! I expected you to be kind of lame, honestly, but… you’re cool. Like, really cool!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 24){
                Char1name.text = "Natas'sha";
                Char1speech.text = "(smooch)";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "(Natas’sha gives me a kiss on the cheek. Ouch, it burns! But you know what? Worth it!)";
        }
       else if (primeInt == 26){
                Char1name.text = "Natas’sha";
                Char1speech.text = "Next time you can treat me to your favorite place, alright? Until then, babe!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 27){
                Char1name.text = "Natas’sha";
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
