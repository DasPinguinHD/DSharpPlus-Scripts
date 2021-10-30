//Bot.cs
//...
 public async Task RunAsync()
        {
        //Register Command Classes and Config before this
        
         Client.MessageCreated += async (Client, e) =>
                    {
                        if (!Config.InteractivityList.Contains(e.Guild.Id))
                            return;

                        if (e.Author.IsBot || e.Channel.IsPrivate || !Config.InteractivityList.Contains(e.Guild.Id))
                            return;

                        var cmd = this.Commands.FindCommand(e.Message.Content, out var args);
                        if (cmd == null)
                            return;
                        var ctx = this.Commands.CreateContext(e.Message, Config.Prefix, cmd, args);

                        await Task.Run(async () =>
                        {
                            await cmd.ExecuteAsync(ctx).ConfigureAwait(false);
                        });
                    };
       }
