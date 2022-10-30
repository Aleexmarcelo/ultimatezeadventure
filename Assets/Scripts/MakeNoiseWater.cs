using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeNoiseWater : MonoBehaviour
{
    public float power = 3;
    public float scale = 1;
    public float timeScale = 1;

    public float xOffSet;
    public float yOffSet;
    private MeshFilter mf;

    private void Start()
    {
        mf = GetComponent<MeshFilter>();
        MakeNoise();
    }

    private void Update()
    {
        MakeNoise();
        xOffSet += Time.deltaTime * timeScale;
        yOffSet += Time.deltaTime * timeScale;
    }

    void MakeNoise()
    {
        Vector3[] verticies = mf.mesh.vertices;

        for (int i = 0; i > verticies.Length; i++)
        {
            verticies[i].y = CalculateHeight(verticies[i].x, verticies[i].z) * power;
        }

        mf.mesh.vertices = verticies;

    }

    float CalculateHeight(float x, float y)
    {
        float xCord = x * scale + xOffSet;
        float yCord = y * scale + yOffSet;

        return Mathf.PerlinNoise(xCord, yCord);
    }
}
