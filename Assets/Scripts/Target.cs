using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float timeDestroy = 2f;
    private GameManager gameManagerScript;

    [SerializeField] private int points;
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        // Destruye el objeto cada 2 segundos
        Destroy(gameObject, timeDestroy);
        gameManagerScript = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        if (!gameManagerScript.gameOver)
        {
            // Dar o quitar puntos
            gameManagerScript.UpdateScore(points);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }

        if (gameObject.CompareTag("Good"))
        {
            Destroy(gameObject);



            // Musica de fondo
        }

        else if (gameObject.CompareTag("Bad"))
        {
            Destroy(gameObject);
            gameManagerScript.missCounter += 1;

            if (gameManagerScript.missCounter >= gameManagerScript.totalMisses)
            {
                gameManagerScript.gameOver = true;
            }

            // Game Over
            // Restar puntos
            // Quitar vida
            // Musica de Game Over o mal hecho
        }

    }

    private void OnDestroy()
    {
        gameManagerScript.targetPositions.Remove(transform.position);
    }
}
