/*
Esse script é utilizado em um gamemanager que estará presente em cada uma das fases do jogo
Essas variáveis de pontuação estão nesse script para que fosse criado um painel de pontuações no menu de níveis.
Há bastante espaço para melhoramentos. 
*/
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Audio; 

public class Controlador_do_jogo : MonoBehaviour
{
    public float delay = 2f;
    public GameObject mensagemFinal;
    public GameObject gameOver;
    public GameObject caiuOtario; 
    public GameObject score;
    public AudioSource newTrack;
    public static int pontosTotais = 0; 

    void Start()
    {
        if (EndTrigger.musicaTocando == false)
        {
            FindObjectOfType<MusicManager>().IniciaMusica();
            EndTrigger.musicaTocando = true; 
        }

        SlowMo.slowed = false;
        Time.timeScale = 1f;
        Colision.perdeu = false;
        EndTrigger.ganhou = false;
        if (SceneManager.GetActiveScene().name=="Level 1") //Todas essas linhas poderiam ser economizadas através de um switch!!
        {
            Score.point = PointBoard.level1point;
        }
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            Score.point = PointBoard.level2point;
        }
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            Score.point = PointBoard.level3point;
        }
        if (SceneManager.GetActiveScene().name == "Level 4")
        {
            Score.point = PointBoard.level4point;
        }
        if (SceneManager.GetActiveScene().name == "Level 5")
        {
            Score.point = PointBoard.level5point;
        }
        if (SceneManager.GetActiveScene().name == "Level 6")
        {
            Score.point = PointBoard.level6point;
        }
        if (SceneManager.GetActiveScene().name == "Level 7")
        {
            Score.point = PointBoard.level7point;
        }
        if (SceneManager.GetActiveScene().name == "Level 8")
        {
            Score.point = PointBoard.level8point;
        }
        if (SceneManager.GetActiveScene().name == "Level 9")
        {
            Score.point = PointBoard.level9point;
        }
        if (SceneManager.GetActiveScene().name == "Level 10")
        {
            Score.point = PointBoard.level10point;
        }
        if (SceneManager.GetActiveScene().name == "Level 11")
        {
            Score.point = PointBoard.level11point;
        }
        if (SceneManager.GetActiveScene().name == "Level 12")
        {
            Score.point = PointBoard.level12point;
        }
        if (SceneManager.GetActiveScene().name == "Level 13")
        {
            Score.point = PointBoard.level13point;
        }
        if (SceneManager.GetActiveScene().name == "Level 14")
        {
            Score.point = PointBoard.level14point;
        }
        if (SceneManager.GetActiveScene().name == "Level 15")
        {
            Score.point = PointBoard.level15point;
        }
    }
    
   
    public void fimdejogo() //fun��o chamada quando o jogo � perdido -- chama fun��o para reiniciar (Restart) e fun��o para desativar as imagens depois. 
    {
            Invoke("Restart", delay);
            score.SetActive(false);
            gameOver.SetActive(true);
            Invoke("func", delay);       
    }
    public void fimdejogoQueda() //fun��o chamada quando o jogo � perdido -- chama fun��o para reiniciar (Restart) e fun��o para desativar as imagens depois. 
    {
        Invoke("Restart", delay);
        score.SetActive(false);
        caiuOtario.SetActive(true);
        Invoke("func", delay);
    }

    void func()
    {
        gameOver.SetActive(false);
        score.SetActive(true);
        EndTrigger.ganhou = false;
    }

    public void completeLevel()
    {
        mensagemFinal.SetActive(true);
        Time.timeScale = 1f;
        pontosTotais = pontosTotais + Score.point;
        Debug.Log(PointBoard.level1point);

        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            PointBoard.level1com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            PointBoard.level2com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            PointBoard.level3com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 4")
        {
            PointBoard.level4com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 5")
        {
            PointBoard.level5com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 6")
        {
            PointBoard.level6com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 7")
        {
            PointBoard.level7com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 8")
        {
            PointBoard.level8com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 9")
        {
            PointBoard.level9com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 10")
        {
            PointBoard.level10com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 11")
        {
            PointBoard.level11com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 12")
        {
            PointBoard.level12com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 13")
        {
            PointBoard.level13com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 14")
        {
            PointBoard.level14com = true;
        }
        if (SceneManager.GetActiveScene().name == "Level 15")
        {
            PointBoard.level15com = true;
        }
    }

    void Restart()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            PointBoard.level1point = PointBoard.level1point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            PointBoard.level2point = PointBoard.level2point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            PointBoard.level3point = PointBoard.level3point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 4")
        {
            PointBoard.level4point = PointBoard.level4point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 5")
        {
            PointBoard.level5point = PointBoard.level5point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 6")
        {
            PointBoard.level6point = PointBoard.level6point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 7")
        {
            PointBoard.level7point = PointBoard.level7point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 8")
        {
            PointBoard.level8point = PointBoard.level8point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 9")
        {
            PointBoard.level9point = PointBoard.level9point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 10")
        {
            PointBoard.level10point = PointBoard.level10point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 11")
        {
            PointBoard.level11point = PointBoard.level11point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 12")
        {
            PointBoard.level12point = PointBoard.level12point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 13")
        {
            PointBoard.level13point = PointBoard.level13point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 14")
        {
            PointBoard.level14point = PointBoard.level14point - 1;
        }
        if (SceneManager.GetActiveScene().name == "Level 15")
        {
            PointBoard.level15point = PointBoard.level15point - 1;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SlowMo.slowed = false;
        Time.timeScale = 1f;
        Colision.perdeu = false;
        EndTrigger.ganhou = false;
        Debug.Log(Score.point-1);
    }
}
