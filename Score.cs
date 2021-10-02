/*
Script que transforma a pontuação em um texto e o mostra na tela durante o jogo
*/
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int point =10;

    void Update()
    {
        scoreText.text = (point).ToString("0"); 
    }
}
