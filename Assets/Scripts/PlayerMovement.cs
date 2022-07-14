

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Скорость ходьбы")]
    public float m_Speed = 5f;
    [Header("Скорость бега")]
    public float m_RunSpeed = 10f;
    [Header("Сила прыжка")]
    public float m_JumpPower = 200;

    public bool ground;

    public Rigidbody rb;
   
    void Start()
    {
    }

    
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.forward * m_RunSpeed * Time.deltaTime;

            }
            else
            {
                transform.localPosition += transform.forward * m_Speed * Time.deltaTime;

            }

 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * m_Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
               transform.localPosition += transform.right * m_RunSpeed * Time.deltaTime; 
            }
            else
            {
                transform.localPosition += transform.right * m_Speed * Time.deltaTime;

            }
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += -transform.right * m_RunSpeed * Time.deltaTime;
            }
            else
            {
                transform.localPosition += -transform.right * m_Speed * Time.deltaTime;

            }
            
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (ground) 
            {
                rb.AddForce(transform.up * m_JumpPower);
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") ground = true;
       
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") ground = false;
    }
}
