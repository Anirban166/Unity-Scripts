using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIFadeAway : MonoBehaviour {

	[Tooltip("Rate at which to animate.")]
	public AnimationCurve curve = AnimationCurve.Linear (0.0f, 0.0f, 1.0f, 1.0f);

	[Tooltip("Size to fade away to.  1.0 = no change.  2.0 = double size.")]
	public float fadeSize = 2.0f;

	[Tooltip("Time over which to perform the fade.")]
	public float fadeTime = 1.0f;

	[Tooltip("True to fade immediately on load, false to wait for script intervention.")]
	public bool fadeImmediately = true;

	float startAlpha = 1f;
	float endAlpha = 0f;
    float progressPct = 0.0f;
    MaskableGraphic element;

    Vector3 baseScale;

    // Use this for initialization
    void Start()
    {
        Initialize();
		if (!fadeImmediately) {
			Restore ();
		}
    }

	// Grab initial conditions for the graphic.
	//
    void Initialize()
    {
        if (element == null)
        {
			element = GetComponent<MaskableGraphic>();
            Fade(fadeTime);
            baseScale = element.rectTransform.localScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (progressPct < 1.0f)
        {
            progressPct = Mathf.Clamp01(progressPct + (Time.deltaTime / fadeTime));

            float adjustedPct = curve.Evaluate(progressPct);
			float curAlpha = Mathf.Lerp (startAlpha, endAlpha, adjustedPct);

            element.rectTransform.localScale = Vector3.Lerp(baseScale, baseScale * fadeSize, adjustedPct);
			element.color = new Color(element.color.r, element.color.g, element.color.b, curAlpha);
        }
    }

	// Fade to another alpha level.
	//
	// time: time in seconds to perform the fade.
	// goalPct: Opacity percentage [0,1] to fade to.
	//
	public void Fade(float time = -1f, float goalPct = 0f)
    {
        Initialize();

		if (time == 0) {
			Restore ();
			element.color = new Color(element.color.r, element.color.g, element.color.b, goalPct);
			return;
		} else if (fadeTime > 0f)
            fadeTime = time;
        else
            fadeTime = 0.5f;

        progressPct = 0.0f;
		startAlpha = element.color.a;
		endAlpha = goalPct;
    }

	// Restore the graphic to its initial size and full opacity.
	//
    public void Restore()
    {
        Initialize();

        progressPct = 1.0f;
        element.rectTransform.localScale = baseScale;
        element.color = new Color(element.color.r, element.color.g, element.color.b, 1.0f);
    }
}
