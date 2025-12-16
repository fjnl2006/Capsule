using UnityEngine;

public class Caida : MonoBehaviour
{
    Vector3 spawn = new Vector3(0,(float)0.08740006, 0);
    public GameObject player;

    public BallController playerPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
    
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Caida");
            player.transform.position = spawn;
            
            player.GetComponent<Rigidbody>().linearVelocity = Vector3.zero  ;
        }
    }
}
