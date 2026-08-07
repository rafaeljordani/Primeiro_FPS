using Unity.Mathematics;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed, jumpforce;
    public Rigidbody Rigidbody;
    public Vector3 MovDirection, MouseDir;
    public bool ChaoTa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {

        MouseDir.x += Input.GetAxis("Mouse X");

        this.transform.localRotation = Quaternion.Euler(0, MouseDir.x, 0);
        MovDirection = new Vector3(Input.GetAxisRaw("Horizontal"),Rigidbody.linearVelocity.y, Input.GetAxisRaw("Vertical"));
        MovDirection = transform.TransformDirection(MovDirection);
        jump();
        
    }


    private void FixedUpdate()
    {
        Rigidbody.linearVelocity = new Vector3(MovDirection.x * speed, Rigidbody.linearVelocity.y, MovDirection.z * speed);
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
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            ChaoTa = false;
        }
    }

}
