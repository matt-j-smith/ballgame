#!/bin/bash
if type mplayer>/dev/null;
then
        mplayer http://tunein.streamguys1.com/$1
else
        echo "You'll need to install mplayer to play audio from the terminal"
fi
