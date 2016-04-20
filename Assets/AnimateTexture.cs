using UnityEngine;
using System.Collections;

public class AnimateTexture : MonoBehaviour {
    Texture2D[] textures;
    public string path;
    public int fps = 24;
    int framesLength;
    MeshRenderer mRenderer;
    float tStart;
	// Use this for initialization
	void Start () {
        mRenderer=GetComponent<MeshRenderer>();
        Object[] ts = Resources.LoadAll(path, typeof(Texture2D));
        textures = new Texture2D[ts.Length];
        for (int i = 0; i < textures.Length; i++)
            textures[i] = (Texture2D)ts[i];
        framesLength = textures.Length;
        tStart = Time.time;
        mRenderer.material.mainTexture = textures[0];
	}
	
	// Update is called once per frame
	void Update () {
        float dt = Time.time - tStart;
        int frameNumber = (int)(dt * fps) % framesLength;
        mRenderer.material.mainTexture = textures[frameNumber];
	}
}
