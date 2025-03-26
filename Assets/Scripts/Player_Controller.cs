using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

public class Player_Controller : MonoBehaviour
{

    public Animator Animator;
    public float Rspeed = 0.1f;
    public float Lspeed = -0.1f;
    public int Health;
    public int maxHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * Rspeed , 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Animator.SetBool("right", true);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Animator.SetBool("right", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * Lspeed, 0);
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Animator.SetBool("left", true);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Animator.SetBool("left", false);
        }
        if (Health <= 0)
        {
            SceneManager.LoadScene(0);
        }

      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Flak"))
        {
            Debug.Log("Hit");
            Health -= 1;
        }
    }
}
