using UnityEngine;

public class CambioDeRopa : MonoBehaviour
{

    // Cabezas
    public GameObject Cabe1;
    public GameObject Cabe2;
    public GameObject Cabe3;
    public int NumeroCabeza = 0;

    // Prendas torso

    public GameObject Torso1;
    public GameObject Torso2;
    public GameObject Torso3;
    public int NumeroTorso = 0;

    // Pantalones

    public GameObject Pantalon1;
    public GameObject Pantalon2;
    public GameObject Pantalon3;
    public int NumeroPantalon = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (NumeroCabeza == 0)
            {
                Cabe1.SetActive(false);
                Cabe2.SetActive(true);
                Cabe3.SetActive(false);

                NumeroCabeza = 1;

            }
            else if (NumeroCabeza == 1)
            {
                Cabe1.SetActive(false);
                Cabe2.SetActive(false);
                Cabe3.SetActive(true);

                NumeroCabeza = 2;

            }
            else if (NumeroCabeza == 2)
            {
                Cabe1.SetActive(true);
                Cabe2.SetActive(false);
                Cabe3.SetActive(false);

                NumeroCabeza = 0;
            }

        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (NumeroTorso == 0)
            {
                Torso1.SetActive(true);
                Torso2.SetActive(false);
                Torso3.SetActive(false);

                NumeroTorso = 1;

            }
            else if (NumeroTorso == 1)
            {
                Torso1.SetActive(false);
                Torso2.SetActive(true);
                Torso3.SetActive(false);

                NumeroTorso = 2;
            }
            else if ((NumeroTorso == 2))
            {
                Torso1.SetActive(false);
                Torso2.SetActive(false);
                Torso3.SetActive(true);

                NumeroTorso = 3;


            }
            else if ((NumeroTorso == 3))
            {
                Torso1.SetActive(false);
                Torso2.SetActive(false);
                Torso3.SetActive(false);

                NumeroTorso = 0;


            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                if (NumeroPantalon == 0)
                {
                    Pantalon1.SetActive(true);
                    Pantalon2.SetActive(false);
                    Pantalon3.SetActive(false);

                    NumeroPantalon = 1;

                }
                else if (NumeroPantalon == 1)
                {
                    Pantalon1.SetActive(true);
                    Pantalon2.SetActive(false);
                    Pantalon3.SetActive(false);

                    NumeroPantalon = 2;
                }
                else if ((NumeroPantalon == 2))
                {
                    Pantalon1.SetActive(true);
                    Pantalon2.SetActive(false);
                    Pantalon3.SetActive(false);

                    NumeroPantalon = 3;


                }
                else if ((NumeroPantalon == 3))
                {
                    Pantalon1.SetActive(true);
                    Pantalon2.SetActive(false);
                    Pantalon3.SetActive(false);

                    NumeroPantalon = 0;


                }
            }

        }
    }
}
