using UnityEngine;
/**
Modifica los parámetros del animator del Personaje
Autor: Daiana Andrea Armenta Maya
*/
public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spRenderer;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Los inicializamos:
        rb = GetComponent<Rigidbody2D>();
        spRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Modificar el parámetro del animator 'velocidad'
        animator.SetFloat("velocidad", Mathf.Abs(rb.linearVelocityX));
        spRenderer.flipX = rb.linearVelocityX < 0;
        animator.SetBool("enPiso",EstadoPersonaje.enPiso);
        
    }
}
