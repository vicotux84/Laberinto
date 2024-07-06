using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_opciones : MonoBehaviour{
    
	public GameObject opciones, mainMenu;

    public void Opciones() {
        opciones.SetActive(true);
        mainMenu.SetActive(false);        
    }
    public void MainMenu() {
        opciones.SetActive(false);
        mainMenu.SetActive(true);        
    }
}
