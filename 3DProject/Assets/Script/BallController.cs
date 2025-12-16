using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    PlayerInput input;
    Rigidbody rb;
    [Header("Parametros")]
    [SerializeField] private float speed ;
    [SerializeField] private float jumpForce ;
    [SerializeField] private float downForce;
    [SerializeField] private bool salto;

    private Vector2 inputMovement;
    private Vector2 inputJump;
    public Vector3 direction;
    private Vector3 jumpt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement = input.actions["Walk"].ReadValue<Vector2>();
        //inputJump = input.actions["Jump"].ReadValue <Vector2>();
        direction.x = inputMovement.x;
        direction.z = inputMovement.y;
        //jumpt.y = inputJump.y;
        
    }

    private void FixedUpdate()
    {


        //rb.AddForce(jumpt * inputJump, ForceMode.Impulse);

       
            
            Move();
        
    }

    public void Jump(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.performed && salto == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            salto = false;
        }
    }

    public void Move()
    {
        rb.AddForce(direction * speed, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            salto = true;
        }
    }

}
