
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class playerscript : MonoBehaviour
{
    public int jumpforce = 2;
    public int moveForce = 2;
    private bool IsGrounded = true;
    public int playerHealth = 100;
    public TextMeshProUGUI healthText;


    private void Start()
    {
        healthText.text = "Health: " + playerHealth;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded)            //movement 
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-moveForce,0), ForceMode2D.Impulse);
            if(transform.rotation.y != 180)
                transform.Rotate(0,-180,0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(moveForce,0), ForceMode2D.Impulse);
            if(transform.rotation.y != 0)
                transform.Rotate(0,0,0);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Player collided with " + other.gameObject.tag);
        if(other.gameObject.CompareTag("ground"))                    //grounded or not
        {
            IsGrounded = true;
        }
        else if (other.gameObject.CompareTag("spike"))
        {
            Debug.Log("Player hit the spike");
            playerHealth -= 10;
            healthText.text = "Health: " + playerHealth;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "ground")
        {
            IsGrounded = false;
        }
    }
}
