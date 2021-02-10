using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Cube : MonoBehaviour
{
    //declaring material
    [SerializeField]
    public Material CubeMaterial;

    //declaring spin speed and rotation amount
    public int spinSpeed;
    public Vector3 RotateAmount;

    float width = 2.0f;
    float height = 1.0f;
    float thick = 0.2f;


    Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        //give initial value for speed and rotation amount
        spinSpeed = 4;
        RotateAmount = new Vector3(0.0f, 50.0f, 0.0f);

        Mesh mesh = new Mesh();
        var vertices = new Vector3[24];
        var uvs = new Vector2[vertices.Length];

        //Load Texture
        myTexture = Resources.Load<Texture>("Textures/cube");
        //Set Texture to Material
        CubeMaterial.mainTexture = myTexture;

        //First surface towards X-Positive
        vertices[0] = new Vector3(width, height, thick);
        vertices[1] = new Vector3(width, -height, thick);
        vertices[2] = new Vector3(width, height, -thick);
        vertices[3] = new Vector3(width, -height, -thick);

        //Second surface towards Y-Positive
        vertices[4] = new Vector3(width, height, thick);
        vertices[5] = new Vector3(-width, height, thick);
        vertices[6] = new Vector3(width, height, -thick);
        vertices[7] = new Vector3(-width, height, -thick);

        //Third surface towards Z-Positive
        vertices[8] = new Vector3(width, height, thick);
        vertices[9] = new Vector3(-width, height, thick);
        vertices[10] = new Vector3(width, -height, thick);
        vertices[11] = new Vector3(-width, -height, thick);

        //Fourth surface towards X-Negative
        vertices[12] = new Vector3(-width, height, thick);
        vertices[13] = new Vector3(-width, -height, thick);
        vertices[14] = new Vector3(-width, height, -thick);
        vertices[15] = new Vector3(-width, -height, -thick);

        //Fifth surface towards Y-Negative
        vertices[16] = new Vector3(width, -height, thick);
        vertices[17] = new Vector3(-width, -height, thick);
        vertices[18] = new Vector3(width, -height, -thick);
        vertices[19] = new Vector3(-width, -height, -thick);

        //Sixth surface towards Z-Negative
        vertices[20] = new Vector3(width, height, -thick);
        vertices[21] = new Vector3(-width, height, -thick);
        vertices[22] = new Vector3(width, -height, -thick);
        vertices[23] = new Vector3(-width, -height, -thick);

        //First Tile UVs coordinate in the bottom left corner
        uvs[0] = new Vector2(0.0f, 0.0f);
        uvs[1] = new Vector2(0.0f, 1.0f);
        uvs[2] = new Vector2(1.0f, 1.0f);
        uvs[3] = new Vector2(1.0f, 0.0f);

        uvs[4] = new Vector2(0.0f, 0.0f);
        uvs[5] = new Vector2(0.0f, 1.0f);
        uvs[6] = new Vector2(1.0f, 1.0f);
        uvs[7] = new Vector2(1.0f, 0.0f);

        uvs[8] = new Vector2(0.0f, 0.0f);
        uvs[9] = new Vector2(0.0f, 1.0f);
        uvs[10] = new Vector2(1.0f, 1.0f);
        uvs[11] = new Vector2(1.0f, 0.0f);

        uvs[12] = new Vector2(0.0f, 0.0f);
        uvs[13] = new Vector2(0.0f, 1.0f);
        uvs[14] = new Vector2(1.0f, 1.0f);
        uvs[15] = new Vector2(1.0f, 0.0f);

        uvs[16] = new Vector2(0.0f, 0.0f);
        uvs[17] = new Vector2(0.0f, 1.0f);
        uvs[18] = new Vector2(1.0f, 1.0f);
        uvs[19] = new Vector2(1.0f, 0.0f);

        uvs[20] = new Vector2(0.0f, 0.0f);
        uvs[21] = new Vector2(0.0f, 1.0f);
        uvs[22] = new Vector2(1.0f, 1.0f);
        uvs[23] = new Vector2(1.0f, 0.0f);


        mesh.vertices = vertices;

        //Declaring colors as much as vertices
        var colors = new Color32[vertices.Length];
        //Color for suface towards X-Positive
        colors[0] = new Color32(255, 0, 0, 255);
        colors[1] = new Color32(255, 0, 0, 255);
        colors[2] = new Color32(255, 0, 0, 255);
        colors[3] = new Color32(255, 0, 0, 255);

        //Color for suface towards Y-Positive
        colors[4] = new Color32(0, 255, 0, 255);
        colors[5] = new Color32(0, 255, 0, 255);
        colors[6] = new Color32(0, 255, 0, 255);
        colors[7] = new Color32(0, 255, 0, 255);

        //Color for suface towards Z-Positive
        colors[8] = new Color32(0, 0, 255, 255);
        colors[9] = new Color32(0, 0, 255, 255);
        colors[10] = new Color32(0, 0, 255, 255);
        colors[11] = new Color32(0, 0, 255, 255);

        //Color for suface towards X-Negative
        colors[12] = new Color32(255, 255, 0, 255);
        colors[13] = new Color32(255, 255, 0, 255);
        colors[14] = new Color32(255, 255, 0, 255);
        colors[15] = new Color32(255, 255, 0, 255);

        //Color for suface towards Y-Negative
        colors[16] = new Color32(0, 255, 255, 255);
        colors[17] = new Color32(0, 255, 255, 255);
        colors[18] = new Color32(0, 255, 255, 255);
        colors[19] = new Color32(0, 255, 255, 255);

        //Color for suface towards Y-Negative
        colors[20] = new Color32(255, 0, 255, 255);
        colors[21] = new Color32(255, 0, 255, 255);
        colors[22] = new Color32(255, 0, 255, 255);
        colors[23] = new Color32(255, 0, 255, 255);

        //Assign mesh colors to modified colors variable
        mesh.colors32 = colors;
        //Assign mesh UVs
        mesh.uv = uvs;

        mesh.triangles = new int[]
        {
            2, 0, 1,
            2, 1, 3, // first x positive
            6, 7, 5,
            4, 6, 5, // second y positive
            8, 9, 11,
            8, 11, 10, //third z positive
            12, 14, 13,
            14, 15, 13, //fourth x negative
            19, 18, 17,
            18, 16, 17, //fifth y negative
            21, 20, 23,
            20, 22, 23 //sixth z negative
        };

        //mesh.normals = new Vector3[]
        //{
        //    //x positive
        //    new Vector3(1.0f, 0.0f, 0.0f),
        //    new Vector3(1.0f, 0.0f, 0.0f),
        //    new Vector3(1.0f, 0.0f, 0.0f),
        //    new Vector3(1.0f, 0.0f, 0.0f),
        //    //y positive
        //    new Vector3(0.0f, 1.0f, 0.0f),
        //    new Vector3(0.0f, 1.0f, 0.0f),
        //    new Vector3(0.0f, 1.0f, 0.0f),
        //    new Vector3(0.0f, 1.0f, 0.0f),
        //    //z positive
        //    new Vector3(0.0f, 0.0f, 1.0f),
        //    new Vector3(0.0f, 0.0f, 1.0f),
        //    new Vector3(0.0f, 0.0f, 1.0f),
        //    new Vector3(0.0f, 0.0f, 1.0f),
        //    //x negative
        //    new Vector3(-1.0f, 0.0f, 0.0f),
        //    new Vector3(-1.0f, 0.0f, 0.0f),
        //    new Vector3(-1.0f, 0.0f, 0.0f),
        //    new Vector3(-1.0f, 0.0f, 0.0f),
        //    //y negative
        //    new Vector3(0.0f, -1.0f, 0.0f),
        //    new Vector3(0.0f, -1.0f, 0.0f),
        //    new Vector3(0.0f, -1.0f, 0.0f),
        //    new Vector3(0.0f, -1.0f, 0.0f),
        //    //z negative
        //    new Vector3(0.0f, 0.0f, -1.0f),
        //    new Vector3(0.0f, 0.0f, -1.0f),
        //    new Vector3(0.0f, 0.0f, -1.0f),
        //    new Vector3(0.0f, 0.0f, -1.0f),
        //};
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = CubeMaterial;

        //foreach (Vector3 normal in GetComponent<MeshFilter>().mesh.normals)
        //{
        //    Debug.Log(normal.x + " " + normal.y + " " + normal.z);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //spin the cube
        //transform.Rotate(RotateAmount * Time.deltaTime / spinSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Switch the Texture's Filter Mode
            myTexture.filterMode = SwitchFilterModes();
            //Ouput the current Filter Mode to the Console
            Debug.Log("Filter mode : " + myTexture.filterMode);
        }
    }

    FilterMode SwitchFilterModes()
    {
        //Switch the Filter Mode of the Texture when user clicks the Button
        switch (myTexture.filterMode)
        {
            //if the FilterMode is currently Bilinear, switch it to Point
            case FilterMode.Bilinear:
                myTexture.filterMode = FilterMode.Point;
                break;

            //if the FilterMode is currently Point, switch it to Trilinear
            case FilterMode.Point:
                myTexture.filterMode = FilterMode.Trilinear;
                break;

            //if the FilterMode is currently Trilinear, switch it to Bilinear
            case FilterMode.Trilinear:
                myTexture.filterMode = FilterMode.Bilinear;
                break;
        }
        //Return the new Texture FilterMode
        return myTexture.filterMode;
    }
}
