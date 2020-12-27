using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioHora : MonoBehaviour
{
    public Material dia;
    public Material tarde;
    public Material noche;

    public GameObject lucesDia;
    public GameObject lucesTarde;
    public GameObject lucesNoche;

    public GameObject sol;
    public Light luzdireccional;

    public string vectores;


    void Start()
    {
        lucesDia.SetActive(true);
        sol.transform.eulerAngles = new Vector3(155f, 180f, 178f);

    }


    public void activarTarde()
    {
        RenderSettings.skybox = tarde;
        //sol.transform.rotation = Quaternion.Euler(0, 0, 45);
        sol.transform.eulerAngles = new Vector3(135f, 180f, 178f);
        luzdireccional.intensity = 1f;
        lucesTarde.SetActive(true);
        lucesDia.SetActive(false);
        lucesNoche.SetActive(false);
    }

    public void activarDia()
    {
        RenderSettings.skybox = dia;
        //sol.transform.rotation = Quaternion.Euler(0, 0, 45);
        sol.transform.eulerAngles = new Vector3(155f, 180f, 178f);
        luzdireccional.intensity = 2.2f;
        lucesDia.SetActive(true);
        lucesNoche.SetActive(false);
        lucesTarde.SetActive(false);
    }

    public void activarNoche()
    {
        RenderSettings.skybox = noche;
        //sol.transform.rotation = Quaternion.Euler(0, 0, 45);
        sol.transform.eulerAngles = new Vector3(70f, 180f, 178f);
        luzdireccional.intensity = 0f;
        lucesNoche.SetActive(true);
        lucesTarde.SetActive(false);
        lucesDia.SetActive(false);
    }

}
