using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    public float fadeInTime = 2.0f;

    private Color currentColor = Color.black;
    private Image fadePanel;

	// Use this for initialization
	void Start () {
        fadePanel = GetComponent<Image>();
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad < fadeInTime)
        {
            float alphaChange = Time.deltaTime / fadeInTime;
            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;
        }
        else
        {
            this.gameObject.active = false;
        }
    }
}
