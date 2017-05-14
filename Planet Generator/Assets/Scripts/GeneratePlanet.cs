using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlanet : MonoBehaviour {

    public int seed;
    public float scale;
    public int octaves;
    [Range(0,1)]
    public float persistence;
    public float lacunarity;

    private Vector3[] vertices;
    private Vector3[] normales;
    private Mesh mesh;

	void Start () {

        mesh = GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;
        normales = mesh.normals;

        calculateHeight();

    }
	
	
	void calculateHeight () {

        System.Random prng = new System.Random(seed);
        Vector2[] octaveOffsets = new Vector2[octaves];
        for (int i = 0; i < octaves; i++)
        {

        }

    }
}
