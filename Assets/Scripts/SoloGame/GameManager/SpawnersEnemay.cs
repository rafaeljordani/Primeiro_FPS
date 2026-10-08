using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class SpawnersEnemay : MonoBehaviour
{

    public GameObject inimigo;
    //prefab do inimigo

    public GameObject spawner1, spawner2, spawner3, spawner4, spawner5;
    //locais dos spanwners

    public int numSpawn = 10, life = 100, pointsToNextWave, wave;
    
    public MainPoints mainPoints;


    void Start()
    {
        spawnEnemay(inimigo);
        //start os spawners do jogo e inicia a primeira wave
    }
    void Update()
    {
        spawnNextWave();
    }
    public void spawnEnemay(GameObject inimigo)
    {
        int numSpawnOnly = numSpawn/5;
        //divide o numero de inimigos a serem spawnados pelo numero de spawners, para que cada spawner spawn o mesmo numero de inimigos
        
        spawn(spawner1, numSpawnOnly);
        spawn(spawner2, numSpawnOnly);
        spawn(spawner3, numSpawnOnly);
        spawn(spawner4, numSpawnOnly);
        spawn(spawner5, numSpawnOnly);

        setPointsNextWave();
    }
    public void setPointsNextWave()
    {
        pointsToNextWave = numSpawn * 10 + mainPoints.points;
        //seta os pontos nessecarios para a proxima wave começar
    }
    public void spawnNextWave()
    {
        if (pointsToNextWave == mainPoints.points)
        {
            wave++;
            numSpawn += 5;
            spawnEnemay(inimigo);
        }
        else
        {
            return;
        }
        //verifica se o player ja tem os pontos necessarios para spawnar a proxima wave, se sim, spawn a proxima wave e aumenta o numero de inimigos spawnados
    }
    public void spawn(GameObject Spawners, int numSpawnOnly)
    {
        for (int i = 0; i < numSpawnOnly; i++)
        {
            GameObject inimigo_ = Instantiate(inimigo, Spawners.transform.position, Quaternion.identity);
            // aqui da spawn no inimigo no local do spawner
        }
    }

}
