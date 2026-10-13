
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

}
