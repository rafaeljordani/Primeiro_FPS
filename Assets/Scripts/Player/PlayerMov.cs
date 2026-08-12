using Unity.Mathematics;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float walkSpeed = 3f;
    public float runSpeed = 5f;
    public float jumpforce = 3f;
    public Rigidbody rb;
    public bool ChaoTa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        movPlayer();
    }


    public void movPlayer()
    {
        walk();
        jump();
    }


    public void walk()
    {
        //Aqui um ternario para setar a velocidade que sera usada, se sera a de correr ou a de andar normal 
        float setSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;

        //Pega o input de andar do player 
        Vector3 MovDirection = new Vector3(Input.GetAxisRaw("Horizontal"), rb.linearVelocity.y, Input.GetAxisRaw("Vertical"));
        //adiciona esse input direciado a onde o player esta olhando
        MovDirection = transform.TransformDirection(MovDirection);
        //adiciona o speed na mov
        MovDirection = MovDirection * setSpeed;
        //aqui ele anda sem alterar o eixo Y 
        rb.linearVelocity = new Vector3(MovDirection.x, rb.linearVelocity.y, MovDirection.z);

    }

    public void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (ChaoTa == true))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }

   public void squat()
    {

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
