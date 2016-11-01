﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using TrackShack.Data;

namespace TrackShack.Controls
{
    [TypeDescriptionProvider(typeof(TrackShackWindowDescriptionProvider<TrackShackWindow, Form>))]
    public class TrackShackWindow : Form
    {
        public TrackShackWindow()
            : this(null)
        {
        }

        public TrackShackWindow(TrackWrapper track)
        {
            Track = track;

            TrackShackAlerts.TrackNameChanged += new TrackShackAlerts.TrackNameChangedEvent(ChompShopAlerts_TrackNameChanged);
        }

        private void ChompShopAlerts_TrackNameChanged(TrackWrapper wrapper)
        {
            if (Track == wrapper)
            {
                //Need invoke?
                ResetTitleText();
            }

            TrackNameUpdated(wrapper);
        }

        protected virtual void TrackNameUpdated(TrackWrapper wrapper)
        {

        }

        public virtual void InitData()
        {
            throw new NotImplementedException();
        }

        protected void ResetTitleText()
        {
            if (Track != null)
                this.Text = string.Format(TitleText, Track.ToString()); //Fix this eventually!!
            else
                this.Text = TitleText;
        }

        protected virtual string TitleText { get { throw new NotImplementedException(); } }

        public virtual TrackShackWindowType WindowType { get { throw new NotImplementedException(); } }

        public TrackWrapper Track { get; protected set; }

        protected TrackShackForm ChompShopForm { get { return (TrackShackForm)this.MdiParent; } }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TrackShackWindow
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "TrackShackWindow";
            this.ResumeLayout(false);

        }
    }

    //Needed this to fix a designer bug: see 
    // http://stackoverflow.com/questions/1620847/how-can-i-get-visual-studio-2008-windows-forms-designer-to-render-a-form-that-im/2406058#2406058
    public class TrackShackWindowDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider
    {
        public TrackShackWindowDescriptionProvider()
            : base(TypeDescriptor.GetProvider(typeof(TAbstract)))
        {
        }

        public override Type GetReflectionType(Type objectType, object instance)
        {
            if (objectType == typeof(TAbstract))
                return typeof(TBase);

            return base.GetReflectionType(objectType, instance);
        }

        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
            if (objectType == typeof(TAbstract))
                objectType = typeof(TBase);

            return base.CreateInstance(provider, objectType, argTypes, args);
        }
    }
}
