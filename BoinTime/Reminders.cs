using BoinMsgNS;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace BoinTime {
    public class Reminders {

        public const string FILE_PATH = "reminders.json";

        // set up singleton instance
        static Reminders _instance;
        public static Reminders instance {
            get {
                if (_instance == null) {
                    _instance = new Reminders();
                }

                return _instance;
            }
        }

        public List<Reminder> list { get; private set; }

        private Reminders() {
            list = new List<Reminder>();

            // try to load reminders from FILE_PATH, tell the user if we can't
            if (!load()) {
                BoinMsg.show("Could not access '" + FILE_PATH + "'. Your reminders will not be saved.", "Error - BoinTime");
            }
        }

        /// <summary>
        /// Loads reminders from file into Reminders.instance.list
        /// </summary>
        /// <returns>false if an exception was thrown</returns>
        public bool load() {
            try {
                // if our file isn't there, make it
                if (!File.Exists(FILE_PATH)) {
                    using (var writer = File.CreateText(FILE_PATH)) {
                        writer.Write("");
                    }
                }

                // load json object in from FILE_PATH
                string json = File.ReadAllText(FILE_PATH);

                // if the file wasn't empty, deserialize and put it into this.list
                if (json != "") {
                    list = JsonConvert.DeserializeObject<List<Reminder>>(json);
                }

            } catch {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Serialize Reminders.instance.list to JSON and write it to a file at /
        /// </summary>
        /// <returns>false if an exception was thrown</returns>
        public bool save() {
            try {
                // serialize to JSON, write to FILE_PATH
                using (var writer = File.CreateText(FILE_PATH)) {
                    writer.Write(JsonConvert.SerializeObject(list));
                }

            } catch {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Sorts Reminders.instance.list
        /// </summary>
        public void sort() {
            if (list != null) {
                list.Sort();
            }
        }

        /// <summary>
        /// Loops through Reminders.instance.list and calls showNotificationIfReady on each Reminder,
        /// </summary>
        public void showNotifications() {
            foreach (var reminder in list) {
                reminder.showNotificationIfReady();
                if (reminder.expired) {

                }
            }
        }

        /// <summary>
        /// Removes expired Reminders from Reminders.instance.list
        /// </summary>
        public void removeExpired() {
            for (int x = list.Count - 1; x > -1; x--) {
                if (list[x].expired) {
                    list.RemoveAt(x);
                }
            }
        }
    }
}
