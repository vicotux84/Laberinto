using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu_opciones : MonoBehaviour{
    
	public Dropdown Dropdown_antiAliasing, 
	Dropdown_Quality, Dropdown_Vsync;
	
	void Awake(){
		Dropdown_antiAliasing.value=PlayerPrefs.GetInt ("antiAliasing");
		Dropdown_Quality.value=PlayerPrefs.GetInt("SetQuality");
		Dropdown_Vsync.value=PlayerPrefs.GetInt("VsynQuality");
	}
	
	public void antiAliasing_Quality (int Level){
		QualitySettings.antiAliasing = Level;
	}
	
	public void UpdateQuality(int Quality) {
        QualitySettings.SetQualityLevel(Quality);
    }
	public void Vsync(int Vsync){
		QualitySettings.vSyncCount = Vsync;
	}
	
	void OnDisable(){
		PlayerPrefs.SetInt ("antiAliasing",Dropdown_antiAliasing.value);
		PlayerPrefs.SetInt ("SetQuality",Dropdown_Quality.value);
		PlayerPrefs.SetInt ("VsynQuality",Dropdown_Vsync.value);		
	}
}
