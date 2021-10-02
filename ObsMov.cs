/*
Cria um obstáculo que se move de um lado para o outro
*/
using UnityEngine;

public class ObsMov : MonoBehaviour
{
    private Vector3 startPosition;

    [SerializeField]
    private float frequency = 5f;

    [SerializeField]
    private float magnitude = 5f;

    [SerializeField]
    private float offset = 0f;

    void Start()
    {
        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        transform.position = startPosition + transform.up * Mathf.Sin(Time.time * frequency + offset) * magnitude;
    }
}
