using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2a : MonoBehaviour {
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
    public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
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
            Char1speech.text = "I decided to go on a date with Jett.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 3)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I decided to go on a date with Jett. \n   He seemed sweet enough, despite the odd typing style…";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I decided to go on a date with Jett. \n He seemed sweet enough, despite the odd typing style… \n Not to mention, vampires are historically very good lovers. If you manage to score a date with a vampire, you’d be an idiot to turn it down.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "We decided to go on a date to . . . the graveyard?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "We decided to go on a date to . . . the graveyard? \n Okay, not the weirdest date I’ve been on.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "As I walk through past the tombstones,";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "As I walk through past the tombstones, \n occasionally looking at the headstones,";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "As I walk through past the tombstones, \n occasionally looking at the headstones, \n a little bat flew in front of me before a puff of black appeared around it.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Hi! Are you my date this evening?";
        }
        else if (primeInt == 11)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I blinked before I gave him a small smile and a nod.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Yeah. Hi.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            ArtChar2a.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh! Your outfit is so poggers!!";
        }
        else if (primeInt == 14)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh! Your outfit is so poggers!! \n I’m Jett, nice to meet you.";
        }
        else if (primeInt == 15)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = " P-Pogger?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 16)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, yeah.";
        }
        else if (primeInt == 17)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, yeah. \n That’s just something I happen to say sometimes!";
        }
        else if (primeInt == 18)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, yeah. \n That’s just something I happen to say sometimes!";
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
            Char2speech.text = "R-Really? T-T-Thank you! Lets have a super awesome date then!";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Lead the way!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "(Chuckles uncomfortably as he looks away).";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "H-How about that date then?";
        }

        else if (primeInt == 202)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Alright then . . .";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
	}
	
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sounds cute.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Oh . . . okay";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
    public void SceneChange1(){
               SceneManager.LoadScene("Scene2b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene1c");
        }
	}