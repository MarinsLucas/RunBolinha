using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public Controlador_do_jogo gameManager;
    public static bool ganhou = false;
    public AudioClip newTrack;
    public static bool musicaTocando;
    void Start()
    {
        ganhou = false;
    }
    void OnTriggerEnter()
    {
        ganhou = true;
        if (!Colision.perdeu)
        {
            gameManager.completeLevel();
            FindObjectOfType<MusicManager>().MusicaFinal();

            musicaTocando = false; 
        }
    }
}
