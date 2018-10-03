using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinWeatherApp.Common
{
    class Common
    {
        public static string API_KEY = "8bf43165ce1682c532b8d2a39f38a6f2";
        public static string API_LINK = "http://api.openweathermap.org/data/2.5/weather";

            public static string APIRequest(string lat, string lng)
        {
            StringBuilder sb = new StringBuilder(API_LINK);
            sb.AppendFormat("?q=Stockholm&APPID={2}&units=metric", lat,lng,API_KEY);
            return sb.ToString();
        }

        public static DateTime UnixTimeStampToDate(double unixTimeStamp)
            {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                dt = dt.AddSeconds(unixTimeStamp).ToLocalTime();
            return dt;
        }

        public static string GetImage(string icon)
        {
            return $"http://openweathermap.org/img/w/{icon}.png";
        }

    }
}