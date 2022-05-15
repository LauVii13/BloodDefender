using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Vector2 moveInput;

    public GameObject bullet;
    bool hitted = false;
    bool loading = false;
    [SerializeField] Transform spawnBullet;
    [SerializeField] float reload;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isMoving", (Mathf.Abs(moveInput.x) > 0 || Mathf.Abs(moveInput.y) > 0));

        if (hitted == false)
        {
            Movement();
            Shoot();
        }
    }
    IEnumerator FOn()
    {
        yield return new WaitForSeconds(reload);
        loading = false;
    }

        void Shoot()
    {
        if (Input.GetButtonDown("Jump") && loading == false)
        {
            Instantiate(bullet, spawnBullet.position, transform.rotation);
            loading = true;
            StartCoroutine(FOn());
        }
    }



    void Movement()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.Translate(moveInput * Time.deltaTime * moveSpeed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //colisão com player
        if (collision.gameObject.CompareTag("Rbc"))
        {
            anim.SetBool("isHitted", true);
            hitted = true;

            StartCoroutine(On());
        }
        else
        {
            anim.SetBool("isHitted", false);
            hitted = false;
        }

        IEnumerator On()
        {

            yield return new WaitForSeconds(1f);
            
            if(hitted == true)
            {
                anim.SetBool("isHitted", false);
                hitted = false;
            }         
        }  
    }
}
