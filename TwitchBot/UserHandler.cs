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
        

        private static List<string> _knownUsernames = new List<string>();
        private static List<User> _users = new List<User>();
        private static List<string> _allChatters = new List<string>();
        private static JArray _usersArray;

        public static void SetupUsers()
        {
            if (!File.Exists("users.txt")) { File.Create("users.txt"); }

            dynamic allUsers = File.ReadAllText("users.txt");

            if (allUsers.Length > 0) {
                _usersArray = new JArray();
                _usersArray = JArray.Parse(allUsers);
                _users = _usersArray.ToObject<List<User>>();
            }
        }

        public static void AddPointsToAll()
        {
            GetViewers();
            
            _knownUsernames = _users.Select(u => u.Username).ToList();

            // Compare viewers to users
            var usersAndChatters = _knownUsernames.Intersect(_allChatters).ToList();
            var chattersNotUsers = _allChatters.Except(_knownUsernames).ToList();

            // Add new user or add points to users
            foreach (var user in usersAndChatters)
            {
                _users.First(u => u.Username == user).Points += 1;

                UpdateUsers();
            }

            foreach (string chatter in chattersNotUsers)
            {
                AddNewUser(chatter);
            }

            ChatLink.ChatLog += $"\r\n[{DateTime.Now}] Adding Points!";
        }

        public static void AddPointsToUser(string user, int points)
        {
            _users.First(u => u.Username == user).Points += points;
            UpdateUsers();
        }

        public static void RemovePointsFromUser(string user, int points) {
            _users.First(u => u.Username == user).Points -= points;
            UpdateUsers();
        }

        private static void UpdateUsers()
        {
            _usersArray = new JArray();
            _usersArray.Add(_users.Select(u => new JObject
            {
                {"Username", u.Username},
                {"Points", u.Points}
            }));

            File.WriteAllText("users.txt", _usersArray.ToString());
        }

        private static void GetViewers()
        {
            using (var webClient = new System.Net.WebClient()) {
                dynamic allChatters = webClient.DownloadString("https://tmi.twitch.tv/group/user/" + ChatLink.Channel.ToLower() + "/chatters");
                JObject allChattersObj = JObject.Parse(allChatters);

                JArray broadcasterArray = (JArray)allChattersObj["chatters"]["broadcaster"];
                JArray vipsArray = (JArray)allChattersObj["chatters"]["vips"];
                JArray moderatorsArray = (JArray)allChattersObj["chatters"]["moderators"];
                JArray viewersArray = (JArray) allChattersObj["chatters"]["viewers"];

                List<string> broadcasters = new List<string>();
                List<string> vips = new List<string>();
                List<string> moderators = new List<string>();
                List<string> viewers = new List<string>();

                if (broadcasterArray.Count > 0) { broadcasters = broadcasterArray.Select(b => (string)b).ToList(); }
                if (vipsArray.Count > 0) { vips = vipsArray.Select(v => (string)v).ToList(); }
                if (moderatorsArray.Count > 0) { moderators = moderatorsArray.Select(m => (string)m).ToList(); }
                if (viewersArray.Count > 0) { viewers = viewersArray.Select(u => (string) u).ToList(); }

                _allChatters = new List<string>(broadcasters.Concat(vips).Concat(moderators).Concat(viewers));
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

        public static int GetPointsFromUser(string speaker)
        {
            if (_users.Count > 0 && _users != null)
            {
                return _users.First(u => u.Username.ToLower() == speaker.ToLower()).Points;
            }
            else return 0;
        }
    }
}
