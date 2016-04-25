using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsScript : MonoBehaviour {


    //private float slider = 1.0f;
    private float musicvolume = 1.0f;
    public Slider musicSlider;

    
    private float soundEffectsvolume = 1.0f;
    public Slider soundEffectsSlider;

    private float brightnesslevel = 1.0f;
    public Slider brightnessSlider;

    public string mainmenu;
    public string credits;




    // Use this for initialization
    void Start () {
        musicSlider.value = PlayerPrefs.GetFloat("Music Slider", musicSlider.value);
        brightnessSlider.value = PlayerPrefs.GetFloat("Brightness Level", brightnessSlider.value);
    }


    public void MusicSlider()
    {
        musicvolume = musicSlider.value;//sets the volume variable to be the same as the slider
        PlayerPrefs.SetFloat("Music Slider", musicSlider.value);//sets the value of the slider
        AudioListener.volume = musicvolume;
       
    }

    public void BrightnessSlider()
    {
        brightnesslevel = brightnessSlider.value;//sets the volume variable to be the same as the slider
        PlayerPrefs.SetFloat("Brightness Slider", brightnessSlider.value);//sets the value of the slider
     //   AudioListener.volume = musicvolume;

    }

    // Update is called once per frame
    void Update () {
	
	}


    public void MainMenu()//FUNCTION TO CHANGE SCENE
    {
        SceneManager.LoadScene(mainmenu);
    }
    public void Credits()
    {
        SceneManager.LoadScene(credits);//FUNCTION TO CHANGE SCENE
    }
}
