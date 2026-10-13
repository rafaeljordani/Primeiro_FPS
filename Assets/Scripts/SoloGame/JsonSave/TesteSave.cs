
using UnityEngine;

public class TestSave : MonoBehaviour
{
    public string playerName;


    void Start()
    {
        SaveSystem saveSystem = new SaveSystem();

        LeaderboardData dados = new LeaderboardData();

        PlayerResult jogador = new PlayerResult();
        jogador.playerName = playerName;
        jogador.score = PlayerPrefs.GetInt("pontosTemp");
        dados.jogadores.Add(jogador);

        saveSystem.Salvar(dados);
    }


    public void ReceberTexto(string texto)
    {
        playerName = texto;
    }
}
