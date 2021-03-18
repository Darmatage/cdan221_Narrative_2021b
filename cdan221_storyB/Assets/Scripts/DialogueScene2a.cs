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
    public GameObject ArtChar2d;
    public GameObject ArtChar2e;
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
        ArtChar2e.SetActive(false);
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
            Char1speech.text = "I decided to go on a date with Jett.\nHe seemed sweet enough, despite the odd typing style, but that was fine.";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I decided to go on a date with Jett.\nHe seemed sweet enough, despite the odd typing style, but that was fine.\nHe's a vampire and everyone knows vampires are historically good lovers.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I decided to go on a date with Jett.\nHe seemed sweet enough, despite the odd typing style, but that was fine.\nHe's a vampire and everyone knows vampires are historically good lovers.\nIf you managed to snag a date with a vampire, you'd be an absolute idiot to turn it down.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "So, after chatting for a bit, we decided to go on a date to a . . . graveyard?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "So after chatting for a bit, we decided to go on a date to a . . . graveyard?\nOkay, not the weirdest date I’ve been on, so I can't really complain.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "As I walk through past the tombstones,";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "As I walk through past the tombstones,\noccasionally looking at the different headstones,";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "As I walk through past the tombstones,\noccasionally looking at the different headstones,\na little bat flew in front of me before landing with a puff of smoke.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Hi! Are you my date this evening?";
        }
        else if (primeInt == 12)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I blinked before I gave him a small smile.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            ArtChar2a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Yes I am. Hello there.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 14)
        {
            ArtChar2a.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, that's so poggers!";
        }
        else if (primeInt == 15)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, that's so poggers!!\nI’m Jett, nice to meet you.";
        }
        else if (primeInt == 16)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = " P-Pogger?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 17)
        {
            ArtChar2c.SetActive(false);
            ArtChar2d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, yeah.";
        }
        else if (primeInt == 18)
        {
            ArtChar2c.SetActive(false);
            ArtChar2d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, yeah.\nThat’s just something I happen to say sometimes!";
        }
        else if (primeInt == 19)
        {
            ArtChar2d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, yeah.\nThat’s just something I happen to say sometimes!";
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
            ArtChar2d.SetActive(false);
            ArtChar2e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "R-R-Really?";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah! It fits . . . you!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah! It fits . . . you!\nIt just matches your being.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
        else if (primeInt == 103)
        {
            ArtChar2e.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Thank you";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Really? I've never heard that saying before.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            ArtChar2d.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I learned it off the internet!";
        }
        else if (primeInt == 202)
        {
            ArtChar2d.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I learned it off the internet!\nI thought it was such a fun way of saying ''Cool'' that I thought I'd say it more often!";
        }
        else if (primeInt == 203)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Interesting.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Interesting.\nYou'll have to teach more some more words.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Okay! I will!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
    }
	
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "That's okay. It sounds cute.";
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
                Char1speech.text = "Really? I've never heard that saying before.";
                Char2name.text = "";
                Char2speech.text = "";
				gameHandlerObj.UpdateDateScore("Jett", -1);
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