using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class DisplayTotalWeight : MonoBehaviour
{
	private TextMeshProUGUI _text;
	
	private void Awake()
	{
		_text = GetComponent<TextMeshProUGUI>();
	}

	public void SetTotalWeight(float weight)
	{
		_text.text = $"{weight} kg";
	}
}