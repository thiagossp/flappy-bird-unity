using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameInterface : MonoBehaviour
{
    [SerializeField]
    private Text textPontuacao;
    [SerializeField]
    private GameObject gameInterface;

    public void AtualizarPontuacao(int pontuacao)
    {
        textPontuacao.text = pontuacao.ToString();
    }

    public void MostrarInterface(bool value) 
    {
        gameInterface.SetActive(value);
    }

}
