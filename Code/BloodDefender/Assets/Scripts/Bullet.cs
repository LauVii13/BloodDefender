using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private AudioSource tiro
        ;
    [SerializeField] float speed;
    [SerializeField] ParticleSystem greenEfect;
    [SerializeField] ParticleSystem purpleEfect;
    [SerializeField] ParticleSystem redEfect;

    private void Start()
    {
        tiro = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void souds()
    {
        tiro.Play();
        StartCoroutine(On());
    }
    IEnumerator On()
    {
        yield return new WaitForSeconds(1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.CompareTag("Green"))
        {
            souds();
            Instantiate(greenEfect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("purple"))
        {
            Instantiate(purpleEfect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Rbc"))
        {
            Instantiate(redEfect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Sign"))
        {
            Instantiate(redEfect, transform.position, transform.rotation);
            Destroy(this.gameObject);

        }
    }
}
