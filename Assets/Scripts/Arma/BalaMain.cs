using UnityEngine;

public class BalaMain : MonoBehaviour
{
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Inimigo"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Debug.Log("Inimigo atingido!");
            Player.GetComponent<PlayerInteracao>().Pontuacao += 10;
        }
        else if ((collision.gameObject.CompareTag("Chao")) || (collision.gameObject.CompareTag("Parede")))
        {
            Destroy(this.gameObject);
            Debug.Log("Bala atingiu o chão ou parede!");
        }

    }
}
