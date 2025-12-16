using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerInput playerInputAction;
    Vector2 movement;
   
    Vector3 move;

    [Header("Parametros")]
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float velocidad = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInputAction = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = playerInputAction.actions["Walk"].ReadValue<Vector2>();
        move = new Vector3(movement.x, 0, movement.y) * speed * Time.deltaTime;
        transform.Translate(move, Space.Self);
    }


    private void FixedUpdate()
    {
       
    }

    


}
