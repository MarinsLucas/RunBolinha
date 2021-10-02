/*
Esse script é uma das bases para o funcionamento do meu jogo: ele define que colisões com obstáculos faz com que o jogador perca a fase e tenha que repeti-la
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public Rigidbody rb;
    public Movimento movement;
    public static bool perdeu = false;
    public AudioSource colisionLenta;
    public AudioSource colisionSound; 

    void OnCollisionEnter(Collision infoCol)
    {
        if (!EndTrigger.ganhou)
        {
            if (infoCol.collider.tag == "obstaculo")
            {
                rb.AddForce(0, 2000, 0);
                movement.enabled = false;
                perdeu = true;
                if (SlowMo.slowed)
                {
                    colisionLenta.Play();
                }
                else
                {
                    colisionSound.Play();
                }

                FindObjectOfType<Controlador_do_jogo>().fimdejogo();
                FindObjectOfType<TutorialTrigger>().func();
            }
            if(infoCol.collider.tag == "voidflor")
            {
                rb.AddForce(0, 2000, 0);
                movement.enabled = false;
                perdeu = true;
                if (SlowMo.slowed)
                {
                    colisionLenta.Play();
                }
                else
                {
                    colisionSound.Play();
                }

                FindObjectOfType<Controlador_do_jogo>().fimdejogoQueda();
                FindObjectOfType<TutorialTrigger>().func();
            }
        }
    }
}
