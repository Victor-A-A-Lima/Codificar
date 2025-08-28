using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{
    public int SaberAtual;

    //Uma variavel unica
    public static GameManeger instance;

    public Text TextodeSaberAtual;
    void Awake()
    {
        instance = this;
        //quando o jogo iniciar a variavel instance ira dar como valor o scrip GameManeger. 
    }

    void Start()
    {
        SaberAtual = 0;
        TextodeSaberAtual.text = "Pontuação: " + SaberAtual;
    }

    public void AumentarSaber(int SaberParaGanhar)
    {
        SaberAtual += SaberParaGanhar;
        TextodeSaberAtual.text = "Pontuação: " + SaberAtual;
    }
}
