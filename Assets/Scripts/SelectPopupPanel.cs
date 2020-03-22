using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class SelectPopupPanel : MonoBehaviour
{
    /// <summary>
    /// left button
    /// </summary>
    [SerializeField]
    private Button _leftButton;

    /// <summary>
    /// right button
    /// </summary>
    [SerializeField]
    private Button _rightButton;

    /// <summary>
    /// wait for user input and return result
    /// </summary>
    /// <returns></returns>
    public async UniTask<string> SelectChoice()
    {
        // show popup
        gameObject.SetActive(true);
        
        // wait for user input
        // UniTask.WhenAny will return Task index which finished
        var result = await UniTask.WhenAny(
            _leftButton.OnClickAsync(),
            _rightButton.OnClickAsync());

        // delete popup
        gameObject.SetActive(false);

        // return select result
        return result == 0 ? "left" : "right";
    }
}
