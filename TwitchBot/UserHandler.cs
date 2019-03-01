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
        private static List<string> _viewers = new List<string>();
        private static List<string> _knownUsernames = new List<string>();
        private static List<User> _users = new List<User>();
        private static JArray _usersArray;

        public static void AddPoints()
        {
            GetViewers();
            if (!File.Exists("users.txt")) { File.Create("users.txt"); }

            dynamic allUsers = File.ReadAllText("users.txt");

            if (allUsers.Length > 0)
            {
                _usersArray = new JArray();
                _usersArray = JArray.Parse(allUsers);
                _users = _usersArray.ToObject<List<User>>();
            }

            _knownUsernames = _users.Select(u => u.Username).ToList();

            // Compare viewers to users
            var usersAndViewers = _knownUsernames.Intersect(_viewers).ToList();
            var viewersNotUsers = _viewers.Except(_knownUsernames).ToList();

            // Add new user or add points to users
            foreach (var user in usersAndViewers)
            {
                _users.First(u => u.Username == user).Points += 1;

                _usersArray = new JArray();
                _usersArray.Add(_users.Select(u => new JObject
                {
                    {"Username", u.Username},
                    {"Points", u.Points}
                }));

                File.WriteAllText("users.txt", _usersArray.ToString());
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
                    _viewers = allChattersArray.Select(u => (string) u).ToList();
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
            _users.Add(newUser);

            _usersArray = new JArray();
            _usersArray.Add(_users.Select(c => new JObject
            {
                {"Username", c.Username},
                {"Points", c.Points}
            }));

            File.WriteAllText("users.txt", _usersArray.ToString());
        }

        public static void ClearPoints()
        {
            File.WriteAllText("users.txt", "");
            _users?.Clear();
            _usersArray?.Clear();
        }
    }
}
