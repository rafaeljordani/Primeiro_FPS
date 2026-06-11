using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteracao : MonoBehaviour
{
    public float distanciaInteracao = 2f;
    public LayerMask InteracaoArmaAWP;
    public GameObject CameraVision;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(CameraVision.transform.position, CameraVision.transform.forward,out hit, distanciaInteracao, InteracaoArmaAWP))
            {
                Debug.Log("interagio com o " + hit.collider.gameObject.name);
                InteracaoPai interacao = hit.collider.gameObject.GetComponent<InteracaoPai>();
                interacao.interact();
            }
            else
            {
                Debug.Log("Capotemo o corsa");
            }
        }
    }

        //InteracaoArmaAWP

        private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(CameraVision.transform.position, CameraVision.transform.forward * distanciaInteracao);
    }


}

