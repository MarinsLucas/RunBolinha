/*
script responsável por todo menu principal e menu de seleção de nível
*/

using UnityEngine;
using UnityEngine.SceneManagement;


public class Jogar : MonoBehaviour
{

    public GameObject menunivel;
    public GameObject mainmenu;
    public GameObject configMenu;
    public AudioSource clickMenu; 
 

    public void StartGamer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void Quit ()
    {
        Application.Quit();
        Debug.Log("FECHOOU");
    }
    public void menudeniveis()
    {
        mainmenu.SetActive(false);
        menunivel.SetActive(true);
       
    }
    public void menu()
    {
        mainmenu.SetActive(true);
        menunivel.SetActive(false);
    }
    public void config()
    {
            configMenu.SetActive(true);
            mainmenu.SetActive(false);          
    }
    public void n1()
    {
        SceneManager.LoadScene(1);
       // Score.point = ConfigMenu.maxpoint;
    }
    public void n2()
    {
        SceneManager.LoadScene(2);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n3()
    {
        SceneManager.LoadScene(3);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n4()
    {
        SceneManager.LoadScene(4);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n5()
    {
        SceneManager.LoadScene(5);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n6()
    {
        SceneManager.LoadScene(6);
       // Score.point = ConfigMenu.maxpoint;
    }
    public void n7()
    {
        SceneManager.LoadScene(7);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n8()
    {
        SceneManager.LoadScene(8);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n9()
    {
        SceneManager.LoadScene(9);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n10()
    {
        SceneManager.LoadScene(10);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n11()
    {
        SceneManager.LoadScene(11);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n12()
    {
        SceneManager.LoadScene(12);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n13()
    {
        SceneManager.LoadScene(13);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n14()
    {
        SceneManager.LoadScene(14);
        //Score.point = ConfigMenu.maxpoint;
    }
    public void n15()
    {
        SceneManager.LoadScene(15);
        //Score.point = ConfigMenu.maxpoint;
    }


    public void som()
    {
        clickMenu.Stop();
        clickMenu.Play();
    }
}
