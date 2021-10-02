using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour
{
    public bool jumpAllowed;
    public Rigidbody rb;
    public static float fowardForce = 4500;
    public float sideForce;
    public float pingamento = 1;
    public int coef = 1;
    public static bool isGrounded = false;
    public static float volquicada; 
    public AudioSource bolaRolando;
    public AudioSource impactoBola;

    void Start()
    {
        sideForce = 50f;
        
    }

    void FixedUpdate()
    {
            //force rigth
            if (Input.GetKey("d"))
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                if (SlowMo.slowed)
                 {
                     rb.AddForce(2*sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                 }
            }
            //foce left
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                if (SlowMo.slowed)
                {
                    rb.AddForce(-2*sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        //Acelera��o pra frente
             rb.AddForce(0, 0, fowardForce * Time.deltaTime);
           
            

            //jump
        
        if (jumpAllowed == true)
        {
            if (Input.GetKey("space"))
            {
                rb.AddForce(0, 5, 0, ForceMode.Impulse);
            }
        }


    }

    public void Pausou()
    {
        bolaRolando.Stop();
        impactoBola.Stop();
    }
    public void Despausou()
    {
        if (isGrounded)
        {
            bolaRolando.Play();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "jump")
        {
            jumpAllowed = true;
            volquicada = (float) 1;
        }
        else
        {
            rb.AddForce(0, pingamento/coef, 0, ForceMode.Impulse);
            volquicada = (float)1 / coef;
        }
        bolaRolando.Play();
        impactoBola.Play();
        isGrounded = true; 
        
    }

    void OnCollisionExit(Collision other)
    {

        if (other.gameObject.tag == "jump")
        {
            jumpAllowed = false;
            coef = 1;
        }
        else
        {
            if (pingamento / coef < 0.5)
            {
                coef = 1;
            }
            else coef++;
        }
        bolaRolando.Stop();
        isGrounded = false; 
    }
   
}

