using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed, jumpforce;
    public Rigidbody Rigidbody;
    public Vector3 MovDirection;
    public bool ChaoTa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
        jump();
        
    }


    private void FixedUpdate()
    {
        Rigidbody.linearVelocity = new Vector3(MovDirection.x * speed,0, MovDirection.z * speed);
    }


    public void jump()
    {
        if((Input.GetKeyDown(KeyCode.Space)) && (ChaoTa == true))
        {
            Rigidbody.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            ChaoTa = true;
            Debug.Log("Ola mundo");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            ChaoTa = false;
            Debug.Log("Ola mundo");
        }
    }

}
