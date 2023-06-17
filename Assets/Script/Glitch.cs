using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch : MonoBehaviour
{
    private Renderer renderer;
    private Material mainMaterial;
    public float minGlitchInterval = 3f;
    public float maxGlitchInterval = 6f;
    public float glitchDuration = 0.4f; 

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        mainMaterial = renderer.material;
        StartCoroutine(StartGlitching());
    }

    IEnumerator StartGlitching()
    {
        while (true)
        {
            float randomNumber = Random.Range(3f, 7f);
            mainMaterial.SetFloat("_GlitchStrengh", randomNumber);
            yield return new WaitForSeconds(glitchDuration);
            mainMaterial.SetFloat("_GlitchStrengh", 0f);
            float randomInterval = Random.Range(minGlitchInterval, maxGlitchInterval);
            yield return new WaitForSeconds(randomInterval - glitchDuration);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
