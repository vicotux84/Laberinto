using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour{
    public PointGame pointGame;
    public AudioClip _audio;
    public GameObject _Colectable;
    void Start(){
        pointGame._total_Items++;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"){
            _Colectable.SetActive(false);
            pointGame._colectables++;
            pointGame.SoundFX(_audio);
        }
    }
}
