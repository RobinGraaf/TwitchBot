# Twitch Bot

A twitch bot written in **C# .NET** with the help of **JSON.NET**. This twitch bot has a point system, with which viewers can bet their points for a change to double their bet. There's also a raffle minigame included, which picks one viewer from the lists as a winner.

### What I've Learned

* Creating a C# .NET Form application
* Reading and writing from a TCP Client in .NET
* Using Json (JObjects and JArrays)
* Saving and reading Json objects from .txt files.

## How To Setup

1. Create a new twitch account for your bot (e.g. RobinGraaf_bot)
2. Make sure it's verified via e-mail (some channels needs this to talk)
3. Keep this account logged into twitch for now
4. Start TwitchBot.exe
5. Fill in your Channel name
6. Fill in the bot name (which you just made)
7. Make sure you're logged into twitch on the bot account
8. Click the 'Get Token' link to generate an OAUTH token (**DO NOT SHARE THIS TOKEN!**)
9. Copy this token into the text field
10. Press 'Start Bot' to start the bot (once pressed, everything you just filled in will be saved)
11. You can now log back into your own twitch account

### Extra info
* If you want the bot to be able to 'spam' chat (send more messages than usual), make sure the bot is a moderator of the channel.
* You can add more command (currently only bot responses) via the Add Command button.
* You can change the bot prefix (default: '!'), and the amount of time a viewer has to watch to score points via the Other Settings button.
