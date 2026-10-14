using TMPro;
using UnityEngine;

public class CarregarJson : MonoBehaviour
{
    public TextMeshProUGUI playerName,playerScore;


    void Start()
    {
        Carregar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Carregar()
    {
        SaveSystem saveSystem = new SaveSystem();

        LeaderboardData dados = saveSystem.Carregar();

        foreach (PlayerResult jogador in dados.jogadores)
        {
            string player = jogador.playerName;
            int score = jogador.score;
            playerName.text = player.ToString();
            playerScore.text = score.ToString();
        }
    }



}
