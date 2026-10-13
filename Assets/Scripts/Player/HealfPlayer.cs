using UnityEngine;

public class HealfPlayer : MonoBehaviour
{
    private int lifePlayer = 100;



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
        Destroy(gameObject);
        
    }


}
