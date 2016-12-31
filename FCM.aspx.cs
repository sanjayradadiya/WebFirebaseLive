﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FCM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
        tRequest.Method = "post";
        tRequest.ContentType = "application/json";
        var objNotification = new
        {
            to = "cP6XT-M-4HQ:APA91bFQ8bgFZ_0QE9S7XekE-Bt0G89sOipO0qK_0XX4Y5S2ffqEfjiJPCx5P0JDFbSGEhCsMgovgv4hCiejqFrikvDifRMKjpIY8827rOqHTOKgU2inVjiuSIsxdlb-2rJJgZAW0THM",
            notification = new
            {
                body = "This is the message",
                title = "This is the title",
                click_action = "http://www.yahoo.com"
            }

        };
        string jsonNotificationFormat = Newtonsoft.Json.JsonConvert.SerializeObject(objNotification);
        Byte[] byteArray = Encoding.UTF8.GetBytes(jsonNotificationFormat);
        tRequest.Headers.Add(string.Format("Authorization: key={0}", "AAAAaGSN358:APA91bHeYq6Ywnhj4iSTEhEIr2-LQUziLJR6_ExMf-q1Y_ADM5WMLLw0CB2OK2GR5vltZq7LkrTxXYADgP-cJxXkpa6wxKCE9oFmjP6hWeEfXNOgZx-7-_ymuivxpwyxyy5s21682Xsq2GiQvG8ptt_JJJayUUxpLA"));
        tRequest.Headers.Add(string.Format("Sender: id={0}", "448363618207"));
        tRequest.ContentLength = byteArray.Length;
        tRequest.ContentType = "application/json; charset=UTF-8";
        using (Stream dataStream = tRequest.GetRequestStream())
        {
            dataStream.Write(byteArray, 0, byteArray.Length);

            using (WebResponse tResponse = tRequest.GetResponse())
            {
                using (Stream dataStreamResponse = tResponse.GetResponseStream())
                {
                    using (StreamReader tReader = new StreamReader(dataStreamResponse))
                    {
                        String responseFromFirebaseServer = tReader.ReadToEnd();

                        /*FCMResponse response = Newtonsoft.Json.JsonConvert.DeserializeObject<FCMResponse>(responseFromFirebaseServer);
                        if (response.success == 1)
                        {
                            //new NotificationBLL().InsertNotificationLog(dayNumber, notification, true);
                        }
                        else if (response.failure == 1)
                        {
                            //new NotificationBLL().InsertNotificationLog(dayNumber, notification, false);
                            //sbLogger.AppendLine(string.Format("Error sent from FCM server, after sending request : {0} , for following device info: {1}", responseFromFirebaseServer, jsonNotificationFormat));

                        }*/

                    }
                }

            }
        }

    }
}