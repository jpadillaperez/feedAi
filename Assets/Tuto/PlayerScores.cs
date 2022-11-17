using System.Collections;
using System.Collections.Generic;
using FullSerializer;
using Proyecto26;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayerScores : MonoBehaviour
{
    //public Text scoreText;
    //public InputField getScoreText;
    public Text showname;
    public GameObject PanelWelcome;

    public InputField usernameTextup;
    public InputField emailTextup;
    public InputField passwordTextup;

    public InputField emailTextin;
    public InputField passwordTextin;

    User user = new User();

    private string AuthKey = "AIzaSyBplt0910UW4p0oOkPbpjJQo6NFspVkfrE";
    private string databaseURL = "https://fedai-d998c.firebaseio.com/users";

    public static fsSerializer serializer = new fsSerializer();

    //public static int playerScore;
    public static string playerName;


    private string idToken;

    public static string localId;

    private string getLocalId;

    public void OnSubmit()
    {
        PostToDatabase();
    }
    
    public void OnGetScore()
    {
        GetLocalId();
    }

    private void ShowData()
    {
        PanelWelcome.SetActive(true);
        showname.text = "Welcome " + user.userName + "!";
    }

    private void PostToDatabase()
    {
        User user = new User();
        RestClient.Put(databaseURL + "/" + localId + ".json?auth=" + idToken, user);
    }

    private void RetrieveFromDatabase(bool flag = false)
    {
        RestClient.Get<User>(databaseURL + "/" + getLocalId + ".json?auth=" + idToken).Then(response =>
            {
                user = response;
                if (flag)
                {
                    ShowData();
                }

            });
    }
    
    public void SignUpUserButton()
    {
        //showname.text = "Username': " + usernameText.text;
        //string name = playerName;
        SignUpUser(emailTextup.text, usernameTextup.text, passwordTextup.text);
        System.Threading.Thread.Sleep(5000);
        SignInUserButton();

    }

    public void SignInUserButton()
    {
        SignInUser(emailTextin.text, passwordTextin.text);
        GetLocalId();

    }
    private void SignUpUser(string email, string username, string password)
    {
        string userData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\",\"returnSecureToken\":true}";
        RestClient.Post<SignResponse>("https://www.googleapis.com/identitytoolkit/v3/relyingparty/signupNewUser?key=" + AuthKey, userData).Then(
            response =>
            {
                idToken = response.idToken;
                localId = response.localId;
                playerName = username;
                PostToDatabase();

            }).Catch(error =>
            {
                Debug.Log(error);
            });
    }

    private void SignInUser(string email, string password)
    {
        string userData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\",\"returnSecureToken\":true}";
        RestClient.Post<SignResponse>("https://www.googleapis.com/identitytoolkit/v3/relyingparty/verifyPassword?key=" + AuthKey, userData).Then(
            response =>
            {
                idToken = response.idToken;
                localId = response.localId;
                GetUsername();

                RetrieveFromDatabase(false);

            }).Catch(error =>
            {
                Debug.Log(error);
            });
    }


    private void GetUsername()
    {
        RestClient.Get<User>(databaseURL + "/" + localId + ".json?auth=" + idToken).Then(response =>
        {
            playerName = response.userName;
        });
    }

    private void GetLocalId()
    {
        int count = 0;
        RestClient.Get(databaseURL + ".json?auth=" + idToken).Then(response =>
        {
            var username = playerName;

            fsData userData = fsJsonParser.Parse(response.Text);
            Dictionary<string, User> users = null;
            serializer.TryDeserialize(userData, ref users);

            foreach (var user in users.Values)
            {
                if (user.userName == username)
                {
                    getLocalId = user.localId;
                    RetrieveFromDatabase(true);
                    break;
                }
            }



        }).Catch(error =>
        {

            Debug.Log(error + "error in GetLocalID");
            System.Threading.Thread.Sleep(500);
            count = count + 1;
            if (count < 5)
            {
                GetLocalId();
            }
        });
    }
}
