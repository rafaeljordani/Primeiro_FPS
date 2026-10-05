using UnityEngine;

public class JumpPlayer : MonoBehaviour
{

    public float jumpforce;
    public Rigidbody rb;
    public bool ChaoTa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }


    public void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (ChaoTa == true))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Chao"))
        {
            ChaoTa = true;
            Debug.Log("ChaoTa: " + ChaoTa);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Chao"))
        {
            ChaoTa = false;
            Debug.Log("ChaoTa: " + ChaoTa);
        }
    }
    
    
    

}
