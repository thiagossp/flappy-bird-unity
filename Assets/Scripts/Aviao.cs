using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]
    private float forca = 10;
    [SerializeField]
    private Vector3 posicaoInicial;
    private Diretor diretor;
    private Pontuacao pontuacao;
    private bool deveImpulsionar = false;
    private Animator animacao;

    public Rigidbody2D RigidbodyAviao;
    // Start is called before the first frame update
    private void Awake()
    {
        RigidbodyAviao = GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Diretor>();
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        animacao = GetComponent<Animator>();
    }

    private void Update()
    {
        if (RigidbodyAviao.velocity.y <= 0)
        {
            animacao.SetFloat("VelocidadeY", RigidbodyAviao.velocity.y/2);
        }
        else
        {
            animacao.SetFloat("VelocidadeY", RigidbodyAviao.velocity.y/2);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            deveImpulsionar = true;
        }
        
    }
    private void FixedUpdate()
    {
        if (deveImpulsionar)
        {
            Impulsionar();
        }
        
    }
    
    private void Impulsionar()
    {
        if (RigidbodyAviao.velocity.y >= 0)
        {
            RigidbodyAviao.velocity = Vector2.zero;
        }
        RigidbodyAviao.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
        deveImpulsionar = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        diretor.FinalizarJogo();
    }

    private void OnTriggerEnter2D(Collider2D objectCollier)
    {
        if (objectCollier.tag == "Pontuar")
        {
            pontuacao.AdicionarPontos(1);
        }
    }

    public void ReiniciarPosicao()
    {
        transform.position = posicaoInicial;
    }
}
;