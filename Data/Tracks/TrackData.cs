﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cereal64.Common.Utils.Encoding;
using Cereal64.Common.Rom;
using System.Xml.Linq;
using Cereal64.Microcodes.F3DEX.DataElements;

namespace MK64Pitstop.Data.Tracks
{
    public class TrackData : RomItem
    {
        //public 

        public MIO0Block ItemsBlock { get; private set; }
        public MIO0Block VertexBlock { get; private set; }
        public DmaAddressBlock TextureReferences { get; private set; }

        public TrackItemsBlock TrackItems { get; private set; }
        public VertexCollection Vertices { get; private set; }
        public F3DEXCommandCollection F3DCommands { get; private set; }
        public List<TrackTextureRef> TextureReferences { get; private set; }


        public uint VertexBank { get; private set; }
        public uint Unknown1 { get; private set; }
        public uint TableSeg { get; private set; }
        public uint Unknown2 { get; private set; }

        public string TrackName { get; set; }
        public bool IsOriginalTrack { get; private set; }

        public TrackData(string trackName, bool originalTrack)
        {
            TrackName = trackName;
            IsOriginalTrack = originalTrack;
        }

        public TrackData(TrackData origTrack)
            : this (origTrack.TrackName, origTrack)
        {

        }

        public TrackData(string newName, TrackData origTrack)
        {
            TrackName = newName;
        }

        public TrackData(XElement xml)
        {

        }

        public override XElement GetAsXML()
        {
            return GetAsXML(false);
        }

        public XElement GetAsXML(bool formatForExternalSave)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return TrackName;
        }

        public override string GetXMLPath()
        {
            return "Tracks/" + TrackName;
        }

        public static void SaveTracks(string fileName, IList<TrackData> tracks)
        {
            throw new NotImplementedException();
        }

        public static List<TrackData> LoadFromFile(string fileName)
        {
            throw new NotImplementedException();
        }

    }
}
