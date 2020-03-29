using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pontuacao : MonoBehaviour
{
    private int pontuacaoAtual;
    private AudioSource audioPontuacao;
    private UIGameInterface uiGameInterface;

    private void Awake()
    {
        audioPontuacao = GetComponent<AudioSource>();
    }
    private void Start()
    {
        uiGameInterface = FindObjectOfType<UIGameInterface>();
    }
    public void AdicionarPontos(int pontos)
    {
        pontuacaoAtual += pontos;
        PlayerPrefs.SetInt("pontuacao", pontuacaoAtual);
        uiGameInterface.AtualizarPontuacao(pontuacaoAtual);
        audioPontuacao.Play();
    }
    public void ZerarPontos()
    {
        pontuacaoAtual = 0;
        uiGameInterface.AtualizarPontuacao(pontuacaoAtual);
        PlayerPrefs.SetInt("pontuacao", pontuacaoAtual);
    }

    public void SalvarNovoRecorde()
    {
        int recordAtual = PlayerPrefs.GetInt("recorde");
        if (recordAtual < pontuacaoAtual)
        {
            PlayerPrefs.SetInt("recorde", pontuacaoAtual);
        }
    }
}
