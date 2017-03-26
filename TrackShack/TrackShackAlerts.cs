﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pitstop64.Data.Tracks;
using TrackShack.Data;

namespace TrackShack
{
    public static class TrackShackAlerts
    {
        //Here we'll have a ton of delegates that'll alert us when certain events happen.

        //Update a tracks's name: often requires a change across forms
        public delegate void TrackNameChangedEvent(TrackWrapper track);
        public static event TrackNameChangedEvent TrackNameChanged = delegate { };
        public static void UpdateTrackName(TrackWrapper track)
        {
            TrackNameChanged(track);
        }

        public delegate void TrackChangedEvent();
        public static event TrackChangedEvent TrackChanged = delegate { };
        public static void NewTrack()
        {
            TrackChanged();
        }

    }
}
