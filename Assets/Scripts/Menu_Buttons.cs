using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Buttons : MonoBehaviour {
    public GameObject MenuPanel;
    public GameObject OptionsPanel;

    public Toggle audio;
    public Toggle sound;

	// Use this for initialization
	void Start () {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }

    public void showMenuPanel()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }

    public void showOptionsPanel()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);

        int a = PlayerPrefs.GetInt("audio", 1);
        int s = PlayerPrefs.GetInt("sound", 1);
        if(a == 1)
        {
            audio.isOn = true;
        }
        else { audio.isOn = false; }
        if(s == 1)
        {
            sound.isOn = true;
        }
        else { sound.isOn = false; }
    }

    public void startGame()
    {
        Application.LoadLevel("level1");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void onSoundChanged(bool value)
    {
        if (value)
        {
            PlayerPrefs.SetInt("sound", 1);
        }
        else
        {
            PlayerPrefs.SetInt("sound", 0);
        }
    }

    public void onAudioChanged(bool value)
    {
        if (value)
        {
            PlayerPrefs.SetInt("audio", 1);
        }
        else
        {
            PlayerPrefs.SetInt("audio", 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
