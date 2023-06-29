using System;
using System.Collections.Generic;

namespace Sanchez.Patcher.Source_files
{
    class Texts
    {
        private static Dictionary<string, string> Text = new Dictionary<string, string>
        {
            {"UNKNOWNERROR",                    "Произошла неизвестная, но критическая ошибка... Сообщение об ошибке, которое может помочь решить проблему: \n{0}"},
            {"MISSINGBINARY",                   "Игра не может быть запущена, так как {0} оцуцтвует."},
            {"MISSINGCONFIG",                   "Настройки не могут быть запущены, т.к. {0} оцуцтвует."},
            {"CANNOTSTART",                     "Не удается запустить игру, вероятно, потому, что если у вас антивирус, пожалуйста, добавьте этот лаунчер исключения."},
            {"NONETWORK",                       "Не удается подключиться к серверу, пожалуйста, проверьте настройки вашей сети и повторите попытку."},
            {"CONNECTING",                      "Подключение к серверу..."},
            {"LISTDOWNLOAD",                    "Загружаю список исправлений..."},
            {"CHECKFILE",                       "{0} проверка..."},
            {"DOWNLOADFILE",                    "{0} загрузка... {1}/ {2}"},
            {"COMPLETEPROGRESS",                "Загружено: {0}%"},
            {"CURRENTPROGRESS",                 "Per file progress: {0}%  |  {1} kb/s"},
            {"CHECKCOMPLETE",                   "Файлы были проверены и они актуальны."},
            {"DOWNLOADCOMPLETE",                "Все файлы были загружены."},
            {"DOWNLOADSPEED",                   "{0} kb/s"}
        };

        public static string GetText(string Key, params object[] Arguments)
        {
            foreach (var currentItem in Text)
            {
                if(currentItem.Key == Key)
                {
                    return string.Format(currentItem.Value, Arguments); 
                }
            }

            return null;
        }
    }
}
