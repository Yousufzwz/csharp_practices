﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesForExam_3;

public delegate void EventHandler(string message);

public class Notifier
{
    public event EventHandler Notification;

    public void SendNotification(string message)
    {
        if (Notification != null)
        {
            Notification(message);
        }
    }
}
