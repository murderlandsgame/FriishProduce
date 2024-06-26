﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace FriishProduce
{
    public class Language
    {
        private readonly string extension = ".json";
        private readonly byte[] englishFile = Properties.Resources.English;

        protected class LanguageData
        {
            public string language { get; set; }
            public string author { get; set; }
            public string application_title { get; set; }
            public Dictionary<string, Dictionary<string, string>> global { get; set; }
            public Dictionary<string, Dictionary<string, string>> strings { get; set; }
        }

        #region List of currently existing languages
        private SortedDictionary<string, string> _list;
        public SortedDictionary<string, string> List
        {
            get
            {
                string[] fileList = Directory.EnumerateFiles(Paths.Languages, "*.*").Where(x => x.ToLower().EndsWith(extension)).ToArray();

                if (_list?.Count == fileList.Length + 1) return _list;

                _list = new SortedDictionary<string, string>() { { "en", "English" } };

                foreach (var item in fileList)
                {
                    var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures).Where(c => c.Name.StartsWith(Path.GetFileNameWithoutExtension(item)));

                    foreach (CultureInfo culture in cultures)
                    {
                        if (culture.Name == Path.GetFileNameWithoutExtension(item))
                        {
                            // Get native name & capitalize first letter
                            // ****************
                            string langName = culture.NativeName;
                            langName = langName.Substring(0, 1).ToUpper() + langName.Substring(1, langName.Length - 1); ;

                            _list.Add(culture.Name, langName);
                        }
                    }
                }

                _list.Remove(""); // the "Invariant Language (Invariant Country)" item
                _list.Remove("en-001"); // "English (World)"

                return _list;
            }
        }
        #endregion

        private LanguageData _english { get; set; }
        private LanguageData _current { get; set; }
        public string Current { get => _current.language; }
        public string Author { get => _current.author; }
        public string ApplicationTitle { get => _current.application_title ?? _english.application_title; }

        public Language(string code = null)
        {
            if (string.IsNullOrWhiteSpace(code)) code = Properties.Settings.Default.language;

            bool valid = false;
            foreach (var item in List)
            {
                if (item.Key == code) valid = true;
                else if (item.Key.Contains(code)) valid = true;
            }

            if (string.IsNullOrWhiteSpace(code) || !valid)
            {
                code = "sys";
                Properties.Settings.Default.language = "sys";
                Properties.Settings.Default.Save();
            }

            if (_english == null || _english?.language != "en")
            {
                try
                {
                    _english = parseFile(englishFile);
                }

                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show($"A fatal error occurred initializing the program, as the English string resource file was not found or is invalid.\n\nException: {ex.GetType().FullName}\nMessage: {ex.Message}\n\nThe application will now shut down.", "Halt", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Environment.FailFast("Language initialization failed.");
                }
            }

        Set:
            if (code.ToLower() != "sys")
            {
                bool set = false;

                foreach (var item in List.Keys)
                {
                    if (item.ToLower() == code.ToLower())
                    {
                        _current = parseFile(code);
                        set = _current != null;
                    }
                }

                if (!set)
                {
                    code = "sys";
                    Properties.Settings.Default.language = "sys";
                    Properties.Settings.Default.Save();

                    goto Set; // Loop back
                }
            }

            else _current = parseFile(GetSystemLanguage());

            if (string.IsNullOrEmpty(_current.language)) _current = _english;
            else if (_current.language != code) _current.language = code;

            if (_current == null)
            {
                _current = _english;
                Properties.Settings.Default.language = "en";
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.language == "en") _current = _english;

            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(code);
        }

        #region Public methods and variables
        /// <summary>
        /// Returns the current OS language.
        /// </summary>
        public string GetSystemLanguage()
        {
            foreach (var item in List.Keys)
                if (item.ToLower() == CultureInfo.InstalledUICulture.Name.ToLower()) return CultureInfo.InstalledUICulture.Name;

            foreach (var item in List.Keys)
                if (item.ToLower() == CultureInfo.InstalledUICulture.TwoLetterISOLanguageName.ToLower()) return item;

            return "en";
        }

        /// <summary>
        /// Localizes a form using an auto-determined or manually-inputted tag name.
        /// </summary>
        public void Control(Control c, string tag = null)
        {
            if (tag == null) tag = c.Tag != null ? c.Tag?.ToString() : c.Name;

            foreach (Control item1 in c.Controls)
            {
                localize(item1, tag);
                foreach (Control item2 in item1.Controls)
                {
                    localize(item2, tag);
                    foreach (Control item3 in item2.Controls)
                    {
                        localize(item3, tag);
                        foreach (Control item4 in item3.Controls)
                        {
                            localize(item4, tag);
                            foreach (Control item5 in item4.Controls)
                            {
                                localize(item5, tag);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Returns the localized name of a console/platform.
        /// </summary>
        public string Console(Console c) => String(c.ToString().ToLower(), "platforms");

        /// <summary>
        /// Returns a localized message string from the corresponding ID.
        /// </summary>
        /// <param name="isError">Determines if the message should be drawn from the errors category instead.</param>
        public string Msg(int number, bool isError = false) => String((isError ? "e_" : null) + number.ToString("000"), "messages");

        /// <summary>
        /// Returns a localized string which changes depending on a boolean condition. This is the name of the string suffixed with "0" if false, or "1" if true.
        /// </summary>
        public string Toggle(bool activated, string name, string sectionName = "")
        {
            if (activated && StringCheck(name + "1", sectionName)) return String(name + "1", sectionName);
            if (!activated && StringCheck(name + "0", sectionName)) return String(name + "0", sectionName);
            return String(name, sectionName);
        }
        
        /// <summary>
        /// Returns an array of localized strings corresponding to the name input plus a number affixed to the end for each entry. A maximum of 100 entries is allowed.
        /// </summary>
        public string[] StringArray(string name, string sectionName = "")
        {
            List<string> result = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                if (StringCheck(name + i.ToString(), sectionName)) result.Add(String(name + i.ToString(), sectionName));
            }

            return result?.Count > 0 ? result.ToArray() : new string[] { "undefined" };
        }

        /// <summary>
        /// Checks if the input localized string exists in the language file.
        /// </summary>
        public bool StringCheck(string name, string sectionName = "") => String(name, sectionName) != "undefined";

        /// <summary>
        /// Returns a localized string using the identification name, and the name of the section containing said string within the file.
        /// </summary>
        public string String(string name, string sectionName = "")
        {
            if (string.IsNullOrWhiteSpace(name)) return "undefined";

            bool isEnglish = false;

        Top:
            var target = isEnglish ? _english : _current;

            try
            {
                var path = sectionName.ToLower() == "main"
                              || sectionName.ToLower() == "filters"
                              || sectionName.ToLower() == "platforms"
                              || sectionName.ToLower() == "messages" ? target.global : target.strings;

                dynamic result = null;

                if (!string.IsNullOrEmpty(sectionName))
                {
                    if (!path.ContainsKey(sectionName.ToLower())) goto NotFound;

                    foreach (KeyValuePair<string, string> item in path[sectionName.ToLower()])
                    {
                        if (item.Key?.ToLower() == name?.ToLower())
                        {
                            result = item.Value;
                            goto Found;
                        }
                    }
                }

                else
                {
                    foreach (KeyValuePair<string, Dictionary<string, string>> section in target.global)
                    {
                        foreach (KeyValuePair<string, string> item in section.Value)
                        {
                            if (item.Key?.ToLower() == name?.ToLower())
                            {
                                result = item.Value;
                                goto Found;
                            }
                        }
                    }
                }

                if (result == null) goto NotFound;
                else goto Found;

                Found:
                var brackets = new List<Tuple<int, int>>();

                for (int i = 0; i < result.Length; i++)
                {
                    if (result.IndexOf("{", i) != -1)
                        brackets.Add(Tuple.Create(result.IndexOf("{", i), result.IndexOf("}", i)));
                }

                if (brackets.Count > 0)
                {
                    foreach (var (open, close, inside) in from pair in brackets
                                                          let open = pair.Item1
                                                          let close = pair.Item2
                                                          let inside = result.Substring(open + 1, close - open - 1)
                                                          select (open, close, inside))
                    {
                        result = !int.TryParse(inside, out int x) ? result.Replace(result.Substring(open, close - open + 1), String(inside)) : result;
                    }
                }

                return result;
            }

            catch
            {
                goto NotFound;
            }

            NotFound:
            if (!isEnglish)
            {
                isEnglish = true;
                goto Top;
            }

            else
            {
                return "undefined";
            }
        }
        #endregion

        #region Private methods and variables
        private dynamic parseFile(string code)
        {
            if (code.ToLower() != "en")
            {
                try
                {
                    string path = Paths.Languages + code;
                    if (File.Exists(path + extension))
                        return parseFile(File.ReadAllBytes(path + extension));

                    throw new FileNotFoundException();
                }
                catch
                {
                    return null;
                }
            }

            else return parseFile(englishFile);
        }

        private dynamic parseFile(byte[] file)
        {
            dynamic reader = null;

            using (MemoryStream ms = new MemoryStream(file))
            using (StreamReader sr = new StreamReader(ms, Encoding.Unicode))
            using (var fileReader = JsonDocument.Parse(sr.ReadToEnd(), new JsonDocumentOptions() { AllowTrailingCommas = true, CommentHandling = JsonCommentHandling.Skip }))
            {
                reader = JsonSerializer.Deserialize<LanguageData>(fileReader, new JsonSerializerOptions() { AllowTrailingCommas = true, ReadCommentHandling = JsonCommentHandling.Skip });
                sr.Dispose();
                ms.Dispose();
            }

            // var name = reader["language"].ToString();
            // var author = reader["author"].ToString();
            // var appName = reader["application_title"]?.ToString();

            return reader;
        }

        private void localize(Control item, string form)
        {
            if (item.Tag == null) return;

            string name = item.Tag != null ? item.Tag?.ToString() : item.Name;

            if (item.GetType() == typeof(ComboBox))
            {
                string[] targetA = StringArray(name.ToLower(), form.ToLower());

                if (targetA[0] != "undefined")
                {
                    (item as ComboBox).Items.Clear();
                    (item as ComboBox).Items.AddRange(targetA);
                }
            }

            else
            {
                string target = item.GetType() == typeof(JCS.ToggleSwitch) ? Toggle((item as JCS.ToggleSwitch).Checked, name.ToLower(), form.ToLower()) : String(name.ToLower(), form.ToLower());
                if (target == "undefined") target = String(name.ToLower());
                if (target != "undefined") item.Text = target;
            }
        }
        #endregion
    }
}
