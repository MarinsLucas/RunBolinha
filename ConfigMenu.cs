/*
Esse script é utilizado no menu principal, em uma aba criada especificamente para as configurações sobre o jogo
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class ConfigMenu : MonoBehaviour
{

    public GameObject normal;
    public GameObject dificil;
    public GameObject serBR;
    public GameObject iniciante;
    public GameObject Menu;
    public GameObject config;
    public AudioMixer audioMixer;
    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

        Menu.SetActive(false);
    }

    public void normalButton()
    {
        normal.SetActive(false);
        dificil.SetActive(true);
        Movimento.fowardForce = 6000f;
    }
    public void hardButton()
    {
        dificil.SetActive(false);
        serBR.SetActive(true);
        Movimento.fowardForce = 40000f;
    }
    public void serBRButton()
    {
        serBR.SetActive(false);
        iniciante.SetActive(true);
        Movimento.fowardForce = 3000f;
    }
    public void incianteButton()
    {
        iniciante.SetActive(false);
        normal.SetActive(true);
        Movimento.fowardForce = 4500f;
    }

    public void voltar()
    {
        Menu.SetActive(true);
        config.SetActive(false);
        //Jogar.mainmenu.SetActive(true);
    }

    public void SetGeneralVolume(float volume)
    {
        audioMixer.SetFloat("GeneralVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex) {

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
     }

}
