using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField]
    private Text TextValorRecord;
    [SerializeField]
    private Text TextValorPontuacao;
    [SerializeField]
    private GameObject interfaceGameOver;
    [SerializeField]
    private Image posicaoImagemMedalha;
    [SerializeField]
    private Sprite imagemMedalhaOuro;
    [SerializeField]
    private Sprite imagemMedalhaPrata;
    [SerializeField]
    private Sprite imagemMedalhaBronze;

    private int recorde;
    private int pontuacao;

    public void AtualizarInterface()
    {
        pontuacao = PlayerPrefs.GetInt("pontuacao");
        TextValorPontuacao.text = pontuacao.ToString();
        recorde = PlayerPrefs.GetInt("recorde");
        TextValorRecord.text = recorde.ToString();
        VerificarMedalha();
    }
    public void MostrarInterface(bool value)
    {
        AtualizarInterface();
        interfaceGameOver.SetActive(value);
    }

    private void VerificarMedalha()
    {
        if (pontuacao >= recorde)
        {
            posicaoImagemMedalha.sprite = imagemMedalhaOuro;
        }
        else if (pontuacao > recorde / 2)
        {
            posicaoImagemMedalha.sprite = imagemMedalhaPrata;
        }
        else
        {
            posicaoImagemMedalha.sprite = imagemMedalhaBronze;
        }
    }
}
