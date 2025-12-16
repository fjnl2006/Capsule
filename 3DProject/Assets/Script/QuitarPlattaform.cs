using UnityEngine;
using System.Collections;

public class QuitarPlattaform : MonoBehaviour
{
    [Header("Tiempos")]
    [Tooltip("Tiempo que tarda en caerse desde que la tocas")]
    [SerializeField] private float tiempoAntesDeDesaparecer = 2.0f; 
    
    [Tooltip("Tiempo que tarda en volver a aparecer")]
    [SerializeField] private float tiempoParaReaparecer = 5.0f;

    
    private MeshRenderer miRenderer;
    private Collider miCollider;
    
 
    private bool enProceso = false;

    void Start()
    {
       
        miRenderer = GetComponent<MeshRenderer>();
        miCollider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Player") && !enProceso)
        {
            StartCoroutine(CicloDesaparicion());
        }
    }

    IEnumerator CicloDesaparicion()
    {
        enProceso = true;

       
        yield return new WaitForSeconds(tiempoAntesDeDesaparecer);

       
        miRenderer.enabled = false;
        miCollider.enabled = false;

       
        yield return new WaitForSeconds(tiempoParaReaparecer);

        
        miRenderer.enabled = true;
        miCollider.enabled = true;
        
        enProceso = false;
    }
    
}
