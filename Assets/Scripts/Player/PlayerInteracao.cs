using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteracao : MonoBehaviour
{
    public float distanciaInteracao = 2f;
    public LayerMask InteracaoArmaAWP;
    public GameObject CameraVision, refereciaParaTirarAVida;
    public int Vida = 100, Pontuacao;
    public TextMeshProUGUI vidaText, PontuacaoText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaText.text = "Vida: " + Vida.ToString();
        PontuacaoText.text = "Pontua��o: " + Pontuacao.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(CameraVision.transform.position, CameraVision.transform.forward, out hit, distanciaInteracao, InteracaoArmaAWP))
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
        AdicionarPontuacao();
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
        if (Vida <= 0)
        {
            SceneManager.LoadScene("Reload");
        }
    }

    public void AdicionarPontuacao()
    {
        PontuacaoText.text = "Pontua��o: " + Pontuacao.ToString();
        if (Pontuacao >= 500)
        {
            SceneManager.LoadScene("Vitoria");
        }
    }
}

