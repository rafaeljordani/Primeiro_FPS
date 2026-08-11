using UnityEngine;
using UnityEngine.AI;

public class InimigoMain : MonoBehaviour
{
    public NavMeshAgent Bot1;
    public Transform PlayerAlvo;
    
    void Start()
    {
        Bot1 = GetComponent<NavMeshAgent>();
        PlayerAlvo = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("SetAlvo",2f,1f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SetAlvo()
    {
        Bot1.SetDestination(PlayerAlvo.position);
    }
}
