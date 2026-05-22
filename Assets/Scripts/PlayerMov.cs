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
        MovDirection = new Vector3(Input.GetAxisRaw("Horizontal"),Rigidbody.linearVelocity.y, Input.GetAxisRaw("Vertical"));
        jump();
        
    }


    private void FixedUpdate()
    {
        Rigidbody.linearVelocity = new Vector3(MovDirection.x * speed, Rigidbody.linearVelocity.y, MovDirection.z * speed);
    }


    public void jump()
    {
        if((Input.GetKeyDown(KeyCode.Escape)) && (ChaoTa == true))
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
