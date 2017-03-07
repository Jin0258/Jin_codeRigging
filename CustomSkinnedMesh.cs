using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSkinnedMesh : MonoBehaviour {


    public Material mt;
    public Transform[] bones;

	// Use this for initialization
	void Start ()
    {
        Mesh m = new Mesh();
        m.vertices = new Vector3[]
        {
            new Vector3(0.0f, 0.0f, 0.0f), //0
            new Vector3(-5.0f, 11.0f, 0.0f), //1
            new Vector3(5.0f, 11.0f, 0.0f), //2
            new Vector3(0.0f, 15.0f, 0.0f), //3
            new Vector3(-3.0f, 20.0f, 0.0f), //4
            new Vector3(3.0f, 20.0f, 0.0f), //5
            new Vector3(0.0f, 23.0f, 0.0f), //6
            new Vector3(-7.0f, 0.0f, 0.0f), //7
            new Vector3(-5.0f, 0.0f, 0.0f), //8
            new Vector3(5.0f, 0.0f, 0.0f), //9
            new Vector3(7.0f, 0.0f, 0.0f), //10
            new Vector3(5.0f, -2.0f, 0.0f), //11
            new Vector3(-5.0f, -2.0f, 0.0f), //12
            new Vector3(0.0f, -4.0f, 0.0f), //13
            new Vector3(-2.0f, -5.0f, 0.0f), //14
            new Vector3(2.0f, -5.0f, 0.0f), //15
            new Vector3(-5.0f, -12.0f, 0.0f), //16
            new Vector3(5.0f, -12.0f, 0.0f), //17
            new Vector3(7.0f, -15.0f, 0.0f), //18
            new Vector3(-7.0f, -15.0f, 0.0f), //19
            new Vector3(-5.0f, -22.0f, 0.0f), //20
            new Vector3(5.0f, -22.0f, 0.0f), //21
            new Vector3(-7.0f, -25.0f, 0.0f), //22 
            new Vector3(-3.0f, -25.0f, 0.0f), //23
            new Vector3(3.0f, -25.0f, 0.0f), //24
            new Vector3(7.0f, -25.0f, 0.0f) //25
                 

        };

        m.triangles = new int[] 
        {
            0, 1, 2,
            1, 3, 2,
            3, 4, 5,
            4, 6, 5,
            7, 1, 8,
            9, 2, 10,
            12, 0, 11,
            13, 12, 11,
            16, 12, 14,
            17, 15, 11,
            20,19,16,
            21, 18, 17,
            22, 20, 23,
            24, 21, 25

        };
        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[1].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[2].worldToLocalMatrix * transform.localToWorldMatrix
        };

        m.boneWeights = new BoneWeight[]
        {
            new BoneWeight() { boneIndex0 = 0, weight0 = 1f}, // bones[0]과 vertices[0]를 연결하고 그 연결도는 1f(100%)이다.
            new BoneWeight() { boneIndex0 = 1, weight0 = 1f},// bones[1]과 vertices[1]를 연결하고 그 연결도는 1f(100%)이다.
            new BoneWeight() { boneIndex0 = 1, weight0 = 1f}, // bones[0]과 vertices[2]를 연결하고 그 연결도는 1f(100%)이다.
            new BoneWeight() { boneIndex0 = 1, weight0 = 1f}, //3
            new BoneWeight() { boneIndex0 = 1, weight0 = 1f}, //4
            new BoneWeight() { boneIndex0 = 1, weight0 = 1f}, //5
            new BoneWeight() { boneIndex0 = 1, weight0 = 1f},//6
            new BoneWeight() { boneIndex0 = 1, weight0 = 0.7f},//7
            new BoneWeight() { boneIndex0 = 1, weight0 = 0.7f},//8
            new BoneWeight() { boneIndex0 = 1, weight0 = 0.7f},//9
            new BoneWeight() { boneIndex0 = 1, weight0 = 0.7f},//10
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//11
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//12
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//13
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//14
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//15
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//16
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//17
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//18
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//19
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//20
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//21
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//22
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//23
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f},//24
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f} //25
            
        };
        SkinnedMeshRenderer smr = GetComponent<SkinnedMeshRenderer>();
        smr.sharedMesh = m;
        smr.sharedMaterial = mt;
        smr.bones = bones;
        smr.rootBone = transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
