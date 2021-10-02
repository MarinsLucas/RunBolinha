using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject configMenu;
    public AudioMixer audioMixer;
    public Dropdown resolutionDropdown;
    public AudioSource clickMenu;

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

    }

    // Update is called once per frame
    void Update()
    {
        if (!Colision.perdeu)
        {
            if (!EndTrigger.ganhou)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    if (GameIsPaused)
                    {
                        Resume();
                    }
                    else
                    {
                        Pause();
                    }
                }
            }
        }
    }


    public void Resume()
    {
        if (SlowMo.slowed)
        {
            Time.timeScale = 0.5f;
        }
        else
        {
            Time.timeScale = 1f;
        }
        pauseMenuUI.SetActive(false);
        configMenu.SetActive(false);
        GameIsPaused = false;
        FindObjectOfType<Movimento>().Despausou();
    }

    public void loadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        FindObjectOfType<Movimento>().Pausou();
    }

    public void Config()
    {
        //liga a tela de configura��o e desliga a de menu
        configMenu.SetActive(true);
        pauseMenuUI.SetActive(false);

    }
    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetResolution(int resolutionIndex)
    {

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void fechaConfig()
    {
        configMenu.SetActive(false);
        pauseMenuUI.SetActive(true);
    }
    
    public void SetGeneralVolume(float volume)
    {
        audioMixer.SetFloat("GeneralVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void som()
    {
        clickMenu.Stop();
        clickMenu.Play();
    }
}
