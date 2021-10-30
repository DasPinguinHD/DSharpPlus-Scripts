//Bot.cs
//...

public async Task RunAsync() {
Commands.CommandErrored += (cnext, e) =>
            {
                if (e.Exception.GetType() == typeof(DSharpPlus.CommandsNext.Exceptions.CommandNotFoundException))
                {
                    if (e.Context.Message.Content == "$stop")
                        return Task.CompletedTask;

                    if (this.SpamProtection.ContainsKey(e.Context.Guild.Id))
                        if (this.SpamProtection[e.Context.Guild.Id] == e.Context.User.Id)
                            return Task.CompletedTask;

                    this.SpamProtection[e.Context.Guild.Id] = e.Context.User.Id;

                    List<string> possible_cmds = Commands.RegisteredCommands.Keys.Where(
                         cmd => cmd.StartsWith(e.Context.Message.Content.Substring(1, 1))
                     ).ToList();

                    if (possible_cmds.Count > 0)
                    {

                        string content = string.Join(", ", possible_cmds);
                        e.Context.RespondAsync($"**Couldn't find what you're looking for!**ヽ（≧□≦）ノ\nDid you mean any of these? \\(￣︶￣*\\))\n{content}");
                    }
                }
                return Task.CompletedTask;
            };
       }
