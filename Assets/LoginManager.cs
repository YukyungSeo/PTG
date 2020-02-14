using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    [Header("LoginPanel")]
    public InputField IDInputField;
    public InputField PasswordInputField;

    [Header("CreateAccountPanel")]
    public InputField New_IDInputField;
    public InputField New_PasswordInputField;

    public string LoginUrl;

    // Start is called before the first frame update
    void Start()
    {
        LoginUrl = "localhost/Login.php";
    }

    public void LoginButton()
    {
        StartCoroutine(LoginCoroutine());
    }

    IEnumerator LoginCoroutine()
    {
        Debug.Log(IDInputField.text);
        Debug.Log(PasswordInputField.text);

        WWWForm form = new WWWForm();
        form.AddField("Input_user", IDInputField.text);
        form.AddField("Input_pass", PasswordInputField.text);

        WWW webRequest = new WWW(LoginUrl, form);

        yield return webRequest;

        Debug.Log(webRequest.text);
    }

    public void CreateAccountButton()
    {
        Debug.Log("CreateAccount");
        //StartCoroutine(LoginCoroutine());
    }

    /*IEnumerator CreateAccountCoroutine()
    {
        Debug.Log(IDInputField.text);
        Debug.Log(PasswordInputField.text);

        yield return null;
    }*/
}
