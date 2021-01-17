using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Musicmgr: MonoBehaviour {
    public AudioSource playaudio;
    // Start is called before the first frame update
    void Start() {}
    // Update is called once per frame
    void Update() {}
    public void PlayMusic() {
        playaudio.Play();
        Debug.Log("play");
    }
}
