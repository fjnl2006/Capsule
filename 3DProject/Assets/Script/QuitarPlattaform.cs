using UnityEngine;

public class QuitarPlattaform : MonoBehaviour
{
    [SerializeField] private int contador = 1;

    [SerializeField] private int tiempoTotal = 680;
    
    [SerializeField] private int ticks = 5;
    

    private int tiempoRestar = 680;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
        
            Debug.Log(contador);
            if (contador == tiempoTotal)
            {
                
                Destroy(this.gameObject);
            }

            contador = 1 + contador / ticks;
        
        
    }

    
}
