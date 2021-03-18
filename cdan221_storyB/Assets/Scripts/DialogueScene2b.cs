using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2b : MonoBehaviour {
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
    public GameObject ArtChar2f;
    public GameObject ArtChar2g;
    public GameObject ArtChar2h;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject Choice1a;
        public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject NextScene2Button;
        //public GameObject NextScene3Button;
        public GameObject nextButton;
       public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar2a.SetActive(true);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtChar2d.SetActive(false);
        ArtChar2e.SetActive(false);
        ArtChar2f.SetActive(false);
        ArtChar2g.SetActive(false);
        ArtChar2h.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene2Button.SetActive(false);
        //NextScene3Button.SetActive(false);
        nextButton.SetActive(true);
   }


    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "We started walking through the graveyard to the supposed picnic Jett set up.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 3)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "We started walking through the graveyard to the supposed picnic Jett set up.\nIt was generally quiet between us, Jett mumbling filling the space, but I didn't pay any mind to it.";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Well, until I looked at him.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar2a.SetActive(false);
            ArtChar2d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "This is gonna be such an awesome date.";
        }
        else if (primeInt == 6)
        {
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "They're gonna be all like :D and I'm gonna be all like >:D.";
        }
        else if (primeInt == 7)
        {
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "They're gonna be all like :D and I'm gonna be all like >:D.\nThen I'm gonna make such a funny joke that they'll go XD and they'll say I'm their ''little pogchamp''.";
        }
        else if (primeInt == 8)
        {
            ArtChar2d.SetActive(false);
            ArtChar2f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "O-Or maybe they'll be my little pogchamp, instead.";
        }
        else if (primeInt == 9)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "While I'm not too sure on what's even happening or how he's even making those . . . emotes with his mouth.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "YOU";
            Char1speech.text = "While I'm not too sure on what's even happening or how he's even making those . . . emotes with his mouth.\nBut before I could say anything, Jett's mumbling stopped and he turned to me.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            ArtChar2f.SetActive(false);
            ArtChar2e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh! I'm so sorry! Did you hear everything I said?";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I try not to do that anymore since people think it's weird, but I can't help it. Especially when I'm nervous.";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I try not to do that anymore since people think it's weird, but I can't help it. Especially when I'm nervous.\nYou've been so nice to me and you're so pretty and -";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, I'm sorry! I didn't mean to say that, either!";
        }
        else if (primeInt == 15)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, I'm sorry! I didn't mean to say that, either!";
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
            Char2speech.text = "R-R-Really?";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah. I never heard anyone do that before, let alone with their mouth.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah. I never heard anyone do that before, let alone with their mouth.\nI think it's cool and cute, especially since you do it when you're exicited";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = ". . .";
        }
        else if (primeInt == 104)
        {
            ArtChar2e.SetActive(false);
            ArtChar2f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "O-Oh, thank you";
        }
        else if (primeInt == 105)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Are you sure it isn't too weird?";
        }
        else if (primeInt == 106)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Not at all and don't worry. It doesn't bother me one bit.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 107)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "T-Thank you. That means a lot to me.";
            nextButton.SetActive(true);
            allowSpace = true;
            NextScene2Button.SetActive(false);
        }

        else if (primeInt == 200)
        {
            ArtChar2b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I-It is? I-I'm sorry.";
        }
        else if (primeInt == 201)
        {
            ArtChar2e.SetActive(false);
            ArtChar2g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "It's just that it happens when I'm nervous and I was a little nervous about making sure this date went well.";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah, I understand that, but it's still weird.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Okay. I'll try not to do it anymore.";
            nextButton.SetActive(true);
            allowSpace = true;
            NextScene2Button.SetActive(false);
        }

        else if (primeInt == 108)
        {
            nextButton.SetActive(true);
            ArtChar2g.SetActive(false);
            ArtChar2f.SetActive(false);
            ArtChar2a.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "The picnic should be around here some -";
        }
        else if (primeInt == 109)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh! There it is!";
        }
        else if (primeInt == 110)
        {
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Jett ran ahead and right in a little space between a couple of tombstones sat a red picnic blanket with a wicker basket on top.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 111)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Ta-da! Here it is! Do you like it?";
        }
        else if (primeInt == 112)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Of course! What's more romantic than a graveyard picnic?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 113)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yeah, my friends said the same thing!";
        }
        else if (primeInt == 114)
        {
            ArtChar2c.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Though, I would love to have a pretty forest picnic or something during sunset, but I'm sensitive to the sun.";
        }
        else if (primeInt == 115)
        {
            ArtChar2a.SetActive(false);
            ArtChar2g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Though, I would love to have a pretty forest picnic or something during sunset, but I'm sensitive to the sun.\nI get a really bad sunburn and I look like a lobster. Then I'll die. It's a vampire thing, y'know? ";
        }
        else if (primeInt == 116)
        {
            ArtChar2g.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "But, that's besides the point. Come sit!";
        }
        else if (primeInt == 117)
        {
            Char1name.text = "YOU";
            Char1speech.text = "We both sat on the blanket, where Jett pulled the basket closer to him and opened it, quickly rooting inside it.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 118)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I hope you like everything. I made everything myself and it's all vampire friendly.";
        }
        else if (primeInt == 119)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "While garlic won't kill me, I do get a horrible allergic reaction.";
        }
        else if (primeInt == 120)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "While garlic won't kill me, I do get a horrible allergic reaction.\nI get awful hives and a horrible rash, so it's not a pretty sight.";
        }
        else if (primeInt == 121)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "While garlic won't kill me, I do get a horrible allergic reaction.\nI get awful hives and a horrible rash, so it's not a pretty sight.";
            //gameHandler.AddPlayerStat(1);
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice2b.SetActive(true); // function Choice2bFunct()
        }
        else if (primeInt == 204)
        {
            ArtChar2g.SetActive(false);
            ArtChar2a.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "The picnic should be around here some -";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh! There it is!";
        }
        else if (primeInt == 206)
        {
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Jett ran ahead and right in a little space between a couple of tombstones sat a red picnic blanket with a wicker basket on top.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 207)
        {
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Ta-da! Here it is! Do you like it?";
        }
        else if (primeInt == 208)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Of course! What's more romantic than a graveyard picnic?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 209)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yeah, my friends said the same thing!";
        }
        else if (primeInt == 210)
        {
            ArtChar2c.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Though, I would love to have a pretty forest picnic or something during sunset, but I'm sensitive to the sun.";
        }
        else if (primeInt == 211)
        {
            ArtChar2a.SetActive(false);
            ArtChar2g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Though, I would love to have a pretty forest picnic or something during sunset, but I'm sensitive to the sun.\nI get a really bad sunburn and I look like a lobster. Then I'll die. It's a vampire thing, y'know? ";
        }
        else if (primeInt == 212)
        {
            ArtChar2g.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "But, that's besides the point. Come sit!";
        }
        else if (primeInt == 213)
        {
            Char1name.text = "YOU";
            Char1speech.text = "We both sat on the blanket, where Jett pulled the basket closer to him and opened it, quickly rooting inside it.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 214)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I hope you like everything. I made everything myself and it's all vampire friendly.";
        }
        else if (primeInt == 215)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "While garlic won't kill me, I do get a horrible allergic reaction.";
        }
        else if (primeInt == 216)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "While garlic won't kill me, I do get a horrible allergic reaction.\nI get awful hives and a horrible rash, so it's not a pretty sight.";
        }
        else if (primeInt == 217)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "While garlic won't kill me, I do get a horrible allergic reaction.\nI get awful hives and a horrible rash, so it's not a pretty sight.";
            //gameHandler.AddPlayerStat(1);
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice2b.SetActive(true); // function Choice2bFunct()
        }

        // ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 300)
        {
            ArtChar2a.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yup! I wanted to make sure everything was perfect for out date! I even used those cute cookie cutters to make the sandwiches cute, too!";
        }
        else if (primeInt == 301)
        {
            ArtChar2c.SetActive(false);
            ArtChar2h.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "See? It's a kitty!";
        }
        else if (primeInt == 302)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "See? It's a kitty!\nI also made bunny apple slices and spiders on a log. It's like ants on a log, but I made little legs and eyes for them.";
        }
        else if (primeInt == 303)
        {
            Char1name.text = " YOU";
            Char1speech.text = "That's so cute, Jett!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 304)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I never pegged you as someone that could make stuff like this.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 305)
        {
            ArtChar2h.SetActive(false);
            ArtChar2f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Y-Yeah. I practiced for a long time and I finally got it right!";
        }
        else if (primeInt == 306)
        {
            ArtChar2f.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "But let's not let this food go to waste! Let's eat!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        else if (primeInt == 400)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "W-Wha . . .";
        }
        else if (primeInt == 401)
        {
            ArtChar2a.SetActive(false);
            ArtChar2g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Uh . . . not really. That's just a myth.";
        }
        else if (primeInt == 402)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Vampires don't really suck blood from humans, anymore. We did in ancient times, but not now";
        }
        else if (primeInt == 403)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Vampires don't really suck blood from humans, anymore. We did in ancient times, but not now.\n While my dad still jokes about that sometimes, we just eat raw or rare foods to make up for the blood. No killing required.";
        }
        else if (primeInt == 404)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Alright, but just to be safe, I probably won't partake in any.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 405)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "B-But I . . .";
        }
        else if (primeInt == 406)
        {
            ArtChar2g.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Alright . . .";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

        // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct()
        {
            Char1name.text = "YOU";
            Char1speech.text = "No, Jett, it's okay. In fact, I think it's actually pretty cute.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 99;
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice1bFunct()
        {
            Char1name.text = "YOU";
            Char1speech.text = "Uh . . . yeah. Can you try not to do that anymore? It's kinda weird.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 199;
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }

        // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #2 and switch scenes)
        public void Choice2aFunct()
        {
            Char1name.text = "YOU";
            Char1speech.text = "That's okay. You have an allergy, that should top everything. Though, everything looks really cute. You made everything by hand?";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 299;
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice2bFunct()
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh, okay. So . . . there's like blood and stuff in it?";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 399;
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
            
            public void SceneChange2()
            {
                SceneManager.LoadScene("Scene2c");
            }
            public void SceneChange3()
            {
                SceneManager.LoadScene("Scene1c");
            }
        }