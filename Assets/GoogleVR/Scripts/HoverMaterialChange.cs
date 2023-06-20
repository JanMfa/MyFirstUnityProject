using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverMaterialChange : MonoBehaviour {
    public Material hoverMaterial;
    public Material regularMaterial;
    private Renderer _myRenderer;

    // Use this for initialization
    void Start()
    {
        _myRenderer = GetComponent<Renderer>();
    }

    public void StartHover()
    {
        _myRenderer.sharedMaterial = hoverMaterial;
    }

    public void StopHover()
    {
        _myRenderer.sharedMaterial = regularMaterial;
    }
}
