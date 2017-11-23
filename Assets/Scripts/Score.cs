using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    private Controls player;

    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        player = FindObjectOfType<Controls>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Crystals: " + player.crystals + "/23";
	}
}
