using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIValueAnimator : MonoBehaviour {
	
	float animateTime = 1.0f;
	float finishTime = -1.0f;
	AnimationCurve curve = null;

	Text _element = null;
	Text element {
		get {
			if (_element == null) {
				_element = GetComponent<Text> ();
				if (_element == null) {
					Debug.LogError ("Could not find Text element on UIValueAnimator.");
				}
			}
			return _element;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (finishTime > 0) {
			if (Time.time < finishTime) {
				SetValue(Mathf.FloorToInt (curve.Evaluate (Time.time)));
			} else {
				SetValue (Mathf.FloorToInt (curve.Evaluate (finishTime)));
				curve = null;
				finishTime = -1f;
			}
		}
	}

	int GetCurrentValue()
	{
		int result = 0;
		int.TryParse (element.text, out result);
		return result;
	}

	// Set the value of the text immediately without animating.
	// 
	// value: new value for the element.
	// 
	public void SetValue(int value)
	{
		element.text = "" + value;
	}

	// Animate toward a new value.
	// 
	// endVal: new value to animate toward.
	// animTime (optional): time to take getting to endVal.  Omit to use value set in inspector.
	// 
	public void AnimateValue(int endVal, float animTime = -1.0f)
	{
		if (animTime > 0) {
			animateTime = animTime;
		}

		finishTime = Time.time + animateTime;
		curve = AnimationCurve.EaseInOut (Time.time, GetCurrentValue(), finishTime, endVal);
	}
}
