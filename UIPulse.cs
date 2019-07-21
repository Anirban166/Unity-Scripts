using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIPulse : MonoBehaviour {

	public Gradient colorPattern;		// Pattern for the colors to rotate through.
	public float pulseSpeed = 1.0f;		// How fast to rotate through the colors.

	Color baseColor;
	MaskableGraphic image;
	bool fwd;
	float pct;

	// Use this for initialization
	void Start () {
		image = gameObject.GetComponent<MaskableGraphic> ();
		image.color = colorPattern.Evaluate (0.0f);
		pct = 0.0f;
		fwd = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (fwd) {
			pct += pulseSpeed * Time.deltaTime;
		} else {
			pct -= pulseSpeed * Time.deltaTime;
		}

		if (pct < 0.0f || pct > 1.0f) {
			fwd = !fwd;
			pct = Mathf.Clamp01 (pct);
		}

		image.color = colorPattern.Evaluate (pct);
	}
}
