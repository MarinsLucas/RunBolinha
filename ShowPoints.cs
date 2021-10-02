/*
Script que mostra todas as pontuações no menu de seleção de nível
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPoints : MonoBehaviour
{
    public GameObject level1estrela;
    public Text level1texto;
    public GameObject level2estrela;
    public Text level2texto;
    public GameObject level3estrela;
    public Text level3texto;
    public GameObject level4estrela;
    public Text level4texto;
    public GameObject level5estrela;
    public Text level5texto;
    public GameObject level6estrela;
    public Text level6texto;
    public GameObject level7estrela;
    public Text level7texto;
    public GameObject level8estrela;
    public Text level8texto;
    public GameObject level9estrela;
    public Text level9texto;
    public GameObject level10estrela;
    public Text level10texto;
    public GameObject level11estrela;
    public Text level11texto;
    public GameObject level12estrela;
    public Text level12texto;
    public GameObject level13estrela;
    public Text level13texto;
    public GameObject level14estrela;
    public Text level14texto;
    public GameObject level15estrela;
    public Text level15texto;
    public GameObject level1p;
    public GameObject level2p;
    public GameObject level3p;
    public GameObject level4p;
    public GameObject level5p;
    public GameObject level6p;
    public GameObject level7p;
    public GameObject level8p;
    public GameObject level9p;
    public GameObject level10p;
    public GameObject level11p;
    public GameObject level12p;
    public GameObject level13p;
    public GameObject level14p;
    public GameObject level15p;

    void FixedUpdate()
    {
        if (PointBoard.level1com)
        {
            level1estrela.SetActive(true);
            level1p.SetActive(true);
            level1texto.text = (PointBoard.level1point).ToString("0");
        }
        if (PointBoard.level2com)
        {
            level2estrela.SetActive(true);
            level2p.SetActive(true);
            level2texto.text = (PointBoard.level2point).ToString("0");
        }
        if (PointBoard.level3com)
        {
            level3estrela.SetActive(true);
            level3p.SetActive(true);
            level3texto.text = (PointBoard.level3point).ToString("0");
        }
        if (PointBoard.level4com)
        {
            level4estrela.SetActive(true);
            level4p.SetActive(true);
            level4texto.text = (PointBoard.level4point).ToString("0");
        }
        if (PointBoard.level5com)
        {
            level5estrela.SetActive(true);
            level5p.SetActive(true);
            level5texto.text = (PointBoard.level5point).ToString("0");
        }
        if (PointBoard.level6com)
        {
            level6estrela.SetActive(true);
            level6p.SetActive(true);
            level6texto.text = (PointBoard.level6point).ToString("0");
        }
        if (PointBoard.level7com)
        {
            level7estrela.SetActive(true);
            level7p.SetActive(true);
            level7texto.text = (PointBoard.level7point).ToString("0");
        }
        if (PointBoard.level8com)
        {
            level8estrela.SetActive(true);
            level8p.SetActive(true);
            level8texto.text = (PointBoard.level8point).ToString("0");
        }
        if (PointBoard.level9com)
        {
            level9estrela.SetActive(true);
            level9p.SetActive(true);
            level9texto.text = (PointBoard.level9point).ToString("0");
        }
        if (PointBoard.level10com)
        {
            level10estrela.SetActive(true);
            level10p.SetActive(true);
            level10texto.text = (PointBoard.level10point).ToString("0");
        }
        if (PointBoard.level11com)
        {
            level11estrela.SetActive(true);
            level11p.SetActive(true);
            level11texto.text = (PointBoard.level11point).ToString("0");
        }
        if (PointBoard.level12com)
        {
            level12estrela.SetActive(true);
            level12p.SetActive(true);
            level12texto.text = (PointBoard.level12point).ToString("0");
        }
        if (PointBoard.level13com)
        {
            level13estrela.SetActive(true);
            level13p.SetActive(true);
            level13texto.text = (PointBoard.level13point).ToString("0");
        }
        if (PointBoard.level14com)
        {
            level14estrela.SetActive(true);
            level14p.SetActive(true);
            level14texto.text = (PointBoard.level14point).ToString("0");
        }
        if (PointBoard.level15com)
        {
            level15estrela.SetActive(true);
            level15p.SetActive(true);
            level15texto.text = (PointBoard.level15point).ToString("0");
        }
    }
}
