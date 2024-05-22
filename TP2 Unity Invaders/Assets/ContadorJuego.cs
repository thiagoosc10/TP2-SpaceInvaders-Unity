using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public Text EnemigosRestantestxt;
    private int enemigosRestantes; // Cantidad de enemigos restantes
    void Start()
    {
        // Contar la cantidad inicial de enemigos en la escena
        enemigosRestantes = GameObject.FindGameObjectsWithTag("Enemigo").Length;
        ActualizarTextoEnemigosRestantes();
    }

    public void EnemigoDestruido()
    {
        // Reducir la cantidad de enemigos restantes
        enemigosRestantes--;
        ActualizarTextoEnemigosRestantes();

        // Verificar si todos los enemigos han sido destruidos
        if (enemigosRestantes <= 0)
        {
           SceneManager.LoadScene("EscenaVictoria");
        }
    }

    void ActualizarTextoEnemigosRestantes()
    {
        // Actualizar el texto UI con la cantidad de enemigos restantes
        EnemigosRestantestxt.text = "Enemigos Restantes: " + enemigosRestantes;
    }
}

