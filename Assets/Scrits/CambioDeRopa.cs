using UnityEngine;

public class CambioDeRopa : MonoBehaviour
{
    [Header("Cabezas")]

    public GameObject Cabe1;
    public GameObject Cabe2;
    public GameObject Cabe3;
    public int NumeroCabeza = 0;

    [Header("Torso")]

    public GameObject Torso1;
    public GameObject Torso2;
    public GameObject Torso3;
    public int NumeroTorso = 0;


    [Header("Pantalon")]

    public GameObject Pants1;
    public GameObject Pants2;
    public GameObject Pants3;
    public int NumeroPants = 0;

    [Header("Zapatos")]

    public GameObject ZapatoPar1_0;
    public GameObject ZapatoPar1_1;
    public GameObject ZapatoPar2_0;
    public GameObject ZapatoPar2_1;
    public GameObject ZapatoPar3_0;
    public GameObject ZapatoPar3_1;
    public int NumeroZapatos = 0;

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




        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (NumeroPants == 0)
            {
                Pants1.SetActive(true);
                Pants2.SetActive(false);
                Pants3.SetActive(false);

                NumeroPants = 1;

            }
            else if (NumeroPants == 1)
            {
                Pants1.SetActive(false);
                Pants2.SetActive(true);
                Pants3.SetActive(false);

                NumeroPants = 2;
            }
            else if ((NumeroPants == 2))
            {
                Pants1.SetActive(false);
                Pants2.SetActive(false);
                Pants3.SetActive(true);

                NumeroPants = 3;


            }
            else if ((NumeroPants == 3))
            {
                Pants1.SetActive(false);
                Pants2.SetActive(false);
                Pants3.SetActive(false);

                NumeroPants = 0;


            }


        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (NumeroZapatos == 0)
            {
                ZapatoPar1_0.SetActive(true);
                ZapatoPar1_1.SetActive(true);
                ZapatoPar2_0.SetActive(false);
                ZapatoPar2_1.SetActive(false);
                ZapatoPar3_0.SetActive(false);
                ZapatoPar3_1.SetActive(false);


                NumeroZapatos = 1;

            }
            else if (NumeroZapatos == 1)
            {
                ZapatoPar1_0.SetActive(false);
                ZapatoPar1_1.SetActive(false);
                ZapatoPar2_0.SetActive(true);
                ZapatoPar2_1.SetActive(true);
                ZapatoPar3_0.SetActive(false);
                ZapatoPar3_1.SetActive(false);


                NumeroZapatos = 2;
            }
            else if ((NumeroZapatos == 2))
            {
                ZapatoPar1_0.SetActive(false);
                ZapatoPar1_1.SetActive(false);
                ZapatoPar2_0.SetActive(false);
                ZapatoPar2_1.SetActive(false);
                ZapatoPar3_0.SetActive(true);
                ZapatoPar3_1.SetActive(true);


                NumeroZapatos = 3;


            }
            else if ((NumeroZapatos == 3))
            {
                ZapatoPar1_0.SetActive(false);
                ZapatoPar1_1.SetActive(false);
                ZapatoPar2_0.SetActive(false);
                ZapatoPar2_1.SetActive(false);
                ZapatoPar3_0.SetActive(false);
                ZapatoPar3_1.SetActive(false);


                NumeroZapatos = 0;


            }

        }
    }
}


