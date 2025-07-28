using UnityEngine;

public class ParallaxEfecto : MonoBehaviour
{
    public Transform camara; // Cámara principal
    public float velocidadParallax = 0.5f; // Cuánto se mueve esta capa
    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = camara.position.x * velocidadParallax;
        transform.position = new Vector3(posicionInicial.x + distancia, posicionInicial.y, posicionInicial.z);
    }
}
