using BepInEx;
using System;
using UnityEngine;
using Utilla;
using TMPro;
using Photon.Pun;
using System.Collections;

namespace MOTD_stats
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;
        private TextMeshPro motdTextObject;
        private TextMeshPro motdNameObject;

       
        // actually going to add some comments for the first time because i've realised how annoying it is to read code without them
        void Update()
        {
            GameObject motdGameObject = GameObject.Find("motdtext");

            if (motdGameObject != null)
            {
                motdTextObject = motdGameObject.GetComponent<TextMeshPro>();

                if (motdTextObject != null)
                {
                    StartCoroutine(UpdateMotdAfterDelay());
                }
                else
                {
                    Debug.LogError("TextMeshPro component not found on 'motdtext'!");
                }
            }
            else
            {
                Debug.LogError("GameObject 'motdtext' not found!");
            }

            GameObject motdname = GameObject.Find("motd (1)");

            if (motdname != null)
            {
                motdNameObject = motdname.GetComponent<TextMeshPro>();

                if (motdNameObject != null)
                {
                    StartCoroutine(UpdateMotdAfterDelay1());
                }
                else
                {
                    Debug.LogError("TextMeshPro component not found on 'motdtext'!");
                }
            }
            else
            {
                Debug.LogError("GameObject 'motdtext' not found!");
            }
        }



        private IEnumerator UpdateMotdAfterDelay()
        {
            yield return new WaitForSeconds(1f);

            if (PhotonNetwork.InRoom)
            {
                string roomName = PhotonNetwork.CurrentRoom.Name;
                string ping = PhotonNetwork.GetPing().ToString();
                string fps = (1.0f / Time.unscaledDeltaTime).ToString("f1");
                string ownid = PhotonNetwork.LocalPlayer.UserId.ToString();

                motdTextObject.SetText($"PING = {ping};    FPS = {fps};    CURRENT ROOM: {roomName}");

                foreach (var player in PhotonNetwork.CurrentRoom.Players.Values)
                {
                    // my id lmfao

                    if (player.UserId == "F6614A578BC3A81")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n HEY LOOK IT'S ME! CO. (oculus pc account) = {player.UserId}");
                        Debug.LogWarning($"CO in room!: {player.UserId}");
                    }

                    //moderator id's

                    if (player.UserId == "1D6E20BE9655C798")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n MODERATOR! TTTPIG (oculus) = {player.UserId}");
                        Debug.LogWarning($"moderator tttpig in room: {player.UserId}");
                    }

                    if (player.UserId == "22A7BCEFFD7A0BBA")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n MODERATOR! TTTPIG (steam) = {player.UserId}");
                        Debug.LogWarning($"moderator tttpig in room: {player.UserId}");
                    }

                    if (player.UserId == "ECDE8A2FF8510934")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n MODERATOR! ANTOCA = {player.UserId}");
                        Debug.LogWarning($"moderator antoca in room: {player.UserId}");
                    }

                    if (player.UserId == "C3878B068886F6C3")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n MODERATOR! ZZEN = {player.UserId}");
                        Debug.LogWarning($"moderator zzen in room: {player.UserId}");
                    }

                    if (player.UserId == "AAB44BFD0BA34829")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n EX MODERATOR! BODA = {player.UserId}");
                        Debug.LogWarning($"ex moderator boda in room: {player.UserId}");
                    }

                    if (player.UserId == "F5B5C64914C13B83")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n MODERATOR! HATGIRL = {player.UserId}");
                        Debug.LogWarning($"moderator hatgirl in room: {player.UserId}");
                    }

                    if (player.UserId == "80279945E7D3B57D")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n EX MODERATOR! JOLYNE = {player.UserId}");
                        Debug.LogWarning($"ex moderator jolyne in room: {player.UserId}");
                    }

                    if (player.UserId == "80279945E7D3B57D")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n EX MODERATOR! JOLYNE = {player.UserId}");
                        Debug.LogWarning($"ex moderator jolyne in room: {player.UserId}");
                    }

                    //electronic's id's (has playfab access)

                    if (player.UserId == "42C809327652ECDD")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n MODERATOR! ELECTRONIC = {player.UserId}");
                        Debug.LogWarning($"moderator electronic in room: {player.UserId}");
                    }

                    if (player.UserId == "7F31BEEC604AE18B")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n MODERATOR! ELECTRONIC = {player.UserId}");
                        Debug.LogWarning($"moderator electronic in room: {player.UserId}");
                    }

                    if (player.UserId == "5FD1FF848372920E")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n MODERATOR! ELECTRONIC = {player.UserId}");
                        Debug.LogWarning($"moderator electronic in room: {player.UserId}");
                    }

                    // lemming's id's 

                    if (player.UserId == "BC99FA914F506AB8")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n LEMMING! (steam) = {player.UserId}");
                        Debug.LogWarning($"lemming in room: {player.UserId}");
                    }

                    if (player.UserId == "3A16560CA65A51DE")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n LEMMING! (quest) = {player.UserId}");
                        Debug.LogWarning($"lemming in room: {player.UserId}");
                    }

                    //people that wanted to be added lmfao

                    if (player.UserId == "69A435FFE0F643E8")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n E140 (WANTED TO BE ADDED)  = DOES NOT WANT ID ADDED :(");
                        Debug.LogWarning($"E140 in room: {player.UserId}");
                    }

                    if (player.UserId == "3A1C529442B4AAD8")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n XENONORSOMETHING (WANTED TO BE ADDED)  = {player.UserId}");
                        Debug.LogWarning($"xenonorsomething in room: {player.UserId}");
                    }

                    if (player.UserId == "5883370AB0CBD7B")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n CIPERUOY (WANTED TO BE ADDED)  = {player.UserId}");
                        Debug.LogWarning($"xenonorsomething in room: {player.UserId}");
                    }


                    // content creators

                    if (player.UserId == "D6971CA01F82A975")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n  CONTENT CREATOR! ELLIOT  = {player.UserId}");
                        Debug.LogWarning($"elliot in room: {player.UserId}");
                    }

                    if (player.UserId == "7FB16B1EDEB71A4C")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n  CONTENT CREATOR! ELLIOT  = {player.UserId}");
                        Debug.LogWarning($"elliot in room: {player.UserId}");
                    }

                    if (player.UserId == "9DBC90CF7449EF64")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n  CONTENT CREATOR! STYLEDSNAIL  = {player.UserId}");
                        Debug.LogWarning($"styledsnail in room: {player.UserId}");
                    }

                    if (player.UserId == "1D6C2A5C6B419BFE")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n  CONTENT CREATOR! STYLEDSNAIL  = {player.UserId}");
                        Debug.LogWarning($"styledsnail in room: {player.UserId}");
                    }

                    if (player.UserId == "A04005517920EB0")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n  CONTENT CREATOR! K9  = {player.UserId}");
                        Debug.LogWarning($"k9 in room: {player.UserId}");
                    }

                    if (player.UserId == "A6FFC7318E1301AF")
                    {
                        motdTextObject.SetText(motdTextObject.text + $"\n \n  CONTENT CREATOR! JMANCURLY  = {player.UserId}");
                        Debug.LogWarning($"jmancurly in room: {player.UserId}");
                    }

                }

                Debug.Log($"JOINED ROOM: {roomName}");
            }
            else
            {
                motdTextObject.SetText("JOIN A ROOM TO SHOW STATS! \n \n CURRENT ROOM: NOT CURRENTLY IN A ROOM!.");
                Debug.Log("No longer in room!");
            }
        }





        private IEnumerator UpdateMotdAfterDelay1()
        {
            yield return new WaitForSeconds(1f);

            motdNameObject.SetText("CO'S MOTD STUFF");
            Debug.Log("rizz trust");
        }







        /* This attribute tells Utilla to call this method when a modded room is joined */
        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
           

            inRoom = true;
        }

        /* This attribute tells Utilla to call this method when a modded room is left */
        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {
            /* Deactivate your mod here */
            /* This code will run regardless of if the mod is enabled*/

            inRoom = false;
        }
    }
}
