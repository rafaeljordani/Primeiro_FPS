
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class TestSave : MonoBehaviour
{
    public TMP_InputField playerNameInput;

 public void saveJson()
    {

        SaveSystem saveSystem = new SaveSystem();

        LeaderboardData dados = new LeaderboardData();

        PlayerResult jogador = new PlayerResult();
        jogador.playerName = playerNameInput.text;
        jogador.score = PlayerPrefs.GetInt("pontosTemp");
        dados.jogadores.Add(jogador);

        saveSystem.Salvar(dados);
    }
}
