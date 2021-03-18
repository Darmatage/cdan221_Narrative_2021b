using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2d : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        //public Text Char3name;
        //public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar2a;
    public GameObject ArtChar2b;
    public GameObject ArtChar2c;
    public GameObject ArtChar2d;
    public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       public GameHandler gameHandlerObj;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtChar2d.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
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
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Afterwards, the rest of the date went without a hitch and without any more interruptions.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 3)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I'm glad everything turned out okay. I was worried everything would've spoiled on the way here.";
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I'm glad everything turned out okay. I was worried everything would've spoiled on the way here.\nBut it's getting late now, so how about we end the date here?";
        }
        else if (primeInt == 5)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Alright. Sounds fine with me.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I stood up from the blanket as Jett started to pack everything away.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "However, he was having a bit of trouble trying to wrangle the blanket up and fold it properly when a harsh wind blew past.";
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
        else if (primeInt == 100)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, really? Thank you so much!";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "YOU";
            Char1speech.text = "It's not much of a problem. Plus, you seemed to be struggling a bit.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
            ArtChar2a.SetActive(false);
            ArtChar2d.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Well, thank you so much for the help.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            ArtChar2a.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yeah.";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "YOU";
            Char1speech.text = "The blanket almost blew away. Thank God you were so fast.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Hmm . . .";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
	}
	
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Here, let me help.";
                Char2name.text = "";
                Char2speech.text = "";
				gameHandlerObj.UpdateDateScore("Jett", 1);
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Geez, that was a hard gust of wind.";
                Char2name.text = "";
                Char2speech.text = "";
				
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
    public void SceneChange1(){
               SceneManager.LoadScene("ScenePath2End");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("ScenePath2End");
        }
	}