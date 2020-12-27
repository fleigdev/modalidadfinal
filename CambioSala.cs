using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioSala : MonoBehaviour
{

    public GameObject sofa1;
    public GameObject sofa2;

    private bool sofa1Bool;
    private bool sofa2Bool;
    // Start is called before the first frame update
    void Start()
    {
        sofa1.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activarSofa2()
    {
        sofa1.SetActive(false);
        sofa2.SetActive(true);
    }

    public void activarSofa1()
    {
        sofa2.SetActive(false);
        sofa1.SetActive(true);
    }
}
