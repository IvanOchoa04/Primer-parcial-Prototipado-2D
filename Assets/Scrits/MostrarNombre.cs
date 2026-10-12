using UnityEngine;
using TMPro; 

public class MostrarNombreJugador : MonoBehaviour
{
    public TextMeshProUGUI textoNombreUI; 

    void Start()
    {
        
        string nombreRecuperado = PlayerPrefs.GetString("NombreJugador", "Anónimo");

        
        if (textoNombreUI != null)
        {
            textoNombreUI.text = nombreRecuperado;
        }
    }
}