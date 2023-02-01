using System;
using UnityEngine;

[DisallowMultipleComponent]
[ExecuteAlways]
public class MaterialController : MonoBehaviour
{
    public Material mat;
    [Range(0,1)]public float Munitions;
    [Range(0,1)]public float MunitionsBalistic;

    public static MaterialController MC;

    private static readonly int Munitions1 = Shader.PropertyToID("_Munitions");
    private static readonly int Munitions2 = Shader.PropertyToID("_AmmunitionBalistic");

    private void OnEnable() {
        MC = this;
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat(Munitions1, Munitions);
        mat.SetFloat(Munitions2, MunitionsBalistic);
    }
}

public class BiduleMachin : MonoBehaviour {
    
    private void Start() {
        MaterialController.MC.Munitions = 5;
        MaterialController.MC.MunitionsBalistic = 5;
    }
}
