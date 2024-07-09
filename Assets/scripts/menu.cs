using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour{
	
	public Dropdown Dropdown_Full;
    
    public void Quit(){
        Debug.Log("deteniedo juego");
		Application.Quit();
        
    }
	public void cursortrue(){
		Cursor.visible = true;
	}
	public void cursorFalse(){
		Cursor.visible = false;
	}

    public void Awake(){
		Dropdown_Full.value=PlayerPrefs.GetInt("SetFullScreen");
    }
	public void OnDisable(){
        PlayerPrefs.SetInt ("SetFullScreen",Dropdown_Full.value);
    }
	public void fullScreen(int Level){
		if(Level==0){
			Screen.fullScreen = false;
		}else if(Level==1){
			Screen.fullScreen = true;
		}
	}
    public void UpdateQuality(int Quality) {
        QualitySettings.SetQualityLevel(Quality);
    }
        public void Vsync(int Vsync){
	QualitySettings.vSyncCount = Vsync;
	}
    public void antiAliasing_Quality (int Level){
	QualitySettings.antiAliasing = Level;
	}

    public void _LoadScene(string scene) {
          SceneManager.LoadScene(scene);
    }
}
