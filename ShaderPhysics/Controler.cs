using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    [SerializeField] private Material material;
    [SerializeField] private CustomRenderTexture renderTexture;
    [SerializeField] private Gradient gradient;
    private void Start()
    {
        renderTexture.Initialize();
    }
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            material.SetVector("_DrawPosition", Camera.main.ScreenToViewportPoint(Input.mousePosition));
            material.SetVector("_DrawColor", gradient.Evaluate(Mathf.PingPong(Time.time,1)));

        }
        else
        {
            material.SetVector("_DrawPosition", -Vector2.one);

        }
    }
}
