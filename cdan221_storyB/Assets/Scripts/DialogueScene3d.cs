using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 

public class DialogueScene3d : MonoBehaviour { 
	public int primeInt =0; // This integer drives game progress!
	public Text Char1name; 
	public Text Char1speech;
	public Text Char2name; 
	public Text Char2speech;
	public Text Char3name; 
	public Text Char3speech; 
	public GameObject dialogue; 
	public GameObject ArtChar1a; 
	public GameObject ArtChar1b; 
	public GameObject ArtChar1c; 
	public GameObject ArtChar1d; 
	public GameObject ArtChar4a; 
	public GameObject ArtChar4b;
	public GameObject ArtChar4c;
	public GameObject ArtChar4d;
	public GameObject ArtBG1; 
	public GameObject ArtBG2;
	public GameObject Choice1a; 
	public GameObject Choice1b; 
	public GameObject NextScene1Button;
	public GameObject NextScene2Button; 
	public GameObject nextButton; 
	public GameHandler gameHandlerObj; 
	public AudioSource audioSource; 
	private bool allowSpace = true; 

	void Start(){ // initial visibility settings
		dialogue.SetActive(false);
		ArtChar1a.SetActive(false); 
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
		ArtChar4a.SetActive(false);
		ArtChar4b.SetActive(false);
		ArtChar4c.SetActive(false);
		ArtChar4d.SetActive(false);
		ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false); 
		nextButton.SetActive(true);
	} 

	void Update(){ // use spacebar as Next button
		if (allowSpace == true){
		if (Input.GetKeyDown("space")){
			talking(); 
			} 
		}
	} 

	public void talking(){ // main story function. Players hit next to progress to next int
		primeInt = primeInt + 1;
		if (primeInt == 1){
			// AudioSource.Play();
		}
		else if (primeInt == 2){ 
			ArtChar4a.SetActive(true);
			dialogue.SetActive(true); 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(I didn't even have time to make amends with Natas'sha before some strangely-dressed human girl came crashing through the window.)";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt ==3){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "What the hell?! There's a door right there, lady!";
			Char3name.text = "";
			Char3speech.text = "";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 4){
			ArtChar4a.SetActive(false);
			ArtChar4b.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "???";
			Char3speech.text = "QUIET, WORM! And don't call me 'lady!'";
		}
		else if (primeInt == 5){
			Char3speech.gameObject.GetComponentInParent<shaker>().ChangeShake(1f);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "You will ONLY address me as KAITLYN, THE WORLD’S GREATEST (and cutest) MONSTER HUNTER.";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 6){
			ArtChar1b.SetActive(true);
			ArtChar4b.SetActive(false);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Hey! Hellloooo! I don’t know if you’ve noticed, but you’re kind of crashing my date! Kill me another day!";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
			else if (primeInt == 7){
			Char3speech.gameObject.GetComponentInParent<shaker>().ChangeShake(0f);
			ArtChar1b.SetActive(false);
			ArtChar4b.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "Huh?! You two mind your own business! I’m here to hunt werewolves!";
		}
		else if (primeInt == 8){
			Char3speech.gameObject.GetComponentInParent<shaker>().ChangeShake(1f);
			ArtChar4b.SetActive(false);
			ArtChar4c.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "These idiots thought they could get away with being hipsters AND furries?! How cringe could you possibly be?! You're worse than stupid goth vampires!";
		}
		else if (primeInt == 9){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "?! Everyone, look out--"; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 10){
			ArtChar4c.SetActive(false);
			ArtChar1a.SetActive(true);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "'And I oop-'";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 11){
			Char3speech.gameObject.GetComponentInParent<shaker>().ChangeShake(0f);
			ArtChar1a.SetActive(false);
			ArtChar4b.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "...............";
		}
		else if (primeInt == 12){
			ArtChar1a.SetActive(false);
			ArtChar4b.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "What did you just say?";
		}
		else if (primeInt == 13){
			Char3speech.gameObject.GetComponentInParent<shaker>().ChangeShake(2f);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "DID SHE SERIOUSLY JUST SAY THAT? IN 2021? WHAT KIND OF OUTDATED PARODY IS THIS?!";
		}
		else if (primeInt == 14){
			Char3speech.gameObject.GetComponentInParent<shaker>().ChangeShake(0f);
			ArtChar4b.SetActive(false);
			ArtChar4c.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "Fine, then. She’ll die too! Everyone at home, be sure to leave a like and subscribe if you think this demon deserved her bloody demise. Are you ready?";
		}
		else if (primeInt == 15){
			ArtChar4c.SetActive(false);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(Oh, god. Is she seriously going to kill Natas’sha over some outdated meme?!)"; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 16){
			ArtChar4c.SetActive(false);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(I have to do something!)"; 
			Char3name.text = "";
			Char3speech.text = "";
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			ArtChar4d.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "H..Huh...?";
		} 
		else if (primeInt == 101){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "Kaitlyn";
			Char3speech.text = "H-Hey. What the hell? I thought you were a normal… human? Mortal? Whatever...";
		}
		else if (primeInt == 102){
			ArtChar4d.SetActive(false);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Just because I’m normal doesn’t mean I won’t protect my… my, um… "; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 103){
			ArtChar4d.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "OH, KNOCK IT OFF! Don’t be cute! It makes me nauseous! It makes me want to..!";
		} 
		else if (primeInt == 104){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "Want to....";
		} 
		else if (primeInt == 105){
			Char3speech.gameObject.GetComponentInParent<shaker>().ChangeShake(4f);
			ArtChar4d.SetActive(false);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "(THWUMP.)";
		}
		else if (primeInt == 106){
			ArtChar1a.SetActive(true);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Wow. You did that.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 107){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "Y-Yeah, I guess I.. Oh no. Oh no, that was crazy of me."; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 108){
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "No, no! That was sooo sweet of you! I mean, you didn’t need to at all. A silver bullet won’t kill a demon like me. But…";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 109){
			ArtChar1a.SetActive(false);
			ArtChar1d.SetActive(true);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "I'm glad you did. Thanks.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(false); 
			allowSpace = false; 
			NextScene1Button.SetActive(true);
		} 

		else if (primeInt == 200){
			ArtChar1a.SetActive(false);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "YOU"; 
			Char2speech.text = "(I begin to cough blood. jesus christ I'm fucking dying)"; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 201){ 
			ArtChar1b.SetActive(true);
			Char1name.text = "Natas’sha"; 
			Char1speech.text = "Why did you do that?! I would have been fine! Get up! Hey-!!";
			Char2name.text = ""; 
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 202){
			Char1name.text = "Natas'sha"; 
			Char1speech.text = "....Ugh, this is just my luck. I have to clean up ANOTHER date's corpse.";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
		} 
		else if (primeInt == 203){
			ArtChar1b.SetActive(false);
			ArtChar4a.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "Kaitlyn";
			Char3speech.text = "What a dunce. Just because silver bullets aren't made to kill mortals, doesn't mean they CAN'T.";
		} 
		else if (primeInt == 204){
			dialogue.SetActive(false);
			ArtChar4a.SetActive(false);
			ArtBG1.SetActive(false);
			ArtBG2.SetActive(true);
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(false); 
			allowSpace = false; 
			NextScene2Button.SetActive(true);
			}
		}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
		Char1name.text = ""; 
		Char1speech.text = "";
		Char2name.text = "YOU"; 
		Char2speech.text = "(There's no time to think! I'll grab a knife from the neighboring table!)";
		Char3name.text = "";
		Char3speech.text = "";
		gameHandlerObj.UpdateDateScore("Natas'sha", 1);
		primeInt = 99;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true); 
		allowSpace = true;
	} 
	public void Choice1bFunct(){ 
		Char1name.text = ""; 
		Char1speech.text = ""; 
		Char2name.text = "YOU"; 
		Char2speech.text = "HRRGHH--";
		Char3name.text = "";
		Char3speech.text = "";
		gameHandlerObj.UpdateDateScore("Natas'sha", -1);
		primeInt = 199;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true); 
		allowSpace = true;
	}

	public void SceneChange3e(){
		SceneManager.LoadScene("ScenePath3End");
	} 
	public void SceneChange1(){ 
		SceneManager.LoadScene("MainMenu");
	}
}


