using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIGroupFader : MonoBehaviour {

	private MaskableGraphic[] elements;
	private float currentOpacity;

	[Tooltip("How quickly to perform the fade.")]
	public float changeRate = 1.0f;

	[Tooltip("Time (sec) after which the fade should begin.")]
	public float changeDelay = 0.0f;

	[Tooltip("Starting opacity level.")]
	public float startOpacity = 0.0f;

	[Tooltip("Opacity level to fade to.")]
	public float goalOpacity = 1.0f;

	// Advances a value at a specified speed, stopping it once it reaches that value.
	//
	// val: current value
	// goal: goal value
	// speed: rate at which to move toward goal.
	//
	private float AdvanceValue( float val, float goal, float speed) {
		if (val < goal) {
			val += speed * Time.deltaTime;
			val = val > goal ? goal : val;
		} else if (val > goal) {
			val -= speed * Time.deltaTime;
			val = val < goal ? goal : val;
		}
		return val;
	}

	void Awake()
	{
		elements = gameObject.GetComponentsInChildren<MaskableGraphic> ();

		// If I have my own element, add that too.
		MaskableGraphic myElem = gameObject.GetComponent<MaskableGraphic> ();
		if (myElem) {
			MaskableGraphic[] newList = new MaskableGraphic[elements.Length + 1];
			for (int i = 0; i < elements.Length; i++) {
				newList [i] = elements [i];
			}
			newList [newList.Length - 1] = myElem;
			elements = newList;
		}

		SetFade (startOpacity);
	}

	void Update()
	{
		if (changeDelay <= 0.0f) {
			if (currentOpacity != goalOpacity) {
				float newOpacity = AdvanceValue (currentOpacity, goalOpacity, changeRate);
				SetFade (newOpacity);
			}
		} else {
			changeDelay -= Time.deltaTime;
		}
	}

	// Set the fade amount on all elements in children.
	//
	void SetFade(float opacity = 1.0f)
	{
		currentOpacity = opacity;
		foreach (MaskableGraphic mg in elements) {
			mg.color = new Color(mg.color.r, mg.color.g, mg.color.b, currentOpacity);
		}
	}

	// Start a new fade.
	//
	// opacity: opacity level to fade to.
	// timeSec: time in seconds over which to perform the fade.
	// delay (optional): time to wait before performing the fade.
	//
	public void Fade(float opacity, float timeSec = 0.0f, float delay = 0.0f)
	{
		goalOpacity = opacity;
		changeDelay = delay;
		if (timeSec <= 0.0f) {
			SetFade (goalOpacity);
		} else {
			changeRate = 1.0f / timeSec;
		}
	}
}

//child of this root will be affected. 
