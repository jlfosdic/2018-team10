using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(FadeSprite.FadeImage(gameObject.GetComponent<SpriteRenderer>(), 0f, 0f, 0.2f));
        StartCoroutine(Go());
	}

    public IEnumerator Go()
    {
        yield return new WaitForSeconds(2.2f);
        StartCoroutine(FadeSprite.FadeImage(gameObject.GetComponent<SpriteRenderer>(), 0f, 1f, 1.5f));
    }
}
