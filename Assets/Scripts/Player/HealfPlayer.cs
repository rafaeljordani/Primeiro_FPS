using Unity.Profiling.LowLevel;
using UnityEngine;

public class HealfPlayer : MonoBehaviour
{
    public int lifePlayer = 100;
    public ChangeScenes ChangeScenes;
    public MainPoints mainPoints;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void takeDamage(int damage)
    {
        lifePlayer -= damage;
        Debug.Log("Vida do Player: " + lifePlayer);
        if (lifePlayer <= 0)
        {
            die();
        }
    }

    public void die()
    {

        PlayerPrefs.SetInt("pontosTemp", mainPoints.points);
        ChangeScenes.ChangeScene("GameOver");
    }


}
