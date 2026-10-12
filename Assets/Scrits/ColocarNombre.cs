using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 
using UnityEngine.UI; 

public class ColocarNombre : MonoBehaviour
{
    [Header("Recursos")]
    public TMP_InputField inputNombreJugador; 
    public TextMeshProUGUI textoNombreReflejado; 
    public Button botonContinuar; 

    [Header("Configuración de Escena")]
    public string nombreSiguienteEscena = "SampleScene"; 

    private void Start()
    {
        
        if (inputNombreJugador != null)
        {
            inputNombreJugador.onValueChanged.AddListener(ActualizarTextoReflejado);
        }

        
        if (botonContinuar != null)
        {
            botonContinuar.onClick.AddListener(BotonContinuar);
        }
    }

    
    public void ActualizarTextoReflejado(string texto)
    {
        if (textoNombreReflejado != null)
        {
            textoNombreReflejado.text = "Nombre: " + texto;
        }
    }

    
    public void BotonContinuar()
    {
        string nombre = inputNombreJugador.text;

        
        if (!string.IsNullOrEmpty(nombre))
        {
            PlayerPrefs.SetString("NombreJugador", nombre);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetString("NombreJugador", "Anónimo");
        }

       
        SceneManager.LoadScene(nombreSiguienteEscena);
    }
}