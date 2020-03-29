using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    private Aviao aviao;
    private GeradorDeObstaculos geradorDeObstaculos;
    private UIGameOver gameOverInterface;
    private UIGameInterface gameInterface;
    private ControlaDificuldade controlaDificuldade;
    public Pontuacao pontuacao;

    private void Start()
    {
        aviao = FindObjectOfType<Aviao>();
        controlaDificuldade = FindObjectOfType<ControlaDificuldade>();
        geradorDeObstaculos = FindObjectOfType<GeradorDeObstaculos>();
        gameOverInterface = FindObjectOfType<UIGameOver>();
        gameInterface = FindObjectOfType<UIGameInterface>();
    }

   public void FinalizarJogo()
    {
        Time.timeScale = 0;
        pontuacao.SalvarNovoRecorde();
        gameOverInterface.MostrarInterface(true);
        gameInterface.MostrarInterface(false);
    }

    public void ReiniciarJogo()
    {
        gameOverInterface.MostrarInterface(false);
        gameInterface.MostrarInterface(true);
        Time.timeScale = 1;
        aviao.ReiniciarPosicao();
        controlaDificuldade.ZerarDificuldade();
        geradorDeObstaculos.DestruirObstaculos();
        pontuacao.ZerarPontos();
    }
    public void IniciarJogo()
    {
        aviao.GetComponent<Rigidbody2D>().simulated = true;
        geradorDeObstaculos.Ativar(true);
    }
}
