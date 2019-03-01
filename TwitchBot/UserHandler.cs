using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TwitchBot {
    public class UserHandler {
        private static List<string> viewers = new List<string>();
        private static List<string> knownUsernames = new List<string>();
        private static List<User> users = new List<User>();
        private static JArray usersArray;

        public static void AddPoints()
        {
            GetViewers();
            if (!File.Exists("users.txt")) { File.Create("users.txt"); }

            dynamic allUsers = File.ReadAllText("users.txt");

            if (allUsers.Length > 0)
            {
                usersArray = new JArray();
                usersArray = JArray.Parse(allUsers);
                users = usersArray.ToObject<List<User>>();
            }

            knownUsernames = users.Select(u => u.Username).ToList();

            // Compare viewers to users
            var usersAndViewers = knownUsernames.Intersect(viewers).ToList();
            var viewersNotUsers = viewers.Except(knownUsernames).ToList();

            // Add new user or add points to users
            foreach (var user in usersAndViewers)
            {
                users.First(u => u.Username == user).Points += 1;

                usersArray = new JArray();
                usersArray.Add(users.Select(u => new JObject
                {
                    {"Username", u.Username},
                    {"Points", u.Points}
                }));

                File.WriteAllText("users.txt", usersArray.ToString());
            }

            foreach (string viewer in viewersNotUsers)
            {
                AddNewUser(viewer);
            }
        }

        private static void GetViewers()
        {
            using (var webClient = new System.Net.WebClient()) {
                dynamic allChatters = webClient.DownloadString("https://tmi.twitch.tv/group/user/" + ChatLink.Channel.ToLower() + "/chatters");
                JObject allChattersObj = JObject.Parse(allChatters);
                JArray allChattersArray = (JArray) allChattersObj["chatters"]["viewers"];
                if (allChattersArray.Count > 0)
                {
                    viewers = allChattersArray.Select(u => (string) u).ToList();
                }
            }
        }

        private static void AddNewUser(string username)
        {
            User newUser = new User
            {
                Username = username,
                Points = 0
            };
            users.Add(newUser);

            usersArray = new JArray();
            usersArray.Add(users.Select(c => new JObject
            {
                {"Username", c.Username},
                {"Points", c.Points}
            }));

            File.WriteAllText("users.txt", usersArray.ToString());
        }

        public static void ClearPoints()
        {
            File.WriteAllText("users.txt", "");
            users?.Clear();
            usersArray?.Clear();
        }
    }
}
