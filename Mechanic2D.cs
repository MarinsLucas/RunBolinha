/*
Essa mecânica altera a perspectiva do jogo
*/
using UnityEngine;

public class Mechanic2D : MonoBehaviour
{

    public GameObject camera2d;
    public GameObject camera3d;

   
    void OnTriggerEnter()
    {
            camera2d.SetActive(true);
            camera3d.SetActive(false);
    }
}
