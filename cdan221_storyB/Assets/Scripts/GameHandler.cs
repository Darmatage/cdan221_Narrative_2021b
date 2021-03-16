using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour{

		public static int dateBaz = 0;
		public static int dateNatassha = 0;
		public static int dateJett = 0;
		//public GameObject textDateScore;
		

		
		public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;



       void Awake(){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
				UpdateDateScore("Baz", dateBaz);
				UpdateDateScore("Natas'sha", dateNatassha);
				UpdateDateScore("Jett", dateJett);
        }

        public void Update(){
                if (Input.GetKeyDown(KeyCode.Escape)){
					Debug.Log ("I hit escape!");
                        if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }
                }
        }
		
		public void UpdateDateScore(string dateName, int score){
			if (dateName == "Baz"){
				dateBaz += score;
				Debug.Log("Current Baz Stat = " + dateBaz);
			}
			else if (dateName == "Natas'sha"){
				dateNatassha += score;
				Debug.Log("Current Natas'sha Stat = " + dateNatassha);
			}
			else if (dateName == "Jett"){
				dateJett += score;
				Debug.Log("Current Jett Stat = " + dateJett);
			}
		}
		
		public int WhatIsDateScore(string dateName){
                if (dateName == "Baz"){
				return dateBaz;
			}
			else if (dateName == "Natas'sha"){
				return dateNatassha;
			}
			else if (dateName == "Jett"){
				return dateJett;
			}else{return 0;}
				
        }
		
		
		
		
		
        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void RestartGame(){
                Time.timeScale = 1f;
                //restart the game:
                //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
SceneManager.LoadScene ("MainMenu");
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }

 

        //void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Scene0");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}