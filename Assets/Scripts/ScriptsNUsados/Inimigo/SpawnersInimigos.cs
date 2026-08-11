using UnityEngine;

public class SpawnersInimigos : MonoBehaviour
{
    public GameObject spawner,inimigo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnInimgio", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnInimgio()
    {
        GameObject inimigo_ = Instantiate(inimigo, spawner.transform.position, Quaternion.identity);
    }

}
