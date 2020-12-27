using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarTextura : MonoBehaviour
{
    
    MeshRenderer meshRenderer;
    public Texture materialUno;
    public Texture materialDos;
    public Texture materialTres;


    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        
    }

    public void CambiarMaterialUno()
    {
        Debug.Log("Yes! ");
        meshRenderer.material.SetTexture("_BaseMap", materialUno);
    }

    public void CambiarMaterialDos()
    {
        Debug.Log("Yes! ");
        meshRenderer.material.SetTexture("_BaseMap", materialDos);
    }

    public void CambiarMaterialTres()
    {
        Debug.Log("Yes! ");
        meshRenderer.material.SetTexture("_BaseMap", materialTres);
    }


}
