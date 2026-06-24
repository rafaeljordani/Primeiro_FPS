using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteracao : MonoBehaviour
{
    public float distanciaInteracao = 2f;
    public LayerMask InteracaoArmaAWP;
    public GameObject CameraVision, refereciaParaTirarAVida;
    public int Vida = 100;
    public TextMeshProUGUI vidaText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaText.text = "Vida: " + Vida.ToString();
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
        TirarVida();
    }

        //InteracaoArmaAWP

        private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(CameraVision.transform.position, CameraVision.transform.forward * distanciaInteracao);
    }

    public void TirarVida()
    {
            vidaText.text = "Vida: " + Vida.ToString();
    }
}

