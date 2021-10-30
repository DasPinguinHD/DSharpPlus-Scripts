//Bot.cs
//...


public async Task RunAsync() 
       {

Client.VoiceStateUpdated += async (Client, e) =>
            {

                DiscordChannel channel = e.Guild.Id switch
                {
                    721394745921765416 => await Client.GetChannelAsync(800431788014436392),
                    568872786798444554 => await Client.GetChannelAsync(568872786798444557),
                    _ => null,
                };
                VoiceNextExtension vnext = Client.GetVoiceNext();
                try
                {
                    var connection = vnext.GetConnection(e.Guild);
                    if (connection is null)
                        return;

                    if (connection.TargetChannel.Users.Count <= 1)
                    {


                        vnext.GetConnection(e.Guild).Disconnect();
                        //if(Config.)
                        await Client.SendMessageAsync(channel, $"I disconnected, because I was left alone in vc .·´¯(>▂<)¯`·. ");

                    };
                    
                    //...
                    
        }
