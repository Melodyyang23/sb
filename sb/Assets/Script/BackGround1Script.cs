using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround1Script : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float ScrollSpeed1 = 0.5f;
    private float offset1;
    private Material Mat1;


    // Start is called before the first frame update
    void Start()
    {
        Mat1 = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset1 = offset1 + (Time.deltaTime * ScrollSpeed1) / 10f;
        Mat1.SetTextureOffset("_MainTex", new Vector2(offset1, 0));
    }
}
