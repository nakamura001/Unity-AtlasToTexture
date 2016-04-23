using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour {
	public Image img;
	public RawImage raw;

	public void OnTest() {
		raw.texture = img.sprite.texture;
		Rect rc = img.sprite.textureRect;
		rc.x = rc.x / img.sprite.texture.width;
		rc.width = rc.width / img.sprite.texture.width;
		rc.y = rc.y / img.sprite.texture.height;
		rc.height = rc.height / img.sprite.texture.height;
		raw.uvRect = rc;
		//img.sprite = null;
	}
}
