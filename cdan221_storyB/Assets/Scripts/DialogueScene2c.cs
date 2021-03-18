using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2c : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
    public GameObject ArtChar2e;
    public GameObject ArtChar2f;
    public GameObject ArtChar2g;
    public GameObject ArtChar2h;
    public GameObject ArtChar2i;
    public GameObject ArtChar2j;
    public GameObject ArtChar3a;
    public GameObject ArtChar3b;
    public GameObject ArtChar3c;
    public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
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
        ArtChar2f.SetActive(false);
        ArtChar2g.SetActive(false);
        ArtChar2h.SetActive(false);
        ArtChar2i.SetActive(false);
        ArtChar2j.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtChar3c.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);
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
            ArtChar2d.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "It was quiet again as Jett munched happily on a rather adorably shaped cat sandwich as I picked at my food, which was also adorable shaped.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "While it wasn't an uncomfortable silence, the sounds of crows off in the distance and crickets chirping nearby in the dimly lit graveyard was a comforting filler.";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 4)
        {
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "So,";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar2d.SetActive(false);
            ArtChar2e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "So,\nH0w's the d8 so 4ar?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = ". . .";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = ". . .\nI don't know what he just said. . .";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtChar2e.SetActive(false);
            ArtChar2f.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, I'm sorry! I forgot some people don't speak Leet!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 9)
        {
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "L-Leet?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar2f.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yeah! It was my favorite way of speaking before I became an e-boy!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 11)
        {
            ArtChar2a.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I wish they'd bring it back. People say Leet is dead, but I don't think so.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 12)
        {
            ArtChar2b.SetActive(false);
            ArtChar2g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Or it could be an error with my script file. I dunno.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "YOU";
            Char1speech.text = ". . .";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 14)
        {
            ArtChar2g.SetActive(false);
            ArtChar2f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "U-Uh, lets move on from that, though!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 15)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "U-Uh, lets move on from that, though!\nW-What do you like to do?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 16)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh, well, I like all the general stuff.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 17)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh, well, I like all the general stuff.\nLong walks on sandy beaches, reading, video games, social media, stuff like that. What about you?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 18)
        {
            ArtChar2f.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I like all sorts of internet stuff!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 19)
        {
            ArtChar2f.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I like all sorts of internet stuff!\nI like slang and memes and all sorts of treneds and stuff. I'm basically on ClikClok all the time!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 20)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I never would've guessed.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yeah, that's where I got the inspiration for my style from!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 22)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yeah, that's where I got the inspiration for my style from!\nI didn't know what an e-boy was until a week or two ago, but now I love the way they dress and act. It's so cool!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 23)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Is that where your style came from?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 24)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Uh-huh!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 25)
        {
            ArtChar2c.SetActive(false);
            ArtChar2h.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Though, there's so girls that dress like this too and my brothers don't think I pull off the look well, they say I'm too cute to be edgy, but I don't think that's true! I can be edgy!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 26)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh course, Jett. You're so edgy.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 27)
        {
            ArtChar2h.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "While Jett beamed happily at the comment, a girl walked over to the both of us with a scowl on her face.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 28)
        {
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "Ugh. Who are you?";
        }
        else if (primeInt == 29)
        {
            ArtChar2c.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh, hello! I'm Jett, nice to meet you!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "Ugh, you're so cringy. What are you supposed to be, a goth or something?";
        }
        else if (primeInt == 31)
        {
            ArtChar2a.SetActive(false);
            ArtChar2g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "No? I'm an e-boy, at least that's what I consider myself.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaityln";
            Char3speech.text = "Ugh!! So cringy!! Who would want to date someone like that?!";
        }
        else if (primeInt == 33)
        {
            ArtChar2g.SetActive(false);
            ArtChar2i.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Huh?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 34)
        {
            ArtChar2g.SetActive(false);
            ArtChar2i.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "I mean, really? Who dresses like that anymore, let alone even speak like that. You sound like a giant nerd - no, a dork. I feel so bad for anyone that would ever date you.";
        }
        else if (primeInt == 35)
        {
            ArtChar2g.SetActive(false);
            ArtChar2i.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Jett whimpered as he looked away pitifully.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 36)
        {
            ArtChar2g.SetActive(false);
            ArtChar2i.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Jett whimpered as he looked away pitifully.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()}
        }

        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "Huh?";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Jett's not bothering anyone. Just leave us alone and let us continue our date.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 102)
        {
            ArtChar3a.SetActive(true);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "You're actually gonna side with this little weirdo? He's freaky and gross and just . . . cringy! Who would ever love someone like that?";
        }
        else if (primeInt == 103)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I glared as I reached absently into my purse, sure there would be something that would maybe make this chick leave.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 104)
        {
            Char1name.text = "YOU";
            Char1speech.text = "As I was patting around, I felt the familiar wooden stake that sat at the bottom of my purse.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 105)
        {
            Char1name.text = "YOU";
            Char1speech.text = "As I was patting around, I felt the familiar wooden stake that sat at the bottom of my purse.\nRight, I was supposed to get rid of this thing a couple of weeks ago, but maybe it'll make this lady leave.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 106)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I said leave us alone!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 107)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I threw the stake absently, hoping it would maybe and by her feet and scare her away, but it instead made its way into her chest, spearing her.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 108)
        {
            ArtChar3b.SetActive(false);
            ArtChar3c.SetActive(true);
            ArtChar2i.SetActive(false);
            ArtChar2g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "You . . . You stabbed me!?";
        }
        else if (primeInt == 109)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh my God, I stabbed you.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 110)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "Y-You . . . You freak! Fine! Keep hanging out with this cringy loser, see if I care!";
        }
        else if (primeInt == 111)
        {
            ArtChar3a.SetActive(false);
            ArtChar3b.SetActive(false);
            ArtChar3c.SetActive(false);
            ArtChar2g.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Kaitlyn hobbled off into the darkness as Jett looked over at me, his eyes bright and cheerful.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 112)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Wow! You saved me! Thank you so much!!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 113)
        {
            Char1name.text = "YOU";
            Char1speech.text = "It's no problem. I just didn't like how she was bullying you.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 114)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "No, you saved me! That was so poggers! Thank . . .";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 115)
        {
            ArtChar2c.SetActive(false);
            ArtChar2j.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Why did you have a stake with you?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 116)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Huh?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 117)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Why did you have a stake? Were you trying to kill me?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 118)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I-I, uh . . .";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 119)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I-I, uh . . .";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice2b.SetActive(true); // function Choice2bFunct()
        }

        else if (primeInt == 200)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Y-You . . .? What are you doing, I thought you were -";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "Exactly! He looks so gross and cringy! Only dweebs and nerds dress and talk like that. Like, are you from the 2000s or something?";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "Player";
            Char1speech.text = "Oh no. More like GothTopic or something.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "Oh my God, yeah! I totally see it now!";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "You don't have to be so mean.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Kaitlyn";
            Char3speech.text = "Oh my God. Alright, I had my fun. See you later, Edge Lord.";
        }
        else if (primeInt == 206)
        {
            ArtChar3a.SetActive(false);
            ArtChar3b.SetActive(false);
            ArtChar3c.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "As Kaitlyn walked off, Jett peeked over at me.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 207)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "T-That wasn't very nice of you. You were supposed to be on my side and you made fun of me.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 208)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah, but at least she's gone. We can continue on with our date.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 209)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Jett huffed as he looked away.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 210)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Yeah, fine.";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene4Button.SetActive(false);
            NextScene3Button.SetActive(true);
        }
        
   
        // ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 300)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = ". . .";
        }
        else if (primeInt == 301)
        {
            ArtChar2j.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Oh! Okay! For a second, I thought you brother that with you to kill me or something!";
        }
        else if (primeInt == 302)
        {
            Char1name.text = "YOU";
            Char1speech.text = "No, no. I wasn't thinking that at all. I'm sorry if I worried you.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 303)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "No, it's okay.";
        }
        else if (primeInt == 304)
        {
            ArtChar2c.SetActive(false);
            ArtChar2h.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I'm sorry if I overreacted. It's just some people have tried to kill vampires and I just wanted to be sure.";
        }
        else if (primeInt == 305)
        {
            Char1name.text = "YOU";
            Char1speech.text = "No, I understand. It's okay";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 306)
        {
            ArtChar2h.SetActive(false);
            ArtChar2c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Well, with all that misunderstanding out of the way.";
        }
        else if (primeInt == 307)
        {
            ArtChar2c.SetActive(false);
            ArtChar2f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Well, with all that misunderstanding out of the way. How about we continue our date?";
        }
        else if (primeInt == 308)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I'd love to.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene4Button.SetActive(false);
            NextScene3Button.SetActive(true);
        }

        else if (primeInt == 400)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = ". . .";
        }
        else if (primeInt == 401)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "I don't like you anymore.";
        }
        else if (primeInt == 402)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Huh?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 403)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "You think I'm like those other vampires, the ones that kill people and suck their blood.";
        }
        else if (primeInt == 404)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jett";
            Char2speech.text = "Fine. I'll do just that.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene3Button.SetActive(false);
            NextScene4Button.SetActive(true);
        }
 }
	
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Hey, you don't have to be so mean.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Ugh, yeah. Who would ever want to date someone like that?";
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
            Char1speech.text = "I-I was gardening earlier today and I completely forgot I had it. I knew I should've checked my purse before coming here, I'm so sorry!";
            Char2name.text = "";
            Char2speech.text = "";
			gameHandlerObj.UpdateDateScore("Jett", 1);
            primeInt = 299;
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice2bFunct()
        {
            Char1name.text = "YOU";
            Char1speech.text = "I . . . I packed it in case this date went south. Y'know . . . I thought you were gonna try and suck my blood or something.";
            Char2name.text = "";
            Char2speech.text = "";
			gameHandlerObj.UpdateDateScore("Jett", -1);
            primeInt = 399;
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }

        public void SceneChange3()
        {
               SceneManager.LoadScene("Scene2d");
        }
        public void SceneChange4()
        {
                SceneManager.LoadScene("ScenePath2End");
        }
	}