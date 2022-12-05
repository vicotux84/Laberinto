using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Application.Quit();
        Debug.Log("deteniedo juego");
    }

    // Update is called once per frame
    public void UpdateScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
