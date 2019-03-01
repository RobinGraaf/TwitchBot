using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TwitchBot {
    public partial class AddCommandForm : Form
    {
        private IList<Command> commands = new List<Command>();
        JArray commandArray = new JArray();
        private bool commandIsSet,responseIsSet,descriptionIsSet;

        public AddCommandForm() {
            InitializeComponent();
        }

        private void saveCommandButton_Click(object sender, EventArgs e) {

            dynamic allCommands = File.ReadAllText("botcommands.txt");

            if (allCommands.Length > 0)
            {
                commandArray = JArray.Parse(allCommands);
            }

            Command command = new Command();

            commandIsSet = TextBoxHandler.CheckForInput(commandTextBox, out var commandText);
            if (commandText.StartsWith(ChatLink.BotCommandPrefix))
            {
                commandText = commandText.Replace(ChatLink.BotCommandPrefix, "");
            }
            command.CommandText = commandText;

            responseIsSet = TextBoxHandler.CheckForInput(responseTextBox, out var responseText);
            command.Response = responseText;

            descriptionIsSet = TextBoxHandler.CheckForInput(descriptionTextBox, out var descriptionText);
            command.Description = descriptionText;
            
            if (commandIsSet && responseIsSet && descriptionIsSet)
            {
                commands.Add(command);

                commandArray.Add(commands.Select(c => new JObject
                {
                    {"CommandText", c.CommandText},
                    {"Response", c.Response},
                    {"Description", c.Description}
                }));

                File.WriteAllText("botcommands.txt", commandArray.ToString());

                this.Close();
            }
        }
    }
}
