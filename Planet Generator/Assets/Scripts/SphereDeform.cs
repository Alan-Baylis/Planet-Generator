using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDeform : MonoBehaviour {

    private Mesh mesh;

	void Start () {
        mesh = GetComponent<MeshFilter>().mesh;
	}
	

	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Expand();
        }else if (Input.GetKeyDown(KeyCode.Return))
        {
            Recolor();
        }
	}

    void Expand()
    {
        Vector3[] nuevosVertices = mesh.vertices;
        Vector3[] normales = mesh.normals;

        for (int i = 0; i < nuevosVertices.Length; i++)
        {
            nuevosVertices[i] += normales[i] * 2;
        }

        mesh.vertices = nuevosVertices;
    }

    void Recolor()
    {
        Debug.Log("A pintar!");
        Vector3[] vertices = mesh.vertices;
        Color[] colores = new Color[vertices.Length];

        for (int i = 0; i < colores.Length; i++)
        {
            colores[i] = Color.blue;
        }

        mesh.colors = colores;
    }
}
