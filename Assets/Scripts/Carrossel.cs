using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;

    private Vector3 posicaoInicial;
    private float tamanhoDaImagem;
    void Start()
    {
        posicaoInicial = transform.position;
        tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x * transform.localScale.x;
    }

    void Update()
    {      
        float deslocamento = Mathf.Repeat(velocidade.valor * Time.time, tamanhoDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;

    }
}
