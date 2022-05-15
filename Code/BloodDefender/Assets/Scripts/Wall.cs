using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //colisão com player
        if (collision.gameObject.CompareTag("Green") || collision.gameObject.CompareTag("Purple"))
        {
            anim.SetBool("Hit", true);
            StartCoroutine(On());

        }
        else
        { 
            anim.SetBool("Hit", false);
        }

        IEnumerator On()
        {

            yield return new WaitForSeconds(0.25f);    
            
            anim.SetBool("Hit", false);
               
            

        }
    }
}
