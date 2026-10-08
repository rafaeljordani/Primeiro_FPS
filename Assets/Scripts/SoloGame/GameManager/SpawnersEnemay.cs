using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class SpawnersEnemay : MonoBehaviour
{

    public GameObject spawner, inimigo;
    public int numSpawn = 10, life = 100, pointsToNextWave, wave;
    

    public MainPoints mainPoints;


    void Start()
    {
        spawnEnemay(inimigo, spawner, numSpawn);
    }
    void Update()
    {
        spawnNextWave();
    }

    public void spawnEnemay(GameObject inimigo, GameObject spawner, int numSpawn)
    {
        for(int i = 0; i< numSpawn; i++)
        {
            GameObject inimigo_ = Instantiate(inimigo, spawner.transform.position, Quaternion.identity);
        }
        setPointsNextWave();
    }



    public void setPointsNextWave()
    {
        pointsToNextWave = numSpawn * 10 + mainPoints.points;
        //Debug.Log("Points to next wave: " + pointsToNextWave);
        //Debug.Log("Current points: " + mainPoints.points);
    }

    public void spawnNextWave()
    {
        if (pointsToNextWave == mainPoints.points)
        {
            //Debug.Log("Spawning next wave...");
            wave++;
            numSpawn += 5;
            spawnEnemay(inimigo, spawner, numSpawn);
        }
        else
        {
            //Debug.Log("Not enough points to spawn next wave.");
            return;
        }
    }

    //Lembrar que voce esta tenado fazer um metodo que faca que quando voce matar todos os inimigos spawnados, o jogo faca a proxima wave e spawners mais inimigos
}
