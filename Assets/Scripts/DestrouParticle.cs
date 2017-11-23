using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrouParticle : MonoBehaviour {

    private ParticleSystem thisParticleSystem;
    // Use this for initialization

    public AudioSource snd;

	void Start () {
        thisParticleSystem = GetComponent<ParticleSystem>();
        if(PlayerPrefs.GetInt("sound", 1) == 0)
        {
            snd.mute = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (thisParticleSystem.isPlaying)
        {
            return;
        }
        Destroy(gameObject);
	}
}
