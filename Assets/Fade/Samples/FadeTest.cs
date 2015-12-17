/*
 The MIT License (MIT)

Copyright (c) 2013 yamamura tatsuhiko

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using UnityEngine;
using System.Collections;

public class FadeTest : MonoBehaviour 
{
	private bool isMainColor = false;
	[SerializeField] Color color1 = Color.white, color2 = Color.white;
	[SerializeField] UnityEngine.UI.Image image = null;

	[SerializeField]
	CanvasGroup group = null;

	[SerializeField]
	Fade fade = null;

	public void Fadeout()
	{
		group.blocksRaycasts = false;
		fade.FadeIn (1, () =>
		{
			image.color = (isMainColor) ? color1 : color2;
			isMainColor = !isMainColor;
			fade.FadeOut(1, ()=>{
				group.blocksRaycasts = true;
			});
		});
	}
}
