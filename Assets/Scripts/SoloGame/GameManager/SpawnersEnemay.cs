using UnityEngine;

public class SpawnersEnemay : MonoBehaviour
{

    public GameObject spawner, inimigo;
    public int numSpawn = 10;


    void Start()
    {
        spawnEnemay(inimigo, spawner, numSpawn);
    }

    public void spawnEnemay(GameObject inimigo, GameObject spawner, int numSpawn)
    {
        for(int i = 0; i< numSpawn; i++)
        {
            GameObject inimigo_ = Instantiate(inimigo, spawner.transform.position, Quaternion.identity);
        }  
    }

    //Lembrar que voce esta tenado fazer um metodo que faca que quando voce matar todos os inimigos spawnados, o jogo faca a proxima wave e spawners mais inimigos
}
