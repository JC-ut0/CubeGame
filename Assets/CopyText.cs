using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopyText : MonoBehaviour
{
    public Text textNeedToCopy;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = textNeedToCopy.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
