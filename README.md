# DSharpPlus-Scripts

This repository contains some useful Scripts to be used with your D#+ Discord Bot!

All the event handlers need the following thre properties, just put this at the beginning of your Public Bot():

```
public DiscordClient Client { get; private set; }
public CommandsNextExtension Commands { get; private set; }
public Dictionary<ulong, ulong> SpamProtection { get; private set; }
```

Whereas Client is:
```
                Client = new DiscordClient(
                new DiscordConfiguration
                {

                    Token = Config.Token, 
                    TokenType = TokenType.Bot,
                    AutoReconnect = true,
                    MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug,
                    Intents = DiscordIntents.All
                }


            );  
```
Commands is:
```
Commands = Client.UseCommandsNext(
                new CommandsNextConfiguration
                {
                    StringPrefixes = new string[] { Config.Prefix },
                    CaseSensitive = false,
                    EnableDms = false,
                    EnableMentionPrefix = false,
                    EnableDefaultHelp = true,
                    DmHelp = false,
                    IgnoreExtraArguments = true,

                }
            );
```
And SpamProtection (For the "did you mean..."-system):
```
            this.SpamProtection = new Dictionary<ulong, ulong>();

``` 
at the beginning of the RunAsync() Task  in your Bot.cs
            
            
            
