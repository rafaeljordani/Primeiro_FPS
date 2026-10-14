
using UnityEngine;
using System.IO;

public class SaveSystem
{
    private string caminho = Application.persistentDataPath + "/leaderboard.json";

    public void Salvar(LeaderboardData dados)
    {
        string json = JsonUtility.ToJson(dados, true);

        File.WriteAllText(caminho, json);

        Debug.Log("Ranking salvo!");
        Debug.Log(Application.persistentDataPath);
    }

    public LeaderboardData Carregar()
    {
        if (!File.Exists(caminho))
        {
            return new LeaderboardData();
        }

        string json = File.ReadAllText(caminho);

        LeaderboardData dados = JsonUtility.FromJson<LeaderboardData>(json);

        return dados;
    }

}
