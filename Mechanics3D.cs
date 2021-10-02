using UnityEngine;

public class Mechanics3D : MonoBehaviour
{

    public GameObject camera2d;
    public GameObject camera3d;


    void OnTriggerEnter()
    {
            camera3d.SetActive(true);
            camera2d.SetActive(false);
    }
}
