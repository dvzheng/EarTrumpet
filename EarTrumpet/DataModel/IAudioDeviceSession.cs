﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EarTrumpet.DataModel
{
    public interface IAudioDeviceSession : IStreamWithVolumeControl
    {
        IEnumerable<IAudioDeviceSessionChannel> Channels { get; }
        IAudioDevice Parent { get; }
        string DisplayName { get; }
        void RefreshDisplayName();
        string ExeName { get; }
        uint BackgroundColor { get; }
        string IconPath { get; }
        bool IsDesktopApp { get; }
        bool IsSystemSoundsSession { get; }
        int ProcessId { get; }
        string AppId { get; }
        SessionState State { get; }
        ObservableCollection<IAudioDeviceSession> Children { get; }
    }
}