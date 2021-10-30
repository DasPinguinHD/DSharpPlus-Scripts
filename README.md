# DSharpPlus-Scripts

This repository contains some useful Scripts to be used with your D#+ Discord Bot!

All the event handlers need the following thre properties, just put this at the beginning of your Public Bot():

        public DiscordClient Client { get; private set; }
        public CommandsNextExtension Commands { get; private set; }
        public Dictionary<ulong, ulong> SpamProtection { get; private set; }

