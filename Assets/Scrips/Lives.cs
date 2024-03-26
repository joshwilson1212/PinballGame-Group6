using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public Ball ball;
    private TextMeshProUGUI txt;

    private void Start() {
        txt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = ball.lives.ToString();
    }
}
